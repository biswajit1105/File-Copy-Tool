namespace FileCopy
{
    /// <summary>
    /// File Copy Program
    /// </summary>
    public partial class FileCopy : Form
    {
        #region Member Variable

        /// <summary>
        /// Field for FileCopyingOperation class
        /// </summary>
        private readonly FileCopyingOperation _fileCopy;

        /// <summary>
        /// Cancellation Token
        /// </summary>
        private CancellationTokenSource _cancellationTokenSource;

        /// <summary>
        /// Variable to store previous chosen path
        /// </summary>
        private string? _previousSourcePath;

        /// <summary>
        /// Variable to store previous chosen path
        /// </summary>
        private string? _previousDestinationPath;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for File Copy Program
        /// </summary>
        public FileCopy()
        {
            InitializeComponent();
            FileCopyProgressBar.Visible = false;
            ProgressStatus.Visible = false;
            MoreOrFewDetailsBtn.Visible = false;
            Size = new Size(FileCopyConstants.FileCopyFormLength, FileCopyConstants.FormBreadthBeforeStart);
            _cancellationTokenSource = new CancellationTokenSource();
            _fileCopy = new FileCopyingOperation
            {
                Delegate = HandleDelegate
            };
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Button click Method for input source File Path
        /// </summary>
        /// <param name="sender">Object that raised this event</param>
        /// <param name="e">Argument that contains Data of the event</param>
        private void SelectSourceFilePathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog sourceFileDialog = new()
            {
                Title = FileCopyConstants.MsgSourceFilePath,
                InitialDirectory = _previousSourcePath
            };

            sourceFileDialog.ShowDialog();

            if (sourceFileDialog.FileName.Equals("") == false)
            {
                _previousSourcePath = Path.GetDirectoryName(sourceFileDialog.FileName);
                SourceFilePathTextBox.Text = sourceFileDialog.FileName;
            }
            else
            {
                SourceFilePathTextBox.Text = FileCopyConstants.ErrInvalidSource;
            }
        }

        /// <summary>
        /// Button click Method for input Destination Path
        /// </summary>
        /// <param name="sender">Object that raised this event</param>
        /// <param name="e">Argument that contains Data of the event</param>
        private void SelectDestinationFolderPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destinationFolderDialog = new()
            {
                SelectedPath = _previousDestinationPath
            };

            if (destinationFolderDialog.ShowDialog().Equals(DialogResult.OK) == true)
            {
                DestinationFolderPathTextbox.Text = destinationFolderDialog.SelectedPath;
                _previousDestinationPath = destinationFolderDialog.SelectedPath;
            }
            else
            {
                DestinationFolderPathTextbox.Text = FileCopyConstants.ErrInvalidDestination;
            }
        }

        /// <summary>
        /// Button click Method to Start and Cancel File Copying
        /// </summary>
        /// <param name="sender">Object that raised this event</param>
        /// <param name="e">Argument that contains Data of the event</param>
        private void StartOrCancelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // If start button is clicked
                if (StartOrCancelBtn.Text.Equals(FileCopyConstants.TextStart) == true)
                {
                    SelectSourceFilePathBtn.Enabled = false;
                    SelectDestinationFolderPathBtn.Enabled = false;
                    SourceFilePathTextBox.ReadOnly = true;
                    DestinationFolderPathTextbox.ReadOnly = true;
                    _cancellationTokenSource = new CancellationTokenSource();
                    string? sourceFilePath = SourceFilePathTextBox.Text;
                    string? destinationFolderPath = DestinationFolderPathTextbox.Text;

                    // If file path is not valid then return
                    if (PathValidation.PathValidationCheck(sourceFilePath, destinationFolderPath) == false)
                    {
                        SelectSourceFilePathBtn.Enabled = true;
                        SelectDestinationFolderPathBtn.Enabled = true;
                        SourceFilePathTextBox.ReadOnly = false;
                        DestinationFolderPathTextbox.ReadOnly = false;
                        return;
                    }

                    // Create and start the thread
                    Thread thread = new(() =>
                    {
                        string returnValue = _fileCopy.CopyFile(sourceFilePath, destinationFolderPath, _cancellationTokenSource.Token);
                        
                        if (string.IsNullOrEmpty(returnValue) == false)
                        {
                            MessageBox.Show(returnValue, FileCopyConstants.Exception, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ProcessOnThreadStop();
                        }

                        return;
                    });

                    thread.Start();
                    SourceFileNameTextBox.Text = FileCopyConstants.MsgName + Path.GetFileName(sourceFilePath);
                    ShowFileNames.Text = FileCopyConstants.MsgCopyFileFrom + Path.GetFileName(Path.GetDirectoryName(sourceFilePath)) +
                                         "\" to \"" + Path.GetFileName(destinationFolderPath) + "\"";
                    FileCopyProgressBar.Visible = true;
                    ProgressStatus.Visible = true;
                    StartOrCancelBtn.Text = FileCopyConstants.TextCancel;
                    MoreOrFewDetailsBtn.Visible = true;
                    ProgressPercentageTextBox.Visible = true;
                    MoreOrFewDetailsBtn.Text = FileCopyConstants.BtnTextMoreDetails;
                    Size = new Size(FileCopyConstants.FileCopyFormLength, FileCopyConstants.FormBreadthOnStartClick);
                    return;
                }
                // If cancel button is clicked
                else if (StartOrCancelBtn.Text.Equals(FileCopyConstants.TextCancel) == true)
                {
                    ProcessOnThreadStop();
                    _cancellationTokenSource?.Cancel();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProcessOnThreadStop();
                return;
            }
        }

        /// <summary>
        /// Button click Method for Toggle between More Details and Fewer Details
        /// </summary>
        /// <param name="sender">Object that raised this event</param>
        /// <param name="e">Argument that contains Data of the event</param>
        private void MoreOrFewDetailsBtn_Click(object sender, EventArgs e)
        {
            // Action on More Details Button Click
            if (MoreOrFewDetailsBtn.Text.Equals(FileCopyConstants.BtnTextMoreDetails) == true)
            {
                Size = new Size(FileCopyConstants.FileCopyFormLength, FileCopyConstants.MoreDetailsFormBreadth);
                RemainingTimeTextBox.Visible = true;
                SourceFileNameTextBox.Visible = true;
                FileRemainingTextBox.Visible = true;
                MoreOrFewDetailsBtn.Text = FileCopyConstants.BtnTextFewDetails;
                return;
            }
            // Action or Fewer Details Button Click
            else if (MoreOrFewDetailsBtn.Text.Equals(FileCopyConstants.BtnTextFewDetails) == true)
            {
                Size = new Size(FileCopyConstants.FileCopyFormLength, FileCopyConstants.FormBreadthOnStartClick);
                RemainingTimeTextBox.Visible = false;
                SourceFileNameTextBox.Visible = false;
                FileRemainingTextBox.Visible = false;
                MoreOrFewDetailsBtn.Text = FileCopyConstants.BtnTextMoreDetails;
                return;
            }
        }

        /// <summary>
        /// Delegate Method to Write on Form
        /// </summary>
        /// <param name="fileRemaining">File Size Remaining for file copy</param>
        /// <param name="timeRemaining">Time Remaining for file copy</param>
        /// <param name="progressPercent">Progress Percent of file copy</param>
        private void HandleDelegate(string fileRemaining, string timeRemaining, int progressPercent)
        {
            Invoke((MethodInvoker)delegate
            {
                if (progressPercent.Equals(FileCopyConstants.CompletePercentage) == true || _cancellationTokenSource.IsCancellationRequested == true)
                {
                    ProcessOnThreadStop();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(timeRemaining) == false)
                    {
                        RemainingTimeTextBox.Text = FileCopyConstants.MsgTimeRemaining + timeRemaining; 
                        FileRemainingTextBox.Text = FileCopyConstants.RemainingFileSize + fileRemaining;
                    }

                    FileCopyProgressBar.Value = progressPercent;
                    ProgressPercentageTextBox.Text = progressPercent.ToString() + FileCopyConstants.TextCompleted;
                }
            });
        }

        /// <summary>
        /// Method that contains Process that should be executed when secondary thread is Stoped
        /// </summary>
        private void ProcessOnThreadStop()
        {
            SelectSourceFilePathBtn.Enabled = true;
            SelectDestinationFolderPathBtn.Enabled = true;
            SourceFilePathTextBox.ReadOnly = false;
            DestinationFolderPathTextbox.ReadOnly = false;
            ProgressPercentageTextBox.Visible = false;
            FileCopyProgressBar.Visible = false;
            ProgressStatus.Visible = false;
            MoreOrFewDetailsBtn.Visible = false;
            StartOrCancelBtn.Text = FileCopyConstants.TextStart;
            Size = new Size(FileCopyConstants.FileCopyFormLength, FileCopyConstants.FormBreadthOnComplete);
        }

        #endregion 
    }
}