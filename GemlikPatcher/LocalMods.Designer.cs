namespace Gemlik_Patcher
{
    partial class LocalMods
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
            this.ModsList = new System.Windows.Forms.CheckedListBox();
            this.Install = new System.Windows.Forms.Button();
            this.Restore = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Reld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModsList
            // 
            this.ModsList.FormattingEnabled = true;
            this.ModsList.Location = new System.Drawing.Point(12, 12);
            this.ModsList.Name = "ModsList";
            this.ModsList.Size = new System.Drawing.Size(560, 394);
            this.ModsList.TabIndex = 1;
            this.ModsList.SelectedIndexChanged += new System.EventHandler(this.ModsList_SelectedIndexChanged);
            // 
            // Install
            // 
            this.Install.Font = new System.Drawing.Font("RGFuture", 20F, System.Drawing.FontStyle.Italic);
            this.Install.Location = new System.Drawing.Point(12, 505);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(560, 44);
            this.Install.TabIndex = 2;
            this.Install.Text = "Install";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // Restore
            // 
            this.Restore.Font = new System.Drawing.Font("RGFuture", 20F, System.Drawing.FontStyle.Italic);
            this.Restore.Location = new System.Drawing.Point(12, 424);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(560, 44);
            this.Restore.TabIndex = 3;
            this.Restore.Text = "Restore";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("RGFuture", 20F, System.Drawing.FontStyle.Italic);
            this.Save.Location = new System.Drawing.Point(12, 584);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(560, 44);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Reld
            // 
            this.Reld.Font = new System.Drawing.Font("RGFuture", 20F, System.Drawing.FontStyle.Italic);
            this.Reld.Location = new System.Drawing.Point(12, 705);
            this.Reld.Name = "Reld";
            this.Reld.Size = new System.Drawing.Size(560, 44);
            this.Reld.TabIndex = 5;
            this.Reld.Text = "Reload";
            this.Reld.UseVisualStyleBackColor = true;
            this.Reld.Click += new System.EventHandler(this.Reld_Click);
            // 
            // LocalMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gemlik_Patcher.Properties.Resources.Gemlik_Base_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.Reld);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Restore);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.ModsList);
            this.DoubleBuffered = true;
            this.Name = "LocalMods";
            this.Text = "Mods";
            this.Load += new System.EventHandler(this.LocalMods_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ModsList;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.Button Restore;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Reld;
    }
}