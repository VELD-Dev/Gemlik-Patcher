﻿using System;
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
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocalSet settings = new LocalSet();
            settings.gameID = 1;
            settings.Text = "Settings - Ratchet and Clank - Gemlik Patcher";
            settings.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LocalSet settings = new LocalSet();
            settings.gameID = 2;
            settings.Text = "Settings - Ratchet and Clank Going Commando - Gemlik Patcher";
            settings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LocalSet settings = new LocalSet();
            settings.gameID = 3;
            settings.Text = "Settings - Ratchet and Clank Up Your Arsenal - Gemlik Patcher";
            settings.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LocalSet settings = new LocalSet();
            settings.gameID = 4;
            settings.Text = "Settings - Ratchet Deadlocked - Gemlik Patcher";
            settings.Show();
        }
    }
}
