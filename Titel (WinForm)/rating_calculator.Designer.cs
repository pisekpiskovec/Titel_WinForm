namespace Titel_WinForm
{
    partial class rating_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rating_calculator));
            this.gbBlank = new System.Windows.Forms.GroupBox();
            this.bBlankPaste = new System.Windows.Forms.Button();
            this.lBlankResult = new System.Windows.Forms.Label();
            this.lBlankMaxStars = new System.Windows.Forms.Label();
            this.numBlankMaxStars = new System.Windows.Forms.NumericUpDown();
            this.numBlankStars = new System.Windows.Forms.NumericUpDown();
            this.lBlankStars = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSpotifyPaste = new System.Windows.Forms.Button();
            this.lSpotifyResult = new System.Windows.Forms.Label();
            this.lSpotifyMaxPlays = new System.Windows.Forms.Label();
            this.numSpotifyMaxPlays = new System.Windows.Forms.NumericUpDown();
            this.numSpotifyPlays = new System.Windows.Forms.NumericUpDown();
            this.lSpotifyPlays = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bYTPaste = new System.Windows.Forms.Button();
            this.lYTResult = new System.Windows.Forms.Label();
            this.lYTDislikes = new System.Windows.Forms.Label();
            this.numYTDislikes = new System.Windows.Forms.NumericUpDown();
            this.numYTLikes = new System.Windows.Forms.NumericUpDown();
            this.lYTLikes = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bSCPaste = new System.Windows.Forms.Button();
            this.lSCResult = new System.Windows.Forms.Label();
            this.lSCLikes = new System.Windows.Forms.Label();
            this.numSCLikes = new System.Windows.Forms.NumericUpDown();
            this.numSCPlays = new System.Windows.Forms.NumericUpDown();
            this.lSCPlays = new System.Windows.Forms.Label();
            this.tDontNull = new System.Windows.Forms.Timer(this.components);
            this.gbBlank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlankMaxStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlankStars)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpotifyMaxPlays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpotifyPlays)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYTDislikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTLikes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSCLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSCPlays)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBlank
            // 
            this.gbBlank.AutoSize = true;
            this.gbBlank.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbBlank.Controls.Add(this.bBlankPaste);
            this.gbBlank.Controls.Add(this.lBlankResult);
            this.gbBlank.Controls.Add(this.lBlankMaxStars);
            this.gbBlank.Controls.Add(this.numBlankMaxStars);
            this.gbBlank.Controls.Add(this.numBlankStars);
            this.gbBlank.Controls.Add(this.lBlankStars);
            this.gbBlank.Location = new System.Drawing.Point(12, 12);
            this.gbBlank.Name = "gbBlank";
            this.gbBlank.Size = new System.Drawing.Size(219, 113);
            this.gbBlank.TabIndex = 0;
            this.gbBlank.TabStop = false;
            this.gbBlank.Text = "Blank";
            // 
            // bBlankPaste
            // 
            this.bBlankPaste.Location = new System.Drawing.Point(138, 71);
            this.bBlankPaste.Name = "bBlankPaste";
            this.bBlankPaste.Size = new System.Drawing.Size(75, 23);
            this.bBlankPaste.TabIndex = 4;
            this.bBlankPaste.Text = "Paste";
            this.bBlankPaste.UseVisualStyleBackColor = true;
            this.bBlankPaste.Click += new System.EventHandler(this.bBlankPaste_Click);
            // 
            // lBlankResult
            // 
            this.lBlankResult.AutoSize = true;
            this.lBlankResult.Location = new System.Drawing.Point(6, 76);
            this.lBlankResult.Name = "lBlankResult";
            this.lBlankResult.Size = new System.Drawing.Size(49, 13);
            this.lBlankResult.TabIndex = 3;
            this.lBlankResult.Text = "Result: 0";
            // 
            // lBlankMaxStars
            // 
            this.lBlankMaxStars.AutoSize = true;
            this.lBlankMaxStars.Location = new System.Drawing.Point(6, 47);
            this.lBlankMaxStars.Name = "lBlankMaxStars";
            this.lBlankMaxStars.Size = new System.Drawing.Size(81, 13);
            this.lBlankMaxStars.TabIndex = 1;
            this.lBlankMaxStars.Text = "Maximum Stars:";
            // 
            // numBlankMaxStars
            // 
            this.numBlankMaxStars.Location = new System.Drawing.Point(93, 45);
            this.numBlankMaxStars.Name = "numBlankMaxStars";
            this.numBlankMaxStars.Size = new System.Drawing.Size(120, 20);
            this.numBlankMaxStars.TabIndex = 2;
            this.numBlankMaxStars.ValueChanged += new System.EventHandler(this.numBlank_ValueChanged);
            // 
            // numBlankStars
            // 
            this.numBlankStars.DecimalPlaces = 1;
            this.numBlankStars.Location = new System.Drawing.Point(46, 19);
            this.numBlankStars.Name = "numBlankStars";
            this.numBlankStars.Size = new System.Drawing.Size(167, 20);
            this.numBlankStars.TabIndex = 1;
            this.numBlankStars.ValueChanged += new System.EventHandler(this.numBlank_ValueChanged);
            // 
            // lBlankStars
            // 
            this.lBlankStars.AutoSize = true;
            this.lBlankStars.Location = new System.Drawing.Point(6, 21);
            this.lBlankStars.Name = "lBlankStars";
            this.lBlankStars.Size = new System.Drawing.Size(34, 13);
            this.lBlankStars.TabIndex = 0;
            this.lBlankStars.Text = "Stars:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.bSpotifyPaste);
            this.groupBox1.Controls.Add(this.lSpotifyResult);
            this.groupBox1.Controls.Add(this.lSpotifyMaxPlays);
            this.groupBox1.Controls.Add(this.numSpotifyMaxPlays);
            this.groupBox1.Controls.Add(this.numSpotifyPlays);
            this.groupBox1.Controls.Add(this.lSpotifyPlays);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spotify";
            // 
            // bSpotifyPaste
            // 
            this.bSpotifyPaste.Location = new System.Drawing.Point(138, 71);
            this.bSpotifyPaste.Name = "bSpotifyPaste";
            this.bSpotifyPaste.Size = new System.Drawing.Size(75, 23);
            this.bSpotifyPaste.TabIndex = 4;
            this.bSpotifyPaste.Text = "Paste";
            this.bSpotifyPaste.UseVisualStyleBackColor = true;
            this.bSpotifyPaste.Click += new System.EventHandler(this.bSpotifyPaste_Click);
            // 
            // lSpotifyResult
            // 
            this.lSpotifyResult.AutoSize = true;
            this.lSpotifyResult.Location = new System.Drawing.Point(6, 76);
            this.lSpotifyResult.Name = "lSpotifyResult";
            this.lSpotifyResult.Size = new System.Drawing.Size(49, 13);
            this.lSpotifyResult.TabIndex = 3;
            this.lSpotifyResult.Text = "Result: 0";
            // 
            // lSpotifyMaxPlays
            // 
            this.lSpotifyMaxPlays.AutoSize = true;
            this.lSpotifyMaxPlays.Location = new System.Drawing.Point(6, 47);
            this.lSpotifyMaxPlays.Name = "lSpotifyMaxPlays";
            this.lSpotifyMaxPlays.Size = new System.Drawing.Size(114, 13);
            this.lSpotifyMaxPlays.TabIndex = 1;
            this.lSpotifyMaxPlays.Text = "The most played song:";
            // 
            // numSpotifyMaxPlays
            // 
            this.numSpotifyMaxPlays.Location = new System.Drawing.Point(126, 45);
            this.numSpotifyMaxPlays.Maximum = new decimal(new int[] {
            -294967296,
            0,
            0,
            0});
            this.numSpotifyMaxPlays.Name = "numSpotifyMaxPlays";
            this.numSpotifyMaxPlays.Size = new System.Drawing.Size(87, 20);
            this.numSpotifyMaxPlays.TabIndex = 2;
            this.numSpotifyMaxPlays.ValueChanged += new System.EventHandler(this.numSpotify_ValueChanged);
            // 
            // numSpotifyPlays
            // 
            this.numSpotifyPlays.Location = new System.Drawing.Point(98, 19);
            this.numSpotifyPlays.Maximum = new decimal(new int[] {
            -294967296,
            0,
            0,
            0});
            this.numSpotifyPlays.Name = "numSpotifyPlays";
            this.numSpotifyPlays.Size = new System.Drawing.Size(115, 20);
            this.numSpotifyPlays.TabIndex = 1;
            this.numSpotifyPlays.ValueChanged += new System.EventHandler(this.numSpotify_ValueChanged);
            // 
            // lSpotifyPlays
            // 
            this.lSpotifyPlays.AutoSize = true;
            this.lSpotifyPlays.Location = new System.Drawing.Point(6, 21);
            this.lSpotifyPlays.Name = "lSpotifyPlays";
            this.lSpotifyPlays.Size = new System.Drawing.Size(86, 13);
            this.lSpotifyPlays.TabIndex = 0;
            this.lSpotifyPlays.Text = "Number of plays:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.bYTPaste);
            this.groupBox2.Controls.Add(this.lYTResult);
            this.groupBox2.Controls.Add(this.lYTDislikes);
            this.groupBox2.Controls.Add(this.numYTDislikes);
            this.groupBox2.Controls.Add(this.numYTLikes);
            this.groupBox2.Controls.Add(this.lYTLikes);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YouTube";
            // 
            // bYTPaste
            // 
            this.bYTPaste.Location = new System.Drawing.Point(138, 71);
            this.bYTPaste.Name = "bYTPaste";
            this.bYTPaste.Size = new System.Drawing.Size(75, 23);
            this.bYTPaste.TabIndex = 4;
            this.bYTPaste.Text = "Paste";
            this.bYTPaste.UseVisualStyleBackColor = true;
            this.bYTPaste.Click += new System.EventHandler(this.bYTPaste_Click);
            // 
            // lYTResult
            // 
            this.lYTResult.AutoSize = true;
            this.lYTResult.Location = new System.Drawing.Point(6, 76);
            this.lYTResult.Name = "lYTResult";
            this.lYTResult.Size = new System.Drawing.Size(49, 13);
            this.lYTResult.TabIndex = 3;
            this.lYTResult.Text = "Result: 0";
            // 
            // lYTDislikes
            // 
            this.lYTDislikes.AutoSize = true;
            this.lYTDislikes.Location = new System.Drawing.Point(6, 47);
            this.lYTDislikes.Name = "lYTDislikes";
            this.lYTDislikes.Size = new System.Drawing.Size(96, 13);
            this.lYTDislikes.TabIndex = 1;
            this.lYTDislikes.Text = "Number of dislikes:";
            // 
            // numYTDislikes
            // 
            this.numYTDislikes.Location = new System.Drawing.Point(108, 45);
            this.numYTDislikes.Maximum = new decimal(new int[] {
            21000000,
            0,
            0,
            0});
            this.numYTDislikes.Name = "numYTDislikes";
            this.numYTDislikes.Size = new System.Drawing.Size(105, 20);
            this.numYTDislikes.TabIndex = 2;
            this.numYTDislikes.ValueChanged += new System.EventHandler(this.numYT_ValueChanged);
            // 
            // numYTLikes
            // 
            this.numYTLikes.Location = new System.Drawing.Point(95, 19);
            this.numYTLikes.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numYTLikes.Name = "numYTLikes";
            this.numYTLikes.Size = new System.Drawing.Size(118, 20);
            this.numYTLikes.TabIndex = 1;
            this.numYTLikes.ValueChanged += new System.EventHandler(this.numYT_ValueChanged);
            // 
            // lYTLikes
            // 
            this.lYTLikes.AutoSize = true;
            this.lYTLikes.Location = new System.Drawing.Point(6, 21);
            this.lYTLikes.Name = "lYTLikes";
            this.lYTLikes.Size = new System.Drawing.Size(83, 13);
            this.lYTLikes.TabIndex = 0;
            this.lYTLikes.Text = "Number of likes:";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.bSCPaste);
            this.groupBox3.Controls.Add(this.lSCResult);
            this.groupBox3.Controls.Add(this.lSCLikes);
            this.groupBox3.Controls.Add(this.numSCLikes);
            this.groupBox3.Controls.Add(this.numSCPlays);
            this.groupBox3.Controls.Add(this.lSCPlays);
            this.groupBox3.Location = new System.Drawing.Point(12, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 113);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SoundCloud";
            // 
            // bSCPaste
            // 
            this.bSCPaste.Location = new System.Drawing.Point(138, 71);
            this.bSCPaste.Name = "bSCPaste";
            this.bSCPaste.Size = new System.Drawing.Size(75, 23);
            this.bSCPaste.TabIndex = 4;
            this.bSCPaste.Text = "Paste";
            this.bSCPaste.UseVisualStyleBackColor = true;
            this.bSCPaste.Click += new System.EventHandler(this.bSCPaste_Click);
            // 
            // lSCResult
            // 
            this.lSCResult.AutoSize = true;
            this.lSCResult.Location = new System.Drawing.Point(6, 76);
            this.lSCResult.Name = "lSCResult";
            this.lSCResult.Size = new System.Drawing.Size(49, 13);
            this.lSCResult.TabIndex = 3;
            this.lSCResult.Text = "Result: 0";
            // 
            // lSCLikes
            // 
            this.lSCLikes.AutoSize = true;
            this.lSCLikes.Location = new System.Drawing.Point(6, 47);
            this.lSCLikes.Name = "lSCLikes";
            this.lSCLikes.Size = new System.Drawing.Size(83, 13);
            this.lSCLikes.TabIndex = 1;
            this.lSCLikes.Text = "Number of likes:";
            // 
            // numSCLikes
            // 
            this.numSCLikes.Location = new System.Drawing.Point(95, 45);
            this.numSCLikes.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numSCLikes.Name = "numSCLikes";
            this.numSCLikes.Size = new System.Drawing.Size(118, 20);
            this.numSCLikes.TabIndex = 2;
            this.numSCLikes.ValueChanged += new System.EventHandler(this.numSC_ValueChanged);
            // 
            // numSCPlays
            // 
            this.numSCPlays.Location = new System.Drawing.Point(98, 19);
            this.numSCPlays.Maximum = new decimal(new int[] {
            400000000,
            0,
            0,
            0});
            this.numSCPlays.Name = "numSCPlays";
            this.numSCPlays.Size = new System.Drawing.Size(115, 20);
            this.numSCPlays.TabIndex = 1;
            this.numSCPlays.ValueChanged += new System.EventHandler(this.numSC_ValueChanged);
            // 
            // lSCPlays
            // 
            this.lSCPlays.AutoSize = true;
            this.lSCPlays.Location = new System.Drawing.Point(6, 21);
            this.lSCPlays.Name = "lSCPlays";
            this.lSCPlays.Size = new System.Drawing.Size(86, 13);
            this.lSCPlays.TabIndex = 0;
            this.lSCPlays.Text = "Number of plays:";
            // 
            // tDontNull
            // 
            this.tDontNull.Enabled = true;
            this.tDontNull.Interval = 1000;
            this.tDontNull.Tick += new System.EventHandler(this.tDontNull_Tick);
            // 
            // rating_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(243, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBlank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rating_calculator";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rating Calculator";
            this.gbBlank.ResumeLayout(false);
            this.gbBlank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlankMaxStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlankStars)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpotifyMaxPlays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpotifyPlays)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYTDislikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTLikes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSCLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSCPlays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBlank;
        private System.Windows.Forms.Label lBlankMaxStars;
        private System.Windows.Forms.NumericUpDown numBlankMaxStars;
        private System.Windows.Forms.NumericUpDown numBlankStars;
        private System.Windows.Forms.Label lBlankStars;
        private System.Windows.Forms.Button bBlankPaste;
        private System.Windows.Forms.Label lBlankResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bSpotifyPaste;
        private System.Windows.Forms.Label lSpotifyResult;
        private System.Windows.Forms.Label lSpotifyMaxPlays;
        private System.Windows.Forms.NumericUpDown numSpotifyMaxPlays;
        private System.Windows.Forms.NumericUpDown numSpotifyPlays;
        private System.Windows.Forms.Label lSpotifyPlays;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bYTPaste;
        private System.Windows.Forms.Label lYTResult;
        private System.Windows.Forms.Label lYTDislikes;
        private System.Windows.Forms.NumericUpDown numYTDislikes;
        private System.Windows.Forms.NumericUpDown numYTLikes;
        private System.Windows.Forms.Label lYTLikes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bSCPaste;
        private System.Windows.Forms.Label lSCResult;
        private System.Windows.Forms.Label lSCLikes;
        private System.Windows.Forms.NumericUpDown numSCLikes;
        private System.Windows.Forms.NumericUpDown numSCPlays;
        private System.Windows.Forms.Label lSCPlays;
        private System.Windows.Forms.Timer tDontNull;
    }
}