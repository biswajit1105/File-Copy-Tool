namespace FileCopy
{
    /// <summary>
    /// Class to Validate Path
    /// </summary>
    internal class PathValidation
    {
        #region Internal Methods

        /// <summary>
        /// Method to check validation of Source and Destination paths 
        /// </summary>
        /// <param name="sourceFilePath">source File Path</param>
        /// <param name="destinationFolderPath">destination Folder Path</param>
        /// <returns>True if file path is valid else return false</returns>
        internal static bool PathValidationCheck(string sourceFilePath, string destinationFolderPath)
        {
            // Check for valid source file path
            if (PathValidation.ValidateFilePath(sourceFilePath, out string errorMsg1) == false)
            {
                MessageBox.Show(FileCopyConstants.ErrInvalidSource + errorMsg1, FileCopyConstants.Error, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check for source file path exists
            if (File.Exists(sourceFilePath) == false)
            {
                MessageBox.Show(FileCopyConstants.ErrInvalidSource + FileCopyConstants.ErrFileNotExits, FileCopyConstants.Error, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check for valid destination file path
            if (PathValidation.ValidateFilePath(destinationFolderPath, out string errorMsg2) == false)
            {
                MessageBox.Show(FileCopyConstants.ErrInvalidDestination + errorMsg2, FileCopyConstants.Error, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check for Destination file path exists
            if (Directory.Exists(destinationFolderPath) == false)
            {
                MessageBox.Show(FileCopyConstants.ErrInvalidDestination + FileCopyConstants.ErrDirectoryNotExits, FileCopyConstants.Error, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // check if source file directory and destination file path are same
            if (Path.GetDirectoryName(sourceFilePath) == destinationFolderPath)
            {
                MessageBox.Show(FileCopyConstants.ErrSameFilePaths, FileCopyConstants.Error, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string sourceFileName = Path.GetFileName(sourceFilePath);
            string filePath = Path.Combine(destinationFolderPath, sourceFileName);

            // Checks if File is Already Present in the Destination Folder
            if (File.Exists(filePath) == true)
            {
                DialogResult result = MessageBox.Show(FileCopyConstants.MsgFileAlreadyExist + Environment.NewLine +
                FileCopyConstants.MsgWantToOverwrite, FileCopyConstants.Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks valid file Path
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <param name="errorMsg">Error Message</param>
        /// <returns>True if file path is valid else False</returns>
        internal static bool ValidateFilePath(string filePath, out string errorMsg)
        {
            try
            {
                // Check if File Path is null or Empty
                if (string.IsNullOrWhiteSpace(filePath) == true)
                {
                    errorMsg = FileCopyConstants.ErrFilePathEmpty;
                    return false;
                }

                // Checks if File Path Contains Invalid Characters
                if ((filePath.IndexOfAny(Path.GetInvalidPathChars()) > 0 || filePath.Contains('?') || filePath.Contains('*')) == true)
                {
                    errorMsg = FileCopyConstants.ErrPathContainsInvalidChar;
                    return false;
                }

                errorMsg = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = FileCopyConstants.ErrInvalidFilePath + ex.Message;
                return false;
            }
        }

        #endregion
    }
}
