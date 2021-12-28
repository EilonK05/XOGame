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

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;
            if (m_isX)
            {
                button.Image = m_X;
            }
            else
            {
                button.Image = m_O;
            }
            button.Enabled = false;
            m_isX = !m_isX;
        }
    }
}
