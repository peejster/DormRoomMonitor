using Windows.Devices.Gpio;

namespace DormRoomMonitor
{
    /// <summary>
    /// Interface with the device's GPIO controller in order to monitor for motion and control the LED.
    /// </summary>
    public class GpioHelper
    {
        private GpioController gpioController;
        private GpioPin pirSensor;

        /// <summary>
        /// Initialize the GPIO pins. Configure the PIR motion sensor and the LED.
        /// Returns true if initialization is successful and Gpio can be utilized. Returns false otherwise.
        /// </summary>
        public bool Initialize()
        {
            // Get the GpioController
            gpioController = GpioController.GetDefault();
            if (gpioController == null)
            {
                // There is no Gpio Controller on this device so return false.
                return false;
            }

            // Open the GPIO pin that interacts with the PIR sensor
            pirSensor = gpioController.OpenPin(GpioConstants.PirPin);

            if (pirSensor == null)
            {
                // Pin wasn't opened properly so return false
                return false;
            }

            // Set the direction of the PIR sensor as input
            pirSensor.SetDriveMode(GpioPinDriveMode.Input);

            //Initialization was successfull, return true
            return true;
        }

        /// <summary>
        /// Returns the GpioPin for the PIR sensor. Will be used in to setup event handler when motion is detected.
        /// </summary>
        public GpioPin GetPirSensor()
        {
            return pirSensor;
        }
    }
}

