namespace Puzzle
{
    partial class ScoreForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RecordsDataGrid = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneralTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfPuzzles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Made = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordsDataGrid
            // 
            this.RecordsDataGrid.AllowUserToAddRows = false;
            this.RecordsDataGrid.AllowUserToDeleteRows = false;
            this.RecordsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RecordsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RecordsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.Score,
            this.GeneralTime,
            this.NumberOfPuzzles,
            this.Made});
            this.RecordsDataGrid.Location = new System.Drawing.Point(1, 0);
            this.RecordsDataGrid.MultiSelect = false;
            this.RecordsDataGrid.Name = "RecordsDataGrid";
            this.RecordsDataGrid.ReadOnly = true;
            this.RecordsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecordsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RecordsDataGrid.ShowCellToolTips = false;
            this.RecordsDataGrid.Size = new System.Drawing.Size(595, 381);
            this.RecordsDataGrid.TabIndex = 0;
            // 
            // Place
            // 
            this.Place.Frozen = true;
            this.Place.HeaderText = "Position";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.Frozen = true;
            this.Score.HeaderText = "Points";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // GeneralTime
            // 
            this.GeneralTime.Frozen = true;
            this.GeneralTime.HeaderText = "Time";
            this.GeneralTime.Name = "GeneralTime";
            this.GeneralTime.ReadOnly = true;
            // 
            // NumberOfPuzzles
            // 
            this.NumberOfPuzzles.Frozen = true;
            this.NumberOfPuzzles.HeaderText = "Number of pieces";
            this.NumberOfPuzzles.Name = "NumberOfPuzzles";
            this.NumberOfPuzzles.ReadOnly = true;
            // 
            // Made
            // 
            this.Made.Frozen = true;
            this.Made.HeaderText = "Date";
            this.Made.Name = "Made";
            this.Made.ReadOnly = true;
            this.Made.Width = 150;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 382);
            this.Controls.Add(this.RecordsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScoreForm";
            this.ShowIcon = false;
            this.Text = "Scores";
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView RecordsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Made;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfPuzzles;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneralTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
    }
}