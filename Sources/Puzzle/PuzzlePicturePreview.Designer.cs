namespace Puzzle
{
    partial class PuzzlePicturePreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IsOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IsOnTopCheckBox
            // 
            this.IsOnTopCheckBox.AutoSize = true;
            this.IsOnTopCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IsOnTopCheckBox.Location = new System.Drawing.Point(7, 465);
            this.IsOnTopCheckBox.Name = "IsOnTopCheckBox";
            this.IsOnTopCheckBox.Size = new System.Drawing.Size(102, 18);
            this.IsOnTopCheckBox.TabIndex = 1;
            this.IsOnTopCheckBox.Text = "Fix the window";
            this.IsOnTopCheckBox.UseVisualStyleBackColor = true;
            this.IsOnTopCheckBox.CheckedChanged += new System.EventHandler(this.IsOnTopCheckBox_CheckedChanged);
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(680, 459);
            this.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewPictureBox.TabIndex = 0;
            this.PreviewPictureBox.TabStop = false;
            // 
            // PuzzlePicturePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 491);
            this.Controls.Add(this.IsOnTopCheckBox);
            this.Controls.Add(this.PreviewPictureBox);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "PuzzlePicturePreview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Preview";
            this.ResizeEnd += new System.EventHandler(this.PuzzlePicturePreview_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.PuzzlePicturePreview_LocationChanged);
            this.Resize += new System.EventHandler(this.PuzzlePicturePreview_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox PreviewPictureBox;
        public System.Windows.Forms.CheckBox IsOnTopCheckBox;

    }
}