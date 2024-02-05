using System.Diagnostics;

namespace FileCopy
{
    /// <summary>
    /// Operation Class of File Copy Program
    /// </summary>
    internal partial class FileCopyingOperation
    {
        #region Delegate

        /// <summary>
        /// Property to get and set values to Delegate
        /// </summary>
        internal Action<string, string, int> Delegate { get; set; } = delegate { };

        #endregion

        #region Internal Method

        /// <summary>
        /// Method to Copy File From Source Path to Destination Path
        /// </summary>
        /// <param name="sourceFilePath">Source File Path</param>
        /// <param name="destinationFolderPath">Destination File Path</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        internal string CopyFile(string sourceFilePath, string destinationFolderPath, CancellationToken cancellationToken)
        {
            try
            {
                FileStream destinationFile = new(destinationFolderPath + "\\" + Path.GetFileName(sourceFilePath), FileMode.Create);
                FileStream sourceFile = new(sourceFilePath, FileMode.Open);
                byte[] buffer = new byte[FileCopyConstants.OneKilobyteInBytes];
                var timer = new Stopwatch();
                timer.Start();
                int bytesRead = 0;
                long count = 0;

                // Loop will Iterate till the end of the Source file
                while ((bytesRead = sourceFile.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationFile.Write(buffer, 0, bytesRead);
                    double remainingBytes = sourceFile.Length - destinationFile.Length;
                    int progressPercent = (int)(sourceFile.Position * 100 / sourceFile.Length);
                    TimeSpan tickToCopyFile = TimeSpan.FromTicks((timer.Elapsed.Ticks / ++count) * (int)Math.Ceiling(remainingBytes / FileCopyConstants.OneKilobyteInBytes));
                    string timeRemaining = RemainingTime(tickToCopyFile);
                    string fileRemaining = RemainingFileSize(remainingBytes);

                    // Delegate Method to Write on Form
                    Delegate.Invoke(fileRemaining, timeRemaining, progressPercent);

                    if (cancellationToken.IsCancellationRequested == true)
                    {
                        destinationFile.Dispose();
                        string copiedFilePath = Path.Combine(destinationFolderPath, Path.GetFileName(sourceFilePath));
                        File.Delete(copiedFilePath);
                        break;
                    }
                }

                destinationFile.Dispose();
                sourceFile.Dispose();
                return string.Empty;
            }
            catch (ThreadInterruptedException e)
            {
                return FileCopyConstants.ErrInterruptes + e.Message;
            }
            catch (OperationCanceledException e)
            {
                return FileCopyConstants.ErrThreadCanceled + e.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Method to Display Time Remaining to copy File
        /// </summary>
        /// <param name="time">Time Remaining to Copy File in Ticks</param>
        /// <returns>Time Remaining to Copy File in Proper Format</returns>
        private static string RemainingTime(TimeSpan time)
        {
            string remainingTime = string.Empty;

            if (time.Days.Equals(0) == false)
            {
                remainingTime += time.Days + FileCopyConstants.MsgDays;
            }

            if (time.Hours.Equals(0) == false)
            {
                remainingTime += time.Hours + FileCopyConstants.MsgHours;
            }

            if (time.Minutes.Equals(0) == false)
            {
                remainingTime += time.Minutes + FileCopyConstants.MsgMinutes;
            }

            if (time.Seconds.Equals(0) == false)
            {
                remainingTime += time.Seconds + FileCopyConstants.MsgSeconds;
            }

            return remainingTime;
        }

        /// <summary>
        /// Method to calculate File Size Remaining To copy file
        /// </summary>
        /// <param name="remainingBytes"> Remaining File Size to Copy in bytes</param>
        /// <returns>Remaining File Size to Copy in proper storage unit</returns>
        private static string RemainingFileSize(double remainingBytes)
        {
            string remainingTimeOutput;

            if (remainingBytes > FileCopyConstants.OneGigabyteInBytes)
            {
                remainingBytes = Math.Round(remainingBytes / (FileCopyConstants.OneGigabyteInBytes));
                remainingTimeOutput = remainingBytes + FileCopyConstants.MsgGigaBytes;
                return remainingTimeOutput;
            }
            else if (remainingBytes > FileCopyConstants.OneMegabyteInBytes)
            {
                remainingBytes = Math.Round(remainingBytes / (FileCopyConstants.OneMegabyteInBytes));
                remainingTimeOutput = remainingBytes + FileCopyConstants.MsgMegaBytes;
                return remainingTimeOutput;
            }
            else if (remainingBytes > FileCopyConstants.OneKilobyteInBytes)
            {
                remainingBytes = Math.Round(remainingBytes / FileCopyConstants.OneKilobyteInBytes);
                remainingTimeOutput = remainingBytes + FileCopyConstants.MsgKiloBytes;
                return remainingTimeOutput;
            }
            else if (remainingBytes < FileCopyConstants.OneKilobyteInBytes && remainingBytes > 0)
            {
                remainingBytes = Math.Round(remainingBytes / FileCopyConstants.OneKilobyteInBytes);
                remainingTimeOutput = remainingBytes + FileCopyConstants.MsgBytes;
                return remainingTimeOutput;
            }
            else
            {
                remainingTimeOutput = Math.Round(remainingBytes) + FileCopyConstants.MsgBytes;
                return remainingTimeOutput;
            }
        }

        #endregion
    }
}
