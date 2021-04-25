using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gemlik_Patcher
{
    public partial class GemlikPatcher : Form
    {
        public GemlikPatcher()
        {
            InitializeComponent();
            MessageBox.Show("This is an early build, please report any bugs to me.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "I'm not mad, just disappointed.", "Do you really want to quit? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("BUT " + Environment.UserName + ", I AM YOUR FATHER...'S ACCOUNTANT! \n \n also why didn't you use the quit button, at least make my death ");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("You just gained additional fun person points!");
            }
        }
    }
}
