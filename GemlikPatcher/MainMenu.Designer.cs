namespace Gemlik_Patcher
{
    partial class GemlikPatcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GemlikPatcher));
            this.Mods = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mods
            // 
            this.Mods.Font = new System.Drawing.Font("RGFuture", 20F);
            this.Mods.Location = new System.Drawing.Point(260, 139);
            this.Mods.Name = "Mods";
            this.Mods.Size = new System.Drawing.Size(100, 72);
            this.Mods.TabIndex = 0;
            this.Mods.Text = "Mods";
            this.Mods.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.Settings.Font = new System.Drawing.Font("RGFuture", 12F);
            this.Settings.Location = new System.Drawing.Point(249, 56);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(100, 30);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("RGFuture", 20F);
            this.Quit.Location = new System.Drawing.Point(249, 237);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(100, 39);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // GemlikPatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Gemlik_Patcher.Properties.Resources.Ratchet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Mods);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GemlikPatcher";
            this.Text = "Gemlik Patcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mods;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Quit;
    }
}

