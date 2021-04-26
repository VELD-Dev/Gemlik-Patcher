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
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;
namespace Gemlik_Patcher
{
    public partial class LocalMods : Form
    {
        public Image[] arts = { null, Properties.Resources.Gemlik_Base_1, Properties.Resources.Silver_City_3, Properties.Resources.BFG, Properties.Resources.Ghost_Station };
        public int gameID;
        public List<Mod> modList = new List<Mod>();
        public List<string> modNames = new List<string>();
        public List<string> modPaths = new List<string>();
        public List<string> active = new List<string>();
        public LocalMods()
        {
            InitializeComponent();
        }

        private void LocalMods_Load_1(object sender, EventArgs e)
        {
            BackgroundImage = arts[gameID];
            Reload();
            LoadData(Application.StartupPath + "/rc" + gameID + "Mods/mods.xml");
        }
        void Reload()
        {
            string[] mods = Directory.GetDirectories(Application.StartupPath + "/rc" + gameID + "Mods");
            if (ModsList.Items != null)
            {
                modNames.Clear();
                modPaths.Clear();
                ModsList.Items.Clear();
            }
            foreach (string mod in mods)
            {
                if (File.Exists(mod + "/info.txt"))
                {
                    DirectoryInfo dir = new DirectoryInfo(mod);
                    StreamReader d = new StreamReader(mod + "/info.txt");
                    string a = d.ReadLine();
                    ModsList.Items.Add(a);
                    modNames.Add(a);
                    modPaths.Add(mod);
                }
            }
        }
        public void SaveData(string path, List<Mod> mod)
        {
            //File.WriteAllText(path, string.Empty);
            XmlSerializer x = new XmlSerializer(mod.GetType());
            StreamWriter st = new StreamWriter(path);
            x.Serialize(st, mod);
            st.WriteLine();
            st.Close();
        }
        public void LoadData(string path)
        {
            if (File.Exists(path))
            {
                XmlSerializer x = new XmlSerializer(modList.GetType());
                StreamReader st = new StreamReader(path);
                modList = (List<Mod>)x.Deserialize(st);
                foreach (Mod man in modList)
                {
                    active.Add(man.name);
                }
                for (int i = 0; i < ModsList.Items.Count; i++)
                {
                    if (active.Contains(ModsList.Items[i]))
                    {
                        ModsList.SetItemChecked(i, true);
                    }
                }
                st.Close();
            }
        }
        private void ModsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            modList.Clear();
            for (int i = 0; i < modNames.Count; i++)
            {
                if (ModsList.GetItemChecked(i))
                {
                    string a = modNames[i];
                    modList.Add(new Mod(a, modPaths[i]));
                }
            }
            SaveData(Application.StartupPath + "/rc" + gameID + "Mods/mods.xml", modList);
        }

        private void Reld_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            string s = (File.ReadAllLines(Application.StartupPath+"/Data.wkj")[gameID] + "/ORGarc.psarc");
            ProcessStartInfo INFO = new ProcessStartInfo(Application.StartupPath + "/PSArcTool.exe", s);
            INFO.CreateNoWindow = true;
            Process.Start(INFO);
        }

        private void Install_Click(object sender, EventArgs e)
        {
            modList.Clear();
            for (int i = 0; i < modNames.Count; i++)
            {
                if (ModsList.GetItemChecked(i))
                {
                    string a = modNames[i];
                    modList.Add(new Mod(a, modPaths[i]));
                }
            }
            SaveData(Application.StartupPath + "/rc" + gameID + "Mods/mods.xml", modList);
            foreach(Mod mini in modList)
            {
                string[] aw = Directory.GetDirectories(mini.path);
                if(Directory.Exists(mini.path+"/rc" + gameID)){
                    Copy(mini.path + "/rc" + gameID, (File.ReadAllLines(Application.StartupPath + "/Data.wkj")[gameID] + "/rc" + gameID));
                }
                if (Directory.Exists(mini.path + "/Common")){
                    Copy(mini.path + "/Common", (File.ReadAllLines(Application.StartupPath + "/Data.wkj")[gameID] + "/Common"));
                }
            }
        }
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
