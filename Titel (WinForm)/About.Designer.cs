﻿using Titel_WinForm.Properties;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lAbout = new System.Windows.Forms.Label();
            this.gbShortcuts = new System.Windows.Forms.GroupBox();
            this.lbShortcuts = new System.Windows.Forms.ListBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.rbTemplRevA = new System.Windows.Forms.RadioButton();
            this.rbTempl = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.gbShortcuts.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.pbIcon);
            this.gbAbout.Controls.Add(this.lAbout);
            resources.ApplyResources(this.gbAbout, "gbAbout");
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::Titel_WinForm.Properties.Resources.titel_icon_64;
            resources.ApplyResources(this.pbIcon, "pbIcon");
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
            this.gbShortcuts.Controls.Add(this.lbShortcuts);
            resources.ApplyResources(this.gbShortcuts, "gbShortcuts");
            this.gbShortcuts.Name = "gbShortcuts";
            this.gbShortcuts.TabStop = false;
            // 
            // lbShortcuts
            // 
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
            resources.ApplyResources(this.lbShortcuts, "lbShortcuts");
            this.lbShortcuts.Name = "lbShortcuts";
            this.lbShortcuts.TabStop = false;
            this.lbShortcuts.UseTabStops = false;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.rbTemplRevA);
            this.gbSettings.Controls.Add(this.rbTempl);
            resources.ApplyResources(this.gbSettings, "gbSettings");
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.TabStop = false;
            // 
            // rbTemplRevA
            // 
            resources.ApplyResources(this.rbTemplRevA, "rbTemplRevA");
            this.rbTemplRevA.Name = "rbTemplRevA";
            this.toolTip.SetToolTip(this.rbTemplRevA, resources.GetString("rbTemplRevA.ToolTip"));
            this.rbTemplRevA.UseVisualStyleBackColor = true;
            this.rbTemplRevA.CheckedChanged += new System.EventHandler(this.rbTemplRevA_CheckedChanged);
            // 
            // rbTempl
            // 
            resources.ApplyResources(this.rbTempl, "rbTempl");
            this.rbTempl.Name = "rbTempl";
            this.toolTip.SetToolTip(this.rbTempl, resources.GetString("rbTempl.ToolTip"));
            this.rbTempl.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbShortcuts);
            this.Controls.Add(this.gbAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.About_FormClosing);
            this.Load += new System.EventHandler(this.About_Load);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.gbShortcuts.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lAbout;
        private System.Windows.Forms.GroupBox gbShortcuts;
        private System.Windows.Forms.ListBox lbShortcuts;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.RadioButton rbTemplRevA;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton rbTempl;
    }
}