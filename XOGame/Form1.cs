using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XOGame.Properties;

namespace XOGame
{
    public partial class Form1 : Form
    {
        private Image m_X = Resources.X;
        private Image m_O = Resources.O;
        private bool m_isX = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string[,] FormToMatrix()
        {

            //המטריצה המוחזרת

            string[,] m = new string[3, 3];
            int row, col;
            PictureBox curPicture;

            //עוברים על כלל הפקדים בטופס - נעזרים בלולאת foreach

            foreach (Control ctrl in this.Controls)
                if (ctrl is PictureBox)
                {
                    curPicture = ctrl as PictureBox;

                    //מציאת מספר השורה והעמודה מתוך שם הפקד

                    row = (int.Parse(curPicture.Name[curPicture.Name.Length - 2].ToString()) - 1);
                    col = (int.Parse(curPicture.Name[curPicture.Name.Length - 1].ToString()) - 1);
                    m[row, col] = curPicture.Image == m_X ? "X" : "O";
                }
            return m;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;
            if (m_isX)
            {
                button.Image = m_X;
                
                if (CheckWin())
                {
                    WinForm winForm = new WinForm("שחקן איקס ניצח! כל הכבוד!", Resources.XWin);
                    winForm.ShowDialog();
                }
            }
            else
            {
                button.Image = m_O;

                if (CheckWin())
                {
                    WinForm winForm = new WinForm("שחקן עיגול ניצח! כל הכבוד!", Resources.OWin);
                    winForm.ShowDialog();
                }
            }
            button.Enabled = false;
            m_isX = !m_isX;
        }

        private bool CheckWin()
        {
            string[,] board = FormToMatrix();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "") return true; // TODO: Fix win check
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "") return true; // TODO: Fix win check
            }
            if(board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "") return true; // TODO: Fix win check
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != "") return true; // TODO: Fix win check
            return false;
        }
    }
}
