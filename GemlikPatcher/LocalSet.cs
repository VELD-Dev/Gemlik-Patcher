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
using System.Timers;
using System.Diagnostics;
namespace Gemlik_Patcher
{
    public partial class LocalSet : Form
    {
        public int gameID;
        public Image[] boxArts = { null, Properties.Resources._220px_RaCbox, Properties.Resources.Ratchet_and_clank_gc_image, Properties.Resources.Ratchetandclank3box, Properties.Resources.Deadlocked};
        string[] s;
        public LocalSet()
        {
            InitializeComponent();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK&& !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void LocalSet_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = boxArts[gameID];
            label1.Text = "This folder should contain the folders: Common and rc" + gameID + ".";
            if (File.Exists(Application.StartupPath + "/Data.wkj"))
            {
                if (File.ReadAllLines(Application.StartupPath + "/Data.wkj")[gameID] != "" && File.ReadAllLines(Application.StartupPath + "/Data.wkj")[gameID] != null)
                {
                    textBox1.Text = File.ReadAllLines(Application.StartupPath + "/Data.wkj")[gameID];
                }
            }
        }

        private void process_Click(object sender, EventArgs e)
        {
            string directory = textBox1.Text;
            s = File.ReadAllLines(Application.StartupPath + "/Data.wkj");
            s[gameID] = directory;
            Proces(directory);
        }
        public void Proces(string dir)
        {
            File.WriteAllLines(Application.StartupPath + "/Data.wkj", s);
            if (!File.Exists(dir + "/ORGarc.psarc"))
            {
                File.Move(dir + "/rc" + gameID + "/ps3data/PS3arc.psarc", dir + "/ORGarc.psarc");
            }
            File.WriteAllBytes(dir + "/rc" + gameID + "/ps3data/PS3arc.psarc", Properties.Resources.PS3arc);
            ProcessStartInfo INFO = new ProcessStartInfo(Application.StartupPath + "/PSArcTool.exe", dir + "/ORGarc.psarc");
            INFO.CreateNoWindow = true;
            Process.Start(INFO);
            
        }
    }
}
