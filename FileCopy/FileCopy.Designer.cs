namespace FileCopy
{
    /// <summary>
    /// Design Class for File Copy Form
    /// </summary>
    public partial class FileCopy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        internal void InitializeComponent()
        {
            SelectSourceFilePathBtn = new Button();
            SourceFilePathTextBox = new TextBox();
            DestinationFolderPathTextbox = new TextBox();
            SelectDestinationFolderPathBtn = new Button();
            Source = new Label();
            Destination = new Label();
            StartOrCancelBtn = new Button();
            ProgressStatus = new Label();
            MoreOrFewDetailsBtn = new Button();
            RemainingTimeTextBox = new TextBox();
            FileRemainingTextBox = new TextBox();
            ProgressPercentageTextBox = new TextBox();
            ShowFileNames = new TextBox();
            SourceFileNameTextBox = new TextBox();
            FileCopyProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // SelectSourceFilePathBtn
            // 
            SelectSourceFilePathBtn.CausesValidation = false;
            SelectSourceFilePathBtn.Cursor = Cursors.Hand;
            SelectSourceFilePathBtn.DialogResult = DialogResult.Retry;
            SelectSourceFilePathBtn.FlatStyle = FlatStyle.Popup;
            SelectSourceFilePathBtn.Location = new Point(602, 38);
            SelectSourceFilePathBtn.Name = "SelectSourceFilePathBtn";
            SelectSourceFilePathBtn.Size = new Size(75, 23);
            SelectSourceFilePathBtn.TabIndex = 0;
            SelectSourceFilePathBtn.Text = "File...";
            SelectSourceFilePathBtn.UseVisualStyleBackColor = true;
            SelectSourceFilePathBtn.Click += SelectSourceFilePathBtn_Click;
            // 
            // SourceFilePathTextBox
            // 
            SourceFilePathTextBox.Location = new Point(118, 38);
            SourceFilePathTextBox.Name = "SourceFilePathTextBox";
            SourceFilePathTextBox.Size = new Size(466, 23);
            SourceFilePathTextBox.TabIndex = 1;
            // 
            // DestinationFolderPathTextbox
            // 
            DestinationFolderPathTextbox.Location = new Point(118, 84);
            DestinationFolderPathTextbox.Name = "DestinationFolderPathTextbox";
            DestinationFolderPathTextbox.Size = new Size(466, 23);
            DestinationFolderPathTextbox.TabIndex = 2;
            // 
            // SelectDestinationFolderPathBtn
            // 
            SelectDestinationFolderPathBtn.BackColor = SystemColors.Control;
            SelectDestinationFolderPathBtn.CausesValidation = false;
            SelectDestinationFolderPathBtn.Cursor = Cursors.Hand;
            SelectDestinationFolderPathBtn.DialogResult = DialogResult.Retry;
            SelectDestinationFolderPathBtn.FlatStyle = FlatStyle.Popup;
            SelectDestinationFolderPathBtn.Location = new Point(602, 84);
            SelectDestinationFolderPathBtn.Name = "SelectDestinationFolderPathBtn";
            SelectDestinationFolderPathBtn.Size = new Size(75, 23);
            SelectDestinationFolderPathBtn.TabIndex = 3;
            SelectDestinationFolderPathBtn.Text = "Folder...";
            SelectDestinationFolderPathBtn.UseVisualStyleBackColor = true;
            SelectDestinationFolderPathBtn.Click += SelectDestinationFolderPathBtn_Click;
            // 
            // Source
            // 
            Source.AutoSize = true;
            Source.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Source.Location = new Point(31, 42);
            Source.Name = "Source";
            Source.Size = new Size(57, 19);
            Source.TabIndex = 4;
            Source.Text = "Source :";
            // 
            // Destination
            // 
            Destination.AutoSize = true;
            Destination.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Destination.Location = new Point(31, 88);
            Destination.Name = "Destination";
            Destination.Size = new Size(86, 19);
            Destination.TabIndex = 5;
            Destination.Text = "Destination :";
            // 
            // StartOrCancelBtn
            // 
            StartOrCancelBtn.Cursor = Cursors.Hand;
            StartOrCancelBtn.DialogResult = DialogResult.OK;
            StartOrCancelBtn.FlatStyle = FlatStyle.Popup;
            StartOrCancelBtn.Location = new Point(312, 127);
            StartOrCancelBtn.Name = "StartOrCancelBtn";
            StartOrCancelBtn.Size = new Size(75, 23);
            StartOrCancelBtn.TabIndex = 6;
            StartOrCancelBtn.Text = "Start";
            StartOrCancelBtn.UseVisualStyleBackColor = true;
            StartOrCancelBtn.Click += StartOrCancelBtn_Click;
            // 
            // ProgressStatus
            // 
            ProgressStatus.AutoSize = true;
            ProgressStatus.Location = new Point(32, 200);
            ProgressStatus.Name = "ProgressStatus";
            ProgressStatus.Size = new Size(87, 15);
            ProgressStatus.TabIndex = 8;
            ProgressStatus.Text = "Progress Status";
            // 
            // MoreOrFewDetailsBtn
            // 
            MoreOrFewDetailsBtn.AllowDrop = true;
            MoreOrFewDetailsBtn.AutoEllipsis = true;
            MoreOrFewDetailsBtn.Cursor = Cursors.Hand;
            MoreOrFewDetailsBtn.ForeColor = SystemColors.ControlText;
            MoreOrFewDetailsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MoreOrFewDetailsBtn.Location = new Point(134, 198);
            MoreOrFewDetailsBtn.Name = "MoreOrFewDetailsBtn";
            MoreOrFewDetailsBtn.Size = new Size(91, 23);
            MoreOrFewDetailsBtn.TabIndex = 11;
            MoreOrFewDetailsBtn.Text = "More Details";
            MoreOrFewDetailsBtn.UseVisualStyleBackColor = true;
            MoreOrFewDetailsBtn.Click += MoreOrFewDetailsBtn_Click;
            // 
            // RemainingTimeTextBox
            // 
            RemainingTimeTextBox.BackColor = SystemColors.Control;
            RemainingTimeTextBox.BorderStyle = BorderStyle.None;
            RemainingTimeTextBox.Location = new Point(31, 248);
            RemainingTimeTextBox.Name = "RemainingTimeTextBox";
            RemainingTimeTextBox.ReadOnly = true;
            RemainingTimeTextBox.Size = new Size(325, 16);
            RemainingTimeTextBox.TabIndex = 12;
            RemainingTimeTextBox.Cursor = Cursors.Arrow;
            // 
            // FileRemainingTextBox
            // 
            FileRemainingTextBox.BackColor = SystemColors.Control;
            FileRemainingTextBox.BorderStyle = BorderStyle.None;
            FileRemainingTextBox.Location = new Point(31, 270);
            FileRemainingTextBox.Name = "FileRemainingTextBox";
            FileRemainingTextBox.ReadOnly = true;
            FileRemainingTextBox.Size = new Size(325, 16);
            FileRemainingTextBox.TabIndex = 13;
            FileRemainingTextBox.Cursor = Cursors.Arrow;
            // 
            // ProgressPercentageTextBox
            // 
            ProgressPercentageTextBox.BackColor = SystemColors.Control;
            ProgressPercentageTextBox.BorderStyle = BorderStyle.None;
            ProgressPercentageTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressPercentageTextBox.Location = new Point(460, 146);
            ProgressPercentageTextBox.Name = "ProgressPercentageTextBox";
            ProgressPercentageTextBox.ReadOnly = true;
            ProgressPercentageTextBox.RightToLeft = RightToLeft.No;
            ProgressPercentageTextBox.Size = new Size(217, 20);
            ProgressPercentageTextBox.TabIndex = 14;
            ProgressPercentageTextBox.TextAlign = HorizontalAlignment.Right;
            ProgressPercentageTextBox.Cursor = Cursors.Arrow;
            // 
            // ShowFileNames
            // 
            ShowFileNames.BackColor = SystemColors.Control;
            ShowFileNames.BorderStyle = BorderStyle.None;
            ShowFileNames.Location = new Point(403, 199);
            ShowFileNames.Name = "ShowFileNames";
            ShowFileNames.ReadOnly = true;
            ShowFileNames.Size = new Size(274, 16);
            ShowFileNames.TabIndex = 15;
            ShowFileNames.TextAlign = HorizontalAlignment.Right;
            ShowFileNames.Cursor = Cursors.Arrow;
            // 
            // SourceFileNameTextBox
            // 
            SourceFileNameTextBox.BackColor = SystemColors.Control;
            SourceFileNameTextBox.BorderStyle = BorderStyle.None;
            SourceFileNameTextBox.Location = new Point(31, 226);
            SourceFileNameTextBox.Name = "SourceFileNameTextBox";
            SourceFileNameTextBox.ReadOnly = true;
            SourceFileNameTextBox.Size = new Size(325, 16);
            SourceFileNameTextBox.TabIndex = 16;
            SourceFileNameTextBox.Cursor = Cursors.Arrow;
            // 
            // FileCopyProgressBar
            // 
            FileCopyProgressBar.Location = new Point(31, 168);
            FileCopyProgressBar.Name = "FileCopyProgressBar";
            FileCopyProgressBar.Size = new Size(646, 23);
            FileCopyProgressBar.Style = ProgressBarStyle.Continuous;
            FileCopyProgressBar.TabIndex = 7;
            // 
            // FileCopy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 304);
            Controls.Add(SourceFileNameTextBox);
            Controls.Add(ShowFileNames);
            Controls.Add(ProgressPercentageTextBox);
            Controls.Add(FileRemainingTextBox);
            Controls.Add(RemainingTimeTextBox);
            Controls.Add(MoreOrFewDetailsBtn);
            Controls.Add(ProgressStatus);
            Controls.Add(FileCopyProgressBar);
            Controls.Add(StartOrCancelBtn);
            Controls.Add(Destination);
            Controls.Add(Source);
            Controls.Add(SelectDestinationFolderPathBtn);
            Controls.Add(DestinationFolderPathTextbox);
            Controls.Add(SourceFilePathTextBox);
            Controls.Add(SelectSourceFilePathBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FileCopy";
            Text = "File Copy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal static ProgressBar FileCopyProgressBar;
        internal static Button SelectSourceFilePathBtn;
        internal static TextBox SourceFilePathTextBox;
        internal static TextBox DestinationFolderPathTextbox;
        internal static Button SelectDestinationFolderPathBtn;
        internal static Label Source;
        internal static Label Destination;
        internal static Button StartOrCancelBtn;
        internal static Button MoreOrFewDetailsBtn;
        internal static TextBox RemainingTimeTextBox;
        internal static TextBox FileRemainingTextBox;
        internal static TextBox ProgressPercentageTextBox;
        internal static TextBox ShowFileNames;
        internal static TextBox SourceFileNameTextBox;
        internal static Label ProgressStatus;

        public EventHandler Form1_Load { get; private set; }
    }
}