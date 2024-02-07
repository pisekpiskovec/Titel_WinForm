using Titel_WinForm.Properties;

namespace Titel_WinForm
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lAbout = new System.Windows.Forms.Label();
            this.gbShortcuts = new System.Windows.Forms.GroupBox();
            this.lbShortcuts = new System.Windows.Forms.ListBox();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.gbShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAbout
            // 
            resources.ApplyResources(this.gbAbout, "gbAbout");
            this.gbAbout.Controls.Add(this.pbIcon);
            this.gbAbout.Controls.Add(this.lAbout);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.TabStop = false;
            // 
            // pbIcon
            // 
            resources.ApplyResources(this.pbIcon, "pbIcon");
            this.pbIcon.Image = global::Titel_WinForm.Properties.Resources.titel_icon_64;
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.pbIcon_Click);
            // 
            // lAbout
            // 
            resources.ApplyResources(this.lAbout, "lAbout");
            this.lAbout.Name = "lAbout";
            // 
            // gbShortcuts
            // 
            resources.ApplyResources(this.gbShortcuts, "gbShortcuts");
            this.gbShortcuts.Controls.Add(this.lbShortcuts);
            this.gbShortcuts.Name = "gbShortcuts";
            this.gbShortcuts.TabStop = false;
            // 
            // lbShortcuts
            // 
            resources.ApplyResources(this.lbShortcuts, "lbShortcuts");
            this.lbShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShortcuts.FormattingEnabled = true;
            this.lbShortcuts.Items.AddRange(new object[] {
            resources.GetString("lbShortcuts.Items"),
            resources.GetString("lbShortcuts.Items1"),
            resources.GetString("lbShortcuts.Items2"),
            resources.GetString("lbShortcuts.Items3"),
            resources.GetString("lbShortcuts.Items4"),
            resources.GetString("lbShortcuts.Items5"),
            resources.GetString("lbShortcuts.Items6"),
            resources.GetString("lbShortcuts.Items7"),
            resources.GetString("lbShortcuts.Items8")});
            this.lbShortcuts.Name = "lbShortcuts";
            this.lbShortcuts.TabStop = false;
            this.lbShortcuts.UseTabStops = false;
            // 
            // About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbShortcuts);
            this.Controls.Add(this.gbAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.About_Load);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.gbShortcuts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lAbout;
        private System.Windows.Forms.GroupBox gbShortcuts;
        private System.Windows.Forms.ListBox lbShortcuts;
    }
}