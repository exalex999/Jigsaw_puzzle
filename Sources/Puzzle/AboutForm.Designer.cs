namespace Puzzle
{
    partial class AboutForm
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
            this.AboutTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AboutTextBox
            // 
            this.AboutTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.AboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutTextBox.Location = new System.Drawing.Point(12, 12);
            this.AboutTextBox.Name = "AboutTextBox";
            this.AboutTextBox.ReadOnly = true;
            this.AboutTextBox.Size = new System.Drawing.Size(318, 95);
            this.AboutTextBox.TabIndex = 0;
            this.AboutTextBox.Text = "Game: Jigsaw puzzle\nAuthor: Oleksandr Grygorenko\nE-mail: o.e.grygorenko@gmail.com" +
    "";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 119);
            this.Controls.Add(this.AboutTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox AboutTextBox;

    }
}