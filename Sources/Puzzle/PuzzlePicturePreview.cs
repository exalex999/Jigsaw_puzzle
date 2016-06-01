using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class PuzzlePicturePreview : Form
    {
        public PuzzlePicturePreview()
        {
            InitializeComponent();
        }

        private void PuzzlePicturePreview_ResizeEnd(object sender, EventArgs e)
        {
            MainForm.puzzlePicturePreviewWidth = this.Width;
            MainForm.puzzlePicturePreviewHeight = this.Height;
        }

        private void IsOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.IsOnTopCheckBox.Checked == true)
            {
                this.TopMost = true;
                MainForm.isPreviewPictureOnTop = true;
            }
            else
            {
                this.TopMost = false;
                MainForm.isPreviewPictureOnTop = false;
            }
        }

        private void PuzzlePicturePreview_LocationChanged(object sender, EventArgs e)
        {
            if (PreviewPictureBox.Image != null)
            {
                MainForm.puzzlePicturePreviewLeft = this.Left;
                MainForm.puzzlePicturePreviewTop = this.Top;
            }
        }

        private void PuzzlePicturePreview_Resize(object sender, EventArgs e)
        {
            PreviewPictureBox.Width = this.Width;
            PreviewPictureBox.Height = this.Height - 70;
            IsOnTopCheckBox.Top = this.Height - 64;
        }
    }
}
