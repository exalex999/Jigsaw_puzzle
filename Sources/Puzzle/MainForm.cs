using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Threading;
using System.Media;

namespace Puzzle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        PuzzlePicturePreview puzzlePicturePreview = new PuzzlePicturePreview();
        public static bool isPreviewPictureOnTop = false;
        public static int puzzlePicturePreviewHeight = 529;
        public static int puzzlePicturePreviewWidth = 695;
        public static int puzzlePicturePreviewTop = 0;
        public static int puzzlePicturePreviewLeft = 0;
        DataTable scoreTable = new DataTable();
        DateTime gameTime;
        Bitmap startPicture;
        PictureBox clickedPuzzle;
        PictureBox[,] resultPictureBoxes;
        BinaryFormatter scoreTableBinaryFormatter = new BinaryFormatter();
        FileStream scoreTableFileStream;
        bool[,][] arePuzzlesConnected;
        int puzNmb = 1;
        SoundPlayer sp;

        [Serializable]
        public class SerializatedGame
        {
            public Point[,] location;
            public bool[,][] arePuzzlesConnected;
            public string pathToPicture;
            public string numberOfPuzzles;
            public bool isPreviewOnTop;
            public Color theme;
            public DateTime gameTime;
        }

        void ClearPuzzlesData()
        {
            this.Controls.Clear();
            this.Controls.Add(MainMenu);
        }

        void IsPuzzlesConnected()
        {
            int x = -1;
            int y = -1;
            for (int i = 0; i < resultPictureBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < resultPictureBoxes.Length / resultPictureBoxes.GetLength(0); j++)
                {
                    if (resultPictureBoxes[i, j] == clickedPuzzle)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }
                if (x != -1)
                    break;
            }
            if (x == -1)
                return;
            arePuzzlesConnected[x, y][3] = false;
            try { arePuzzlesConnected[x - 1, y][1] = false; }
            catch { }
            arePuzzlesConnected[x, y][0] = false;
            try { arePuzzlesConnected[x, y - 1][2] = false; }
            catch { }
            arePuzzlesConnected[x, y][1] = false;
            try { arePuzzlesConnected[x + 1, y][3] = false; }
            catch { }
            arePuzzlesConnected[x, y][2] = false;
            try { arePuzzlesConnected[x, y + 1][0] = false; }
            catch { }
            try
            {
                if (resultPictureBoxes[x, y].Left - resultPictureBoxes[x - 1, y].Left - resultPictureBoxes[x - 1, y].Width < 10 && resultPictureBoxes[x, y].Left - resultPictureBoxes[x - 1, y].Left - resultPictureBoxes[x - 1, y].Width > -10 && resultPictureBoxes[x, y].Top - resultPictureBoxes[x - 1, y].Top < 10 && resultPictureBoxes[x, y].Top - resultPictureBoxes[x - 1, y].Top > -10)
                {
                    try { sp.Dispose(); }
                    catch { }
                    sp = new SoundPlayer(Properties.Resources.PuzzleConnect);
                    sp.Play();
                    resultPictureBoxes[x, y].Left = resultPictureBoxes[x - 1, y].Left + resultPictureBoxes[x - 1, y].Width;
                    resultPictureBoxes[x, y].Top = resultPictureBoxes[x - 1, y].Top;
                    arePuzzlesConnected[x, y][3] = true;
                    arePuzzlesConnected[x - 1, y][1] = true;
                    arePuzzlesConnected[x, y][0] = false;
                    try { arePuzzlesConnected[x, y - 1][2] = false; }
                    catch { }
                    arePuzzlesConnected[x, y][1] = false;
                    try { arePuzzlesConnected[x + 1, y][3] = false; }
                    catch { }
                    arePuzzlesConnected[x, y][2] = false;
                    try { arePuzzlesConnected[x, y + 1][0] = false; }
                    catch { }
                }
            }
            catch { }
            try
            {
                if (resultPictureBoxes[x, y].Top - resultPictureBoxes[x, y - 1].Top - resultPictureBoxes[x, y - 1].Height < 10 && resultPictureBoxes[x, y].Top - resultPictureBoxes[x, y - 1].Top - resultPictureBoxes[x, y - 1].Height > -10 && resultPictureBoxes[x, y].Left - resultPictureBoxes[x, y - 1].Left < 10 && resultPictureBoxes[x, y].Left - resultPictureBoxes[x, y - 1].Left > -10)
                {
                    try { sp.Dispose(); }
                    catch { }
                    sp = new SoundPlayer(Properties.Resources.PuzzleConnect);
                    sp.Play();
                    resultPictureBoxes[x, y].Top = resultPictureBoxes[x, y - 1].Top + resultPictureBoxes[x, y - 1].Height;
                    resultPictureBoxes[x, y].Left = resultPictureBoxes[x, y - 1].Left;
                    arePuzzlesConnected[x, y][0] = true;
                    arePuzzlesConnected[x, y - 1][2] = true;
                    arePuzzlesConnected[x, y][1] = false;
                    try { arePuzzlesConnected[x + 1, y][3] = false; }
                    catch { }
                    arePuzzlesConnected[x, y][2] = false;
                    try { arePuzzlesConnected[x, y + 1][0] = false; }
                    catch { }
                }
            }
            catch { }
            try
            {
                if (resultPictureBoxes[x + 1, y].Left - resultPictureBoxes[x, y].Left - resultPictureBoxes[x, y].Width < 10 && resultPictureBoxes[x + 1, y].Left - resultPictureBoxes[x, y].Left - resultPictureBoxes[x, y].Width > -10 && resultPictureBoxes[x, y].Top - resultPictureBoxes[x + 1, y].Top < 10 && resultPictureBoxes[x, y].Top - resultPictureBoxes[x + 1, y].Top > -10)
                {
                    try { sp.Dispose(); }
                    catch { }
                    sp = new SoundPlayer(Properties.Resources.PuzzleConnect);
                    sp.Play();
                    resultPictureBoxes[x, y].Left = resultPictureBoxes[x + 1, y].Left - resultPictureBoxes[x, y].Width;
                    resultPictureBoxes[x, y].Top = resultPictureBoxes[x + 1, y].Top;
                    arePuzzlesConnected[x, y][1] = true;
                    arePuzzlesConnected[x + 1, y][3] = true;
                    arePuzzlesConnected[x, y][2] = false;
                    try { arePuzzlesConnected[x, y + 1][0] = false; }
                    catch { }
                }
            }
            catch { }
            try
            {
                if (resultPictureBoxes[x, y + 1].Top - resultPictureBoxes[x, y].Top - resultPictureBoxes[x, y].Height < 10 && resultPictureBoxes[x, y + 1].Top - resultPictureBoxes[x, y].Top - resultPictureBoxes[x, y].Height > -10 && resultPictureBoxes[x, y].Left - resultPictureBoxes[x, y + 1].Left < 10 && resultPictureBoxes[x, y].Left - resultPictureBoxes[x, y + 1].Left > -10)
                {
                    try { sp.Dispose(); }
                    catch { }
                    sp = new SoundPlayer(Properties.Resources.PuzzleConnect);
                    sp.Play();
                    resultPictureBoxes[x, y].Top = resultPictureBoxes[x, y + 1].Top - resultPictureBoxes[x, y].Height;
                    resultPictureBoxes[x, y].Left = resultPictureBoxes[x, y + 1].Left;
                    arePuzzlesConnected[x, y][2] = true;
                    arePuzzlesConnected[x, y + 1][0] = true;
                }
            }
            catch { }
            for (int i = 0; i < arePuzzlesConnected.GetLength(0); i++)
            {
                for (int j = 0; j < arePuzzlesConnected.Length / arePuzzlesConnected.GetLength(0); j++)
                {
                    if (i == 0)
                        arePuzzlesConnected[i, j][3] = true;
                    if (i == arePuzzlesConnected.GetLength(0) - 1)
                        arePuzzlesConnected[i, j][1] = true;
                    if (j == 0)
                        arePuzzlesConnected[i, j][0] = true;
                    if (j == arePuzzlesConnected.Length / arePuzzlesConnected.GetLength(0) - 1)
                        arePuzzlesConnected[i, j][2] = true;
                }
            }
        }

        #region ElementsForMovementOfPictureBox
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point pt);
        delegate void MovementOfPictureBoxDelegate(ref PictureBox MovedPicture);
        event MovementOfPictureBoxDelegate MovementOfPictureBoxEvent;
        Point StartingCursorPosition;
        void MovePicture(ref PictureBox MovedPicture)
        {
            Point CurrentPosition = new Point();
            GetCursorPos(out CurrentPosition);
            MovedPicture.Left += CurrentPosition.X - StartingCursorPosition.X;
            MovedPicture.Top += CurrentPosition.Y - StartingCursorPosition.Y;
            StartingCursorPosition.X = CurrentPosition.X;
            StartingCursorPosition.Y = CurrentPosition.Y;
        }
        #endregion

        #region Events of MainForm

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            if (startPicture != null)
            {
                try
                {
                    puzzlePicturePreview.Close();
                }
                finally
                {
                    puzzlePicturePreview = new PuzzlePicturePreview();
                    puzzlePicturePreview.BackColor = MainFormColorDialog.Color;
                    puzzlePicturePreview.Width = puzzlePicturePreviewWidth;
                    puzzlePicturePreview.Height = puzzlePicturePreviewHeight;
                    puzzlePicturePreview.Left = puzzlePicturePreviewLeft;
                    puzzlePicturePreview.Top = puzzlePicturePreviewTop;
                    puzzlePicturePreview.PreviewPictureBox.Image = startPicture;
                    puzzlePicturePreview.IsOnTopCheckBox.Checked = isPreviewPictureOnTop;
                    puzzlePicturePreview.Show();
                }
            }
            else
            {
                MessageBox.Show("The game is not started yet! Please start the game and try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PreviewOnTopButton_Click(object sender, EventArgs e)
        {
            puzzlePicturePreview.IsOnTopCheckBox.Checked = true;
            isPreviewPictureOnTop = true;
        }

        private void PreviewNotOnTopButton_Click(object sender, EventArgs e)
        {
            puzzlePicturePreview.IsOnTopCheckBox.Checked = false;
            isPreviewPictureOnTop = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MovementOfPictureBoxEvent += new MovementOfPictureBoxDelegate(MovePicture);
            MainMenu.BackColor = MainFormColorDialog.Color;
            gameTime = new DateTime(2011, 05, 24, 00, 00, 00);
            for (int i = 0; i < new ScoreForm().RecordsDataGrid.Columns.Count; i++)
            {
                scoreTable.Columns.Add();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestartGameButton_Click(object sender, EventArgs e)
        {
            ClearPuzzlesData();
            GameLastingTimer.Enabled = false;
            try
            {
                startPicture = new Bitmap(ImageOpenFileDialog.FileName);
            }
            catch
            {
            start:
                PathToPictureButton_Click(sender, e);
                if (ImageOpenFileDialog.FileName == "")
                    return;
                else
                {
                    try
                    {
                        startPicture = new Bitmap(ImageOpenFileDialog.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Error! Unrecognized picture format.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ImageOpenFileDialog.FileName = "";
                        goto start;
                    }
                }
            }
            try
            {
                if (Convert.ToInt32(NumberOfPuzzlesTextBox.Text) > 1000)
                {
                    throw new ApplicationException();
                }
            }
            catch
            {
                MessageBox.Show("Error! Number of pieces is incorrect. Please enter an integer from 1 to 1000.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            puzzlePicturePreview.PreviewPictureBox.Image = startPicture;
            int x = 0, y = 0;
            puzNmb = Convert.ToInt32(NumberOfPuzzlesTextBox.Text);
            GetXYPuzzles(puzNmb, out x, out y);
            Bitmap[,] resultBitmaps = CutPictureAsRectangle(startPicture, x, y);
            resultPictureBoxes = new PictureBox[x, y];
            arePuzzlesConnected = new bool[x, y][];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    resultPictureBoxes[i, j] = new PictureBox();
                    resultPictureBoxes[i, j].Image = resultBitmaps[i, j];
                    resultPictureBoxes[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    if (startPicture.Width >= startPicture.Height)
                    {
                        resultPictureBoxes[i, j].Width = (this.Width - 600) / x;
                        resultPictureBoxes[i, j].Height = Convert.ToInt32(Math.Truncate(Convert.ToDouble(resultPictureBoxes[i, j].Width) / Convert.ToDouble((Convert.ToDouble(resultBitmaps[i, j].Width) / Convert.ToDouble(resultBitmaps[i, j].Height)))));
                    }
                    else
                    {
                        resultPictureBoxes[i, j].Height = (this.Height - 100) / x;
                        resultPictureBoxes[i, j].Width = Convert.ToInt32(Math.Truncate(Convert.ToDouble(resultPictureBoxes[i, j].Height) / Convert.ToDouble((Convert.ToDouble(resultBitmaps[i, j].Height) / Convert.ToDouble(resultBitmaps[i, j].Width)))));
                    }
                    resultPictureBoxes[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    resultPictureBoxes[i, j].Left = 50 + r.Next(this.Width - 60);
                    resultPictureBoxes[i, j].Top = 50 + r.Next(this.Height - 60);
                    if (this.Width - resultPictureBoxes[i, j].Left <= resultPictureBoxes[i, j].Width)
                        resultPictureBoxes[i, j].Left = this.Width - resultPictureBoxes[i, j].Width;
                    if (this.Height - resultPictureBoxes[i, j].Top < resultPictureBoxes[i, j].Height)
                        resultPictureBoxes[i, j].Top = this.Height - resultPictureBoxes[i, j].Height;
                    resultPictureBoxes[i, j].MouseDown += new MouseEventHandler(Puzzle_MouseDown);
                    resultPictureBoxes[i, j].MouseUp += new MouseEventHandler(Puzzle_MouseUp);
                    resultPictureBoxes[i, j].MouseMove += new MouseEventHandler(Puzzle_MouseMove);
                    this.Controls.Add(resultPictureBoxes[i, j]);
                    arePuzzlesConnected[i, j] = new bool[4]; // 4 стороны приклеивания к пазлу (по часовой, 0 - верх)
                    if (i == 0)
                        arePuzzlesConnected[i, j][3] = true;
                    if (i == x - 1)
                        arePuzzlesConnected[i, j][1] = true;
                    if (j == 0)
                        arePuzzlesConnected[i, j][0] = true;
                    if (j == y - 1)
                        arePuzzlesConnected[i, j][2] = true;
                }
            }
            gameTime = new DateTime(2011, 5, 24, 0, 0, 0);
            TimeLabel.Text = "Time: 0:00:00";
            GameLastingTimer.Enabled = true;
            MainMenu.BringToFront();
        }

        private void Puzzle_MouseDown(object sender, MouseEventArgs e)
        {
            try { sp.Dispose(); }
            catch { }
            sp = new SoundPlayer(Properties.Resources.PuzzleDown);
            sp.Play();
            clickedPuzzle = (PictureBox)sender;
            clickedPuzzle.BringToFront();
            MainMenu.BringToFront();
            GetCursorPos(out StartingCursorPosition);
        }

        private void Puzzle_MouseUp(object sender, MouseEventArgs e)
        {
            try { sp.Dispose(); }
            catch { }
            sp = new SoundPlayer(Properties.Resources.PuzzleUp);
            sp.Play();
            PictureBox pastedPicture = new PictureBox();
            IsPuzzlesConnected();
            clickedPuzzle = null;
            for (int i = 0; i < arePuzzlesConnected.GetLength(0); i++)
            {
                for (int j = 0; j < arePuzzlesConnected.Length / arePuzzlesConnected.GetLength(0); j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (arePuzzlesConnected[i, j][k] == false)
                            return;
                    }
                }
            }
            int time = 1;
            if (gameTime.Second != 0)
                time *= gameTime.Second;
            if (gameTime.Minute != 0)
                time *= gameTime.Minute;
            if (gameTime.Hour != 0)
                time *= gameTime.Hour;
            scoreTable.Rows.Add(0, Convert.ToInt32(puzNmb) * 20000 / time, gameTime.ToLongTimeString(), puzNmb, DateTime.Now.ToString());
            if (GameLastingTimer.Enabled)
            {
                for (int i = 0; i < scoreTable.Rows.Count; i++)
                {
                    if (Convert.ToInt32(scoreTable.Rows[i][1]) < Convert.ToInt32(scoreTable.Rows[scoreTable.Rows.Count - 1][1]))
                    {
                        object[] tempCells = scoreTable.Rows[scoreTable.Rows.Count - 1].ItemArray;
                        for (int j = scoreTable.Rows.Count - 2; j >= i; j--)
                        {
                            scoreTable.Rows[j + 1].ItemArray = scoreTable.Rows[j].ItemArray;
                        }
                        scoreTable.Rows[i].ItemArray = tempCells;
                    }
                    scoreTable.Rows[i][0] = i + 1;
                    for (int j = 0; j < scoreTable.Rows.Count.ToString().Length - scoreTable.Rows[i][0].ToString().Length; j++)
                    {
                        scoreTable.Rows[i][0] = "0" + scoreTable.Rows[i][0];
                    }
                }
                try
                {
                    scoreTableFileStream.Close();
                    scoreTableFileStream = null;
                    scoreTableFileStream = new FileStream(RecordsOpenFileDialog.FileName, FileMode.Create);
                    scoreTableBinaryFormatter.Serialize(scoreTableFileStream, scoreTable);
                }
                catch { }
            }
            GameLastingTimer.Enabled = false;
            if (MessageBox.Show("Congratulations, you have won!!! Would you like to start a new game?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                RestartGameButton_Click(sender, e);
                return;
            }
            ClearPuzzlesData();
        }

        private void Puzzle_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickedPuzzle != null)
            {
                MovementOfPictureBoxEvent(ref clickedPuzzle);
                clickedPuzzle.Update();
            }
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            try
            {
                puzzlePicturePreview.TopMost = false;
            }
            catch { }
            AboutForm aboutForm = new AboutForm();
            aboutForm.BackColor = MainFormColorDialog.Color;
            aboutForm.AboutTextBox.BackColor = MainFormColorDialog.Color;
            aboutForm.ShowDialog();
            if (isPreviewPictureOnTop)
            {
                try
                {
                    puzzlePicturePreview.TopMost = true;
                }
                catch
                { }
            }
        }

        private void GameLastingTimer_Tick(object sender, EventArgs e)
        {
            gameTime = gameTime.AddSeconds(1);
            TimeLabel.Text = "Time: " + gameTime.ToLongTimeString();
        }

        private void FormColorButton_Click(object sender, EventArgs e)
        {
            try
            {
                puzzlePicturePreview.TopMost = false;
            }
            catch { }
            MainFormColorDialog.ShowDialog();
            this.BackColor = MainFormColorDialog.Color;
            MainMenu.BackColor = MainFormColorDialog.Color;
            try
            {
                puzzlePicturePreview.BackColor = MainFormColorDialog.Color;
            }
            catch { }
            if (isPreviewPictureOnTop)
            {
                try
                {
                    puzzlePicturePreview.TopMost = true;
                }
                catch
                { }
            }
        }

        private void ShowRecords_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm();
            scoreForm.RecordsDataGrid.Rows.Clear();
            for (int i = 0; i < scoreTable.Rows.Count; i++)
            {
                object[] rowValues = new object[scoreTable.Columns.Count];
                for (int j = 0; j < scoreTable.Columns.Count; j++)
                {
                    rowValues[j] = scoreTable.Rows[i][j];
                }
                scoreForm.RecordsDataGrid.Rows.Add(rowValues);
            }
            scoreForm.RecordsDataGrid.Sort(scoreForm.RecordsDataGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            scoreForm.RecordsDataGrid.BackgroundColor = MainFormColorDialog.Color;
            try
            {
                puzzlePicturePreview.TopMost = false;
            }
            catch { }
            scoreForm.ShowDialog();
            if (isPreviewPictureOnTop)
            {
                try
                {
                    puzzlePicturePreview.TopMost = true;
                }
                catch
                { }
            }
        }

        private void SaveRecordsAsButton_Click(object sender, EventArgs e)
        {
            try
            {
                puzzlePicturePreview.TopMost = false;
            }
            catch { }
            RecordsSaveFileDialog.ShowDialog();
            if (isPreviewPictureOnTop)
            {
                try
                {
                    puzzlePicturePreview.TopMost = true;
                }
                catch
                { }
            }
        }

        private void RecordsSaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                scoreTableFileStream.Close();
            }
            catch { }
            scoreTableFileStream = new FileStream(RecordsSaveFileDialog.FileName, FileMode.Create);
            scoreTableBinaryFormatter.Serialize(scoreTableFileStream, scoreTable);
        }

        private void RecordsOpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                scoreTableFileStream.Close();
                scoreTableFileStream = null;
            }
            catch { }
            try
            {
                scoreTableFileStream = new FileStream(RecordsOpenFileDialog.FileName, FileMode.Open);
                scoreTable = (DataTable)scoreTableBinaryFormatter.Deserialize(scoreTableFileStream);
                RecordsSaveFileDialog.FileName = RecordsOpenFileDialog.FileName;
            }
            catch
            {
                MessageBox.Show("Error! File format is invalid.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadRecordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                puzzlePicturePreview.TopMost = false;
            }
            catch { }
            RecordsOpenFileDialog.ShowDialog();
            if (isPreviewPictureOnTop)
            {
                try
                {
                    puzzlePicturePreview.TopMost = true;
                }
                catch
                { }
            }
        }

        private void PathToPictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                puzzlePicturePreview.TopMost = false;
            }
            catch { }
            ImageOpenFileDialog.ShowDialog();
            if (isPreviewPictureOnTop)
            {
                try
                {
                    puzzlePicturePreview.TopMost = true;
                }
                catch
                { }
            }
        }

        private void SaveGameAsButton_Click(object sender, EventArgs e)
        {
            GameSaveFileDialog.ShowDialog();
        }

        private void GameSaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SerializatedGame serializatedGame = new SerializatedGame();
            try
            {
                serializatedGame.location = new Point[resultPictureBoxes.GetLength(0), resultPictureBoxes.Length / resultPictureBoxes.GetLength(0)];
                for (int i = 0; i < resultPictureBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < resultPictureBoxes.Length / resultPictureBoxes.GetLength(0); j++)
                    {
                        serializatedGame.location[i, j] = resultPictureBoxes[i, j].Location;
                    }
                }
                serializatedGame.arePuzzlesConnected = arePuzzlesConnected;
            }
            catch
            { }
            try
            {
                serializatedGame.gameTime = gameTime;
            }
            catch
            { }
            serializatedGame.isPreviewOnTop = isPreviewPictureOnTop;
            serializatedGame.pathToPicture = ImageOpenFileDialog.FileName;
            serializatedGame.numberOfPuzzles = puzNmb.ToString();
            serializatedGame.theme = MainFormColorDialog.Color;
            FileStream gameFileStream = new FileStream(GameSaveFileDialog.FileName, FileMode.Create);
            scoreTableBinaryFormatter.Serialize(gameFileStream, serializatedGame);
            gameFileStream.Close();
        }

        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            if (GameSaveFileDialog.FileName != "")
                GameSaveFileDialog_FileOk(sender, new System.ComponentModel.CancelEventArgs());
            else
                SaveGameAsButton_Click(sender, e);
        }

        private void OpenGameButton_Click(object sender, EventArgs e)
        {
            GameOpenFileDialog.ShowDialog();
        }

        private void GameOpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SerializatedGame serializatedGame = new SerializatedGame();
            try
            {
                FileStream gameFileStream = new FileStream(GameOpenFileDialog.FileName, FileMode.Open);
                try
                {
                    serializatedGame = (SerializatedGame)scoreTableBinaryFormatter.Deserialize(gameFileStream);
                    gameFileStream.Close();
                }
                catch
                {
                    gameFileStream.Close();
                    throw new ApplicationException();
                }
            }
            catch
            {
                MessageBox.Show("Error! The file cannot be accessed! Make sure the file being opened is a saved game file and it is not used by another process. Then try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GameSaveFileDialog.FileName = GameOpenFileDialog.FileName;
            ImageOpenFileDialog.FileName = serializatedGame.pathToPicture;
            puzNmb = Convert.ToInt32(serializatedGame.numberOfPuzzles);
            NumberOfPuzzlesTextBox.Text = serializatedGame.numberOfPuzzles;
            isPreviewPictureOnTop = serializatedGame.isPreviewOnTop;
            try
            {
                puzzlePicturePreview.IsOnTopCheckBox.Checked = isPreviewPictureOnTop;
            }
            catch { }
            MainFormColorDialog.Color = serializatedGame.theme;
            this.BackColor = MainFormColorDialog.Color;
            MainMenu.BackColor = MainFormColorDialog.Color;
            try
            {
                puzzlePicturePreview.BackColor = MainFormColorDialog.Color;
            }
            catch { }
            RestartGameButton_Click(sender, EventArgs.Empty);
            if (serializatedGame.arePuzzlesConnected == null)
            {
                ClearPuzzlesData();
            }
            GameLastingTimer.Enabled = false;
            try
            {
                gameTime = serializatedGame.gameTime;
                TimeLabel.Text = "Время: " + gameTime.ToLongTimeString();
                if (serializatedGame.arePuzzlesConnected != null)
                    GameLastingTimer.Enabled = true;
            }
            catch
            {
                TimeLabel.Text = "Время: 0:00:00";
            }
            try
            {
                arePuzzlesConnected = serializatedGame.arePuzzlesConnected;
                for (int i = 0; i < resultPictureBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < resultPictureBoxes.Length / resultPictureBoxes.GetLength(0); j++)
                    {
                        resultPictureBoxes[i, j].Location = serializatedGame.location[i, j];
                    }
                }
            }
            catch
            { }
        }

        #endregion

        #region Methods for cutting of pictures

        void GetXYPuzzles(int numberOfPuzzles, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = Convert.ToInt32(Math.Truncate(Math.Sqrt(numberOfPuzzles))); i > 0; i--)
            {
                if (numberOfPuzzles % i == 0)
                {
                    x = numberOfPuzzles / i;
                }
                else
                {
                    continue;
                }
                break;
            }
            y = numberOfPuzzles / x;
        }

        Bitmap[,] CutPictureAsRectangle(Bitmap startPicture, int x, int y)
        {
            Bitmap[,] result = new Bitmap[x, y];
            int xResulution = Convert.ToInt32(Math.Truncate(Convert.ToDouble(startPicture.Width / (x))));
            int yResulution = Convert.ToInt32(Math.Truncate(Convert.ToDouble(startPicture.Height / (y))));
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    result[i, j] = startPicture.Clone(new Rectangle(xResulution * i, yResulution * j, xResulution, yResulution), startPicture.PixelFormat);
                }
            }
            return result;
        }
        #endregion
    }
}
