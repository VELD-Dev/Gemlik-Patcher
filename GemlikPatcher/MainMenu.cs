using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            if (!File.Exists(Application.StartupPath + "/Data.wkj"))
            {
                StreamWriter st = new StreamWriter(Application.StartupPath + "/Data.wkj");
                for (int i = 0; i < 128; i++)
                {
                    st.WriteLine("");
                }
                st.Close();
            }
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsMenu settings = new SettingsMenu();
            settings.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "I'm not mad, just disappointed.", "Do you really want to quit? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("BUT " + Environment.UserName + ", I AM YOUR FATHER...'S ACCOUNTANT! \n \n also why didn't you use the quit button, at least make my death quick");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("You just gained additional fun person points!");
            }
        }

        private void Mods_Click_1(object sender, EventArgs e)
        {
            ModsMenu settings = new ModsMenu();
            settings.Show();
        }
    }
}
