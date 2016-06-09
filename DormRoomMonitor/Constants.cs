namespace DormRoomMonitor
{
    /// <summary>
    /// General constant variables
    /// </summary>
    public static class GeneralConstants
    {
        // With no GPU support, the Raspberry Pi cannot display the live camera feed so this variable should be set to true.
        // However, if you are deploying to other harware on which Windows 10 IoT Core does have GPU support, set it to fale.
        public const bool DisableLiveCameraFeed = true;

        // Oxford Face API Primary should be entered here
        // You can obtain a subscription key for Face API by following the instructions here: https://www.projectoxford.ai/doc/general/subscription-key-mgmt
        public const string OxfordAPIKey = "<your Oxford Face API key>";

        // Name of the folder in which all Whitelist data is stored
        public const string WhiteListFolderName = "Dorm_Room_Monitor_Whitelist";

        // Name of the folder in which all the intruder data is stored
        public const string IntruderFolderName = "Dorm Room Monitor Intruders";
    }

    /// <summary>
    /// Constant variables that hold messages to be read via the SpeechHelper class
    /// </summary>
    public static class SpeechContants
    {
        public const string InitialGreetingMessage = "Dorm room monitor has been activated.";
        public const string IntruderDetectedMessage = "Intruder detected.";
        public const string NotAllowedEntryMessage = "Sorry! I don't recognize you. You are not authorized to be here.";
        public const string NoCameraMessage = "Sorry! It seems like your camera has not been fully initialized.";

        public static string AllowedEntryMessage(string visitorName)
        {
            return "Hello " + visitorName + "! You are authorized to be here.";
        }
    }

    /// <summary>
    /// Constant variables that hold values used to interact with device Gpio
    /// </summary>
    public static class GpioConstants
    {
        // The GPIO pin that the PIR motion sensor is attached to
        public const int PirPin = 5;
    }
}

