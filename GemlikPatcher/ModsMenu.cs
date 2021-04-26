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
    public partial class ModsMenu : Form
    {
        public ModsMenu()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (File.ReadAllLines(Application.StartupPath + "/Data.wkj")[1] != null && !string.IsNullOrWhiteSpace(File.ReadAllLines(Application.StartupPath + "/Data.wkj")[1]))
            {
                LocalMods settings = new LocalMods();
                settings.gameID = 1;
                settings.Text = "Mods - Ratchet and Clank - Gemlik Patcher";
                settings.Show();
            }
            else
            {
                MessageBox.Show("Game not setup!", "How could you?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (File.ReadAllLines(Application.StartupPath + "/Data.wkj")[2] != null && !string.IsNullOrWhiteSpace(File.ReadAllLines(Application.StartupPath + "/Data.wkj")[2])){
                LocalMods settings = new LocalMods();
                settings.gameID = 2;
                settings.Text = "Mods - Ratchet and Clank Going Commando - Gemlik Patcher";
                settings.Show();
            }
            else
            {
                MessageBox.Show("Game not setup!", "How could you?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (File.ReadAllLines(Application.StartupPath + "/Data.wkj")[3] != null && !string.IsNullOrWhiteSpace(File.ReadAllLines(Application.StartupPath + "/Data.wkj")[3]))
            {
                LocalMods settings = new LocalMods();
                settings.gameID = 3;
                settings.Text = "Mods - Ratchet and Clank Up Your Arsenal - Gemlik Patcher";
                settings.Show();
            }
            else
            {
                MessageBox.Show("Game not setup!", "How could you?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (File.ReadAllLines(Application.StartupPath + "/Data.wkj")[4] != null && !string.IsNullOrWhiteSpace(File.ReadAllLines(Application.StartupPath + "/Data.wkj")[4]))
            {
                LocalMods settings = new LocalMods();
                settings.gameID = 4;
                settings.Text = "Mods - Ratchet Deadlocked - Gemlik Patcher";
                settings.Show();
            }
            else
            {
                MessageBox.Show("Game not setup!", "How could you?", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ModsMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
