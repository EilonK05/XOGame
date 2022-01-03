using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XOGame
{
    public partial class WinForm : Form
    {
        public WinForm(string text, Image image)
        {
            InitializeComponent();

            winLabel.Text = text;
            winPictureBox.Image = image;
        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
