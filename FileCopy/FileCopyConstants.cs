namespace FileCopy
{
    /// <summary>
    /// Constant Class of File Copy Form
    /// </summary>
    public class FileCopyConstants
    {
        #region Form tools Constants

        /// <summary>
        /// Text Start
        /// </summary>
        public const string TextStart = "Start";

        /// <summary>
        /// Text Cancel
        /// </summary>
        public const string TextCancel = "Cancel";

        /// <summary>
        /// Message source File path
        /// </summary>
        public const string MsgSourceFilePath = "Source File Path";

        /// <summary>
        /// Message Name
        /// </summary>
        public const string MsgName = "Name: ";

        /// <summary>
        /// Message Copying File from
        /// </summary>
        public const string MsgCopyFileFrom = "Copying File From \"";

        /// <summary>
        /// Message Percentage of File Copying Completed
        /// </summary>
        public const string TextCompleted = " % Completed";

        /// <summary>
        /// Text on button More Details
        /// </summary>
        public const string BtnTextMoreDetails = "More Details";

        /// <summary>
        /// Text on button Fewer Details
        /// </summary>
        public const string BtnTextFewDetails = "Fewer Details";

        #endregion

        #region Constants for calculating Remaining File size

        /// <summary>
        /// Remaining File Size for File Copy
        /// </summary>
        public const string RemainingFileSize = "Remaining File Size: ";

        /// <summary>
        /// Message GigaBytes
        /// </summary>
        public const string MsgGigaBytes = " GigaBytes ";

        /// <summary>
        /// Message MegaBytes
        /// </summary>
        public const string MsgMegaBytes = " MegaBytes ";

        /// <summary>
        /// Message KiloBytes
        /// </summary>
        public const string MsgKiloBytes = " KiloBytes ";

        /// <summary>
        /// Message Bytes
        /// </summary>
        public const string MsgBytes = " Bytes";

        /// <summary>
        /// Value of one gigabyte in byte
        /// </summary>
        public const ulong OneGigabyteInBytes = 1024 * 1024 * 1024;

        /// <summary>
        /// Value of one Megabyte in byte
        /// </summary>
        public const ulong OneMegabyteInBytes = 1024 * 1024;

        /// <summary>
        /// Value of one Kilobyte in byte
        /// </summary>
        public const ulong OneKilobyteInBytes = 1024;

        #endregion

        #region Constants for calculating Remaining Time

        /// <summary>
        /// Message Time Remaining
        /// </summary>
        public const string MsgTimeRemaining = "Time Remaining: About ";

        /// <summary>
        /// Message Days
        /// </summary>
        public const string MsgDays = " Days ";

        /// <summary>
        /// Message Hours
        /// </summary>
        public const string MsgHours = " Hours ";

        /// <summary>
        /// Message Minutes
        /// </summary>
        public const string MsgMinutes = " Minutes ";

        /// <summary>
        /// Message Seconds
        /// </summary>
        public const string MsgSeconds = " Seconds ";

        /// <summary>
        /// Message MiliSeconds
        /// </summary>
        public const string MsgMiliSeconds = " MilliSeconds";

        #endregion

        #region Error Messages 

        /// <summary>
        /// Error Message if Directory Does not Exist for destination path
        /// </summary>
        public const string ErrDirectoryNotExits = "Directory Does not Exist";

        /// <summary>
        /// Error Message if file does not exists for Source Path
        /// </summary>
        public const string ErrFileNotExits = "File Does not Exist";

        /// <summary>
        /// Error Message that Source File Path and Destination Path File cannot be same
        /// </summary>
        public const string ErrSameFilePaths = "Source File Path and Destination Path File cannot be same";

        /// <summary>
        /// Message Want to overwrite the file
        /// </summary>
        public const string MsgWantToOverwrite = "Do you want to Overwrite?";

        /// <summary>
        /// Message that File already exists
        /// </summary>
        public const string  MsgFileAlreadyExist = "File Already Exist!";

        /// <summary>
        /// Error Invalid Source File Path
        /// </summary>
        public const string ErrInvalidSource = "Invalid Source Path! ";

        /// <summary>
        /// Error Invalid Destination Folder Path
        /// </summary>
        public const string ErrInvalidDestination = "Invalid Destination Path! ";

        /// <summary>
        /// Error Interrupted
        /// </summary>
        public const string ErrInterruptes = "Interrupted: ";

        /// <summary>
        /// Thread Canceled
        /// </summary>
        public const string ErrThreadCanceled = "Thread canceled";

        /// <summary>
        /// Error Message when File Path is Empty
        /// </summary>
        public const string ErrFilePathEmpty = "Error: File path Cannot be null or Empty.";

        /// <summary>
        /// Error message when File Path Contains invalid Characters
        /// </summary>
        public const string ErrPathContainsInvalidChar = "Error: File Path contains invalid Characters.";

        /// <summary>
        /// Error Invalid File Path
        /// </summary>
        public const string ErrInvalidFilePath = "Invalid File Path. Error: ";

        #endregion

        #region Message Box Captions

        /// <summary>
        /// Confirmation
        /// </summary>
        public const string Confirmation = "Confirmation";

        /// <summary>
        /// Error
        /// </summary>
        public const string Error = "Error";

        /// <summary>
        /// Exception
        /// </summary>
        public const string Exception = "Exception";

        #endregion

        #region Form Size

        /// <summary>
        /// Length of File Copy Form
        /// </summary>
        public const int FileCopyFormLength = 720;

        /// <summary>
        /// Breadth of File Copy Program when  
        /// </summary>
        public const int MoreDetailsFormBreadth = 339;

        /// <summary>
        /// Breadth of File Copy Program before clicking start button
        /// </summary>
        public const int FormBreadthBeforeStart = 200;

        /// <summary>
        /// Breadth of File Copy Program after clicking start button
        /// </summary>
        public const int FormBreadthOnStartClick = 266;

        /// <summary>
        /// Breadth of File Copy Program after clicking cancel button
        /// </summary>
        public const int FormBreadthOnCancelClick = 202;

        /// <summary>
        /// Breadth of File Copy Program after completing File copy
        /// </summary>
        public const int FormBreadthOnComplete = 202;

        /// <summary>
        /// Completing Percentage
        /// </summary>
        public const int CompletePercentage = 100;

        #endregion
    }
}