namespace Puzzle
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.GameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PreviewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PathToPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberOfPuzzlesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberOfPuzzlesTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.IsPreviewOnTopButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewOnTopButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewNotOnTopButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FormColorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadRecordsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveRecordsAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.GameLastingTimer = new System.Windows.Forms.Timer(this.components);
            this.MainFormColorDialog = new System.Windows.Forms.ColorDialog();
            this.RecordsSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.GameSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.RecordsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GameOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameButton,
            this.ServiceButton,
            this.StatisticsButton,
            this.TimeLabel});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(894, 24);
            this.MainMenu.TabIndex = 9;
            this.MainMenu.Text = "MainMenu";
            // 
            // GameButton
            // 
            this.GameButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartGameButton,
            this.toolStripSeparator2,
            this.OpenGameButton,
            this.SaveGameButton,
            this.SaveGameAsButton,
            this.toolStripSeparator1,
            this.PreviewButton,
            this.ExitButton});
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(50, 20);
            this.GameButton.Text = "Game";
            // 
            // RestartGameButton
            // 
            this.RestartGameButton.Name = "RestartGameButton";
            this.RestartGameButton.Size = new System.Drawing.Size(152, 22);
            this.RestartGameButton.Text = "Restart";
            this.RestartGameButton.Click += new System.EventHandler(this.RestartGameButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // OpenGameButton
            // 
            this.OpenGameButton.Name = "OpenGameButton";
            this.OpenGameButton.Size = new System.Drawing.Size(152, 22);
            this.OpenGameButton.Text = "Open...";
            this.OpenGameButton.Click += new System.EventHandler(this.OpenGameButton_Click);
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(152, 22);
            this.SaveGameButton.Text = "Save";
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // SaveGameAsButton
            // 
            this.SaveGameAsButton.Name = "SaveGameAsButton";
            this.SaveGameAsButton.Size = new System.Drawing.Size(152, 22);
            this.SaveGameAsButton.Text = "Save as...";
            this.SaveGameAsButton.Click += new System.EventHandler(this.SaveGameAsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // PreviewButton
            // 
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(152, 22);
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(152, 22);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ServiceButton
            // 
            this.ServiceButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PathToPictureButton,
            this.NumberOfPuzzlesButton,
            this.IsPreviewOnTopButton,
            this.FormColorButton});
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(61, 20);
            this.ServiceButton.Text = "Options";
            // 
            // PathToPictureButton
            // 
            this.PathToPictureButton.Name = "PathToPictureButton";
            this.PathToPictureButton.Size = new System.Drawing.Size(181, 22);
            this.PathToPictureButton.Text = "Path to the picture...";
            this.PathToPictureButton.Click += new System.EventHandler(this.PathToPictureButton_Click);
            // 
            // NumberOfPuzzlesButton
            // 
            this.NumberOfPuzzlesButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumberOfPuzzlesTextBox});
            this.NumberOfPuzzlesButton.Name = "NumberOfPuzzlesButton";
            this.NumberOfPuzzlesButton.Size = new System.Drawing.Size(181, 22);
            this.NumberOfPuzzlesButton.Text = "Number of pieces";
            // 
            // NumberOfPuzzlesTextBox
            // 
            this.NumberOfPuzzlesTextBox.Name = "NumberOfPuzzlesTextBox";
            this.NumberOfPuzzlesTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumberOfPuzzlesTextBox.Text = "4";
            // 
            // IsPreviewOnTopButton
            // 
            this.IsPreviewOnTopButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreviewOnTopButton,
            this.PreviewNotOnTopButton});
            this.IsPreviewOnTopButton.Name = "IsPreviewOnTopButton";
            this.IsPreviewOnTopButton.Size = new System.Drawing.Size(181, 22);
            this.IsPreviewOnTopButton.Text = "Fixed window";
            // 
            // PreviewOnTopButton
            // 
            this.PreviewOnTopButton.Name = "PreviewOnTopButton";
            this.PreviewOnTopButton.Size = new System.Drawing.Size(152, 22);
            this.PreviewOnTopButton.Text = "Yes";
            this.PreviewOnTopButton.Click += new System.EventHandler(this.PreviewOnTopButton_Click);
            // 
            // PreviewNotOnTopButton
            // 
            this.PreviewNotOnTopButton.Name = "PreviewNotOnTopButton";
            this.PreviewNotOnTopButton.Size = new System.Drawing.Size(152, 22);
            this.PreviewNotOnTopButton.Text = "No";
            this.PreviewNotOnTopButton.Click += new System.EventHandler(this.PreviewNotOnTopButton_Click);
            // 
            // FormColorButton
            // 
            this.FormColorButton.Name = "FormColorButton";
            this.FormColorButton.Size = new System.Drawing.Size(181, 22);
            this.FormColorButton.Text = "Theme..";
            this.FormColorButton.Click += new System.EventHandler(this.FormColorButton_Click);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowRecords,
            this.LoadRecordsButton,
            this.SaveRecordsAsButton,
            this.toolStripSeparator3,
            this.AboutButton});
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(65, 20);
            this.StatisticsButton.Text = "Statistics";
            // 
            // ShowRecords
            // 
            this.ShowRecords.Name = "ShowRecords";
            this.ShowRecords.Size = new System.Drawing.Size(157, 22);
            this.ShowRecords.Text = "Show scores";
            this.ShowRecords.Click += new System.EventHandler(this.ShowRecords_Click);
            // 
            // LoadRecordsButton
            // 
            this.LoadRecordsButton.Name = "LoadRecordsButton";
            this.LoadRecordsButton.Size = new System.Drawing.Size(157, 22);
            this.LoadRecordsButton.Text = "Load scores..";
            this.LoadRecordsButton.Click += new System.EventHandler(this.LoadRecordsButton_Click);
            // 
            // SaveRecordsAsButton
            // 
            this.SaveRecordsAsButton.Name = "SaveRecordsAsButton";
            this.SaveRecordsAsButton.Size = new System.Drawing.Size(157, 22);
            this.SaveRecordsAsButton.Text = "Save scores as...";
            this.SaveRecordsAsButton.Click += new System.EventHandler(this.SaveRecordsAsButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(157, 22);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(88, 20);
            this.TimeLabel.Text = "Time: 0:00:00";
            // 
            // GameLastingTimer
            // 
            this.GameLastingTimer.Interval = 1000;
            this.GameLastingTimer.Tick += new System.EventHandler(this.GameLastingTimer_Tick);
            // 
            // MainFormColorDialog
            // 
            this.MainFormColorDialog.Color = System.Drawing.SystemColors.Control;
            this.MainFormColorDialog.FullOpen = true;
            // 
            // RecordsSaveFileDialog
            // 
            this.RecordsSaveFileDialog.Filter = "Scores files|*.scrpzl|All files|*.*";
            this.RecordsSaveFileDialog.Title = "Save scores as...";
            this.RecordsSaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.RecordsSaveFileDialog_FileOk);
            // 
            // GameSaveFileDialog
            // 
            this.GameSaveFileDialog.Filter = "Saved game files|*.gmpzl|All files|*.*";
            this.GameSaveFileDialog.Title = "Save game as...";
            this.GameSaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.GameSaveFileDialog_FileOk);
            // 
            // RecordsOpenFileDialog
            // 
            this.RecordsOpenFileDialog.Filter = "Scores files|*.scrpzl|All files|*.*";
            this.RecordsOpenFileDialog.Title = "Load scores...";
            this.RecordsOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.RecordsOpenFileDialog_FileOk);
            // 
            // GameOpenFileDialog
            // 
            this.GameOpenFileDialog.Filter = "Saved game files|*.gmpzl|All files|*.*";
            this.GameOpenFileDialog.Title = "Open game...";
            this.GameOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.GameOpenFileDialog_FileOk);
            // 
            // ImageOpenFileDialog
            // 
            this.ImageOpenFileDialog.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png|All files|*.*";
            this.ImageOpenFileDialog.Title = "Open picture..";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 584);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Jigsaw puzzle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem GameButton;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem ServiceButton;
        private System.Windows.Forms.ToolStripMenuItem PathToPictureButton;
        private System.Windows.Forms.ToolStripMenuItem NumberOfPuzzlesButton;
        private System.Windows.Forms.ToolStripTextBox NumberOfPuzzlesTextBox;
        private System.Windows.Forms.ToolStripMenuItem RestartGameButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OpenGameButton;
        private System.Windows.Forms.ToolStripMenuItem SaveGameButton;
        private System.Windows.Forms.ToolStripMenuItem SaveGameAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PreviewButton;
        private System.Windows.Forms.ToolStripMenuItem IsPreviewOnTopButton;
        private System.Windows.Forms.ToolStripMenuItem PreviewOnTopButton;
        private System.Windows.Forms.ToolStripMenuItem PreviewNotOnTopButton;
        private System.Windows.Forms.ToolStripMenuItem StatisticsButton;
        private System.Windows.Forms.ToolStripMenuItem ShowRecords;
        private System.Windows.Forms.ToolStripMenuItem SaveRecordsAsButton;
        private System.Windows.Forms.ToolStripMenuItem LoadRecordsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem TimeLabel;
        private System.Windows.Forms.Timer GameLastingTimer;
        private System.Windows.Forms.ToolStripMenuItem FormColorButton;
        private System.Windows.Forms.ColorDialog MainFormColorDialog;
        private System.Windows.Forms.SaveFileDialog RecordsSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog GameSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog RecordsOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog GameOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog ImageOpenFileDialog;
    }
}

