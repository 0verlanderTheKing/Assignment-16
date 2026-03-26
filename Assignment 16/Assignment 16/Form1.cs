using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = true;

        }

        private void lightStateLabel_Click(object sender, EventArgs e)
        {

        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            if (lightOffPictureBox.Visible == true)
            {
                lightOffPictureBox.Visible = false;
                lightOnPictureBox.Visible = true;
                lightStateLabel.Text = "ON";
            }
            else if (lightOnPictureBox.Visible == true)
            {
                lightOffPictureBox.Visible = true;
                lightOnPictureBox.Visible = false;
                lightStateLabel.Text = "OFF";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
