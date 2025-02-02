using System;

namespace Titel_WinForm
{
    partial class Main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsSp = new System.Windows.Forms.ToolStripSeparator();
            this.tslChanges = new System.Windows.Forms.ToolStripLabel();
            this.openFileDiMP3 = new System.Windows.Forms.OpenFileDialog();
            this.lFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbAlbumArtist = new System.Windows.Forms.TextBox();
            this.lArtist = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.lResulution = new System.Windows.Forms.Label();
            this.bOpenPicture = new System.Windows.Forms.Button();
            this.openFileDiPic = new System.Windows.Forms.OpenFileDialog();
            this.numDate = new System.Windows.Forms.NumericUpDown();
            this.numTrackNumber = new System.Windows.Forms.NumericUpDown();
            this.tbStarsSpotify = new System.Windows.Forms.TrackBar();
            this.numRatingSpotify = new System.Windows.Forms.NumericUpDown();
            this.lRatingSpotify = new System.Windows.Forms.Label();
            this.tbStarsYouTube = new System.Windows.Forms.TrackBar();
            this.numRatingYouTube = new System.Windows.Forms.NumericUpDown();
            this.lRatingYouTube = new System.Windows.Forms.Label();
            this.tbStarsSoundcloud = new System.Windows.Forms.TrackBar();
            this.numRatingSoundcloud = new System.Windows.Forms.NumericUpDown();
            this.lRatingSoundcloud = new System.Windows.Forms.Label();
            this.tbComposer = new System.Windows.Forms.TextBox();
            this.tFileChanged = new System.Windows.Forms.Timer(this.components);
            this.numDiscNumber = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numSpotifyMaxPlays = new System.Windows.Forms.NumericUpDown();
            this.numSpotifyPlays = new System.Windows.Forms.NumericUpDown();
            this.numYTDislikes = new System.Windows.Forms.NumericUpDown();
            this.numYTLikes = new System.Windows.Forms.NumericUpDown();
            this.numSCLikes = new System.Windows.Forms.NumericUpDown();
            this.numSCPlays = new System.Windows.Forms.NumericUpDown();
            this.numSCRepost = new System.Windows.Forms.NumericUpDown();
            this.bFileFromTags = new System.Windows.Forms.Button();
            this.numYTMDislikes = new System.Windows.Forms.NumericUpDown();
            this.numYTMLikes = new System.Windows.Forms.NumericUpDown();
            this.tbRemixer = new System.Windows.Forms.TextBox();
            this.chbAlbum = new System.Windows.Forms.CheckBox();
            this.chbYear = new System.Windows.Forms.CheckBox();
            this.chbTrack = new System.Windows.Forms.CheckBox();
            this.chbDisk = new System.Windows.Forms.CheckBox();
            this.chbGenres = new System.Windows.Forms.CheckBox();
            this.chbAlbumArtists = new System.Windows.Forms.CheckBox();
            this.chbComposers = new System.Windows.Forms.CheckBox();
            this.chbRemixer = new System.Windows.Forms.CheckBox();
            this.lRatingYouTubeMusic = new System.Windows.Forms.Label();
            this.numRatingYouTubeMusic = new System.Windows.Forms.NumericUpDown();
            this.tbStarsYouTubeMusic = new System.Windows.Forms.TrackBar();
            this.tDontNull = new System.Windows.Forms.Timer(this.components);
            this.openFileDiTempl = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDiTempl = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDiMP3 = new System.Windows.Forms.SaveFileDialog();
            this.tbSortArtist = new System.Windows.Forms.TextBox();
            this.tbSortTitle = new System.Windows.Forms.TextBox();
            this.tbSortAlbum = new System.Windows.Forms.TextBox();
            this.chbSortArtist = new System.Windows.Forms.CheckBox();
            this.chbSortTitle = new System.Windows.Forms.CheckBox();
            this.chbSortAlbum = new System.Windows.Forms.CheckBox();
            this.pBoxAlbum = new System.Windows.Forms.PictureBox();
            this.tsbOpenMP3 = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenTempl = new System.Windows.Forms.ToolStripButton();
            this.tssbSave = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCloseFile = new System.Windows.Forms.ToolStripButton();
            this.tsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsYouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingYouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSoundcloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSoundcloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpotifyMaxPlays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpotifyPlays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTDislikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSCLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSCPlays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSCRepost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTMDislikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTMLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingYouTubeMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsYouTubeMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // tsTop
            // 
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenMP3,
            this.tsbOpenTempl,
            this.tssbSave,
            this.tsbCloseFile,
            this.tsSp,
            this.tslChanges});
            resources.ApplyResources(this.tsTop, "tsTop");
            this.tsTop.Name = "tsTop";
            this.tsTop.Stretch = true;
            // 
            // tsSp
            // 
            this.tsSp.Name = "tsSp";
            resources.ApplyResources(this.tsSp, "tsSp");
            // 
            // tslChanges
            // 
            this.tslChanges.Name = "tslChanges";
            resources.ApplyResources(this.tslChanges, "tslChanges");
            this.tslChanges.Click += new System.EventHandler(this.tslChanges_Click);
            // 
            // openFileDiMP3
            // 
            this.openFileDiMP3.DefaultExt = "mp3";
            resources.ApplyResources(this.openFileDiMP3, "openFileDiMP3");
            this.openFileDiMP3.RestoreDirectory = true;
            // 
            // lFileName
            // 
            resources.ApplyResources(this.lFileName, "lFileName");
            this.lFileName.Name = "lFileName";
            this.toolTip.SetToolTip(this.lFileName, resources.GetString("lFileName.ToolTip"));
            // 
            // tbFileName
            // 
            resources.ApplyResources(this.tbFileName, "tbFileName");
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbArtist
            // 
            resources.ApplyResources(this.tbArtist, "tbArtist");
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbTitle
            // 
            resources.ApplyResources(this.tbTitle, "tbTitle");
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbAlbum
            // 
            resources.ApplyResources(this.tbAlbum, "tbAlbum");
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbGenre
            // 
            resources.ApplyResources(this.tbGenre, "tbGenre");
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbAlbumArtist
            // 
            resources.ApplyResources(this.tbAlbumArtist, "tbAlbumArtist");
            this.tbAlbumArtist.Name = "tbAlbumArtist";
            this.tbAlbumArtist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lArtist
            // 
            resources.ApplyResources(this.lArtist, "lArtist");
            this.lArtist.Name = "lArtist";
            // 
            // lTitle
            // 
            resources.ApplyResources(this.lTitle, "lTitle");
            this.lTitle.Name = "lTitle";
            // 
            // lResulution
            // 
            resources.ApplyResources(this.lResulution, "lResulution");
            this.lResulution.Name = "lResulution";
            this.toolTip.SetToolTip(this.lResulution, resources.GetString("lResulution.ToolTip"));
            // 
            // bOpenPicture
            // 
            resources.ApplyResources(this.bOpenPicture, "bOpenPicture");
            this.bOpenPicture.Name = "bOpenPicture";
            this.toolTip.SetToolTip(this.bOpenPicture, resources.GetString("bOpenPicture.ToolTip"));
            this.bOpenPicture.UseVisualStyleBackColor = true;
            this.bOpenPicture.Click += new System.EventHandler(this.bOpenPicture_Click);
            this.bOpenPicture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // openFileDiPic
            // 
            resources.ApplyResources(this.openFileDiPic, "openFileDiPic");
            this.openFileDiPic.RestoreDirectory = true;
            // 
            // numDate
            // 
            resources.ApplyResources(this.numDate, "numDate");
            this.numDate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numDate.Name = "numDate";
            this.numDate.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.numDate.Leave += new System.EventHandler(this.numDate_Leave);
            // 
            // numTrackNumber
            // 
            resources.ApplyResources(this.numTrackNumber, "numTrackNumber");
            this.numTrackNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTrackNumber.Name = "numTrackNumber";
            this.numTrackNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrackNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbStarsSpotify
            // 
            resources.ApplyResources(this.tbStarsSpotify, "tbStarsSpotify");
            this.tbStarsSpotify.LargeChange = 1;
            this.tbStarsSpotify.Maximum = 5;
            this.tbStarsSpotify.Name = "tbStarsSpotify";
            this.tbStarsSpotify.Scroll += new System.EventHandler(this.tbStarsSpotify_Scroll);
            this.tbStarsSpotify.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numRatingSpotify
            // 
            resources.ApplyResources(this.numRatingSpotify, "numRatingSpotify");
            this.numRatingSpotify.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingSpotify.Name = "numRatingSpotify";
            this.numRatingSpotify.ValueChanged += new System.EventHandler(this.numRatingSpotify_ValueChanged);
            this.numRatingSpotify.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lRatingSpotify
            // 
            resources.ApplyResources(this.lRatingSpotify, "lRatingSpotify");
            this.lRatingSpotify.Name = "lRatingSpotify";
            // 
            // tbStarsYouTube
            // 
            resources.ApplyResources(this.tbStarsYouTube, "tbStarsYouTube");
            this.tbStarsYouTube.LargeChange = 1;
            this.tbStarsYouTube.Maximum = 5;
            this.tbStarsYouTube.Name = "tbStarsYouTube";
            this.tbStarsYouTube.Scroll += new System.EventHandler(this.tbStarsYouTube_Scroll);
            this.tbStarsYouTube.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numRatingYouTube
            // 
            resources.ApplyResources(this.numRatingYouTube, "numRatingYouTube");
            this.numRatingYouTube.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingYouTube.Name = "numRatingYouTube";
            this.numRatingYouTube.ValueChanged += new System.EventHandler(this.numRatingYouTube_ValueChanged);
            this.numRatingYouTube.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lRatingYouTube
            // 
            resources.ApplyResources(this.lRatingYouTube, "lRatingYouTube");
            this.lRatingYouTube.Name = "lRatingYouTube";
            // 
            // tbStarsSoundcloud
            // 
            resources.ApplyResources(this.tbStarsSoundcloud, "tbStarsSoundcloud");
            this.tbStarsSoundcloud.LargeChange = 1;
            this.tbStarsSoundcloud.Maximum = 5;
            this.tbStarsSoundcloud.Name = "tbStarsSoundcloud";
            this.tbStarsSoundcloud.Scroll += new System.EventHandler(this.tbStarsSoundcloud_Scroll);
            this.tbStarsSoundcloud.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numRatingSoundcloud
            // 
            resources.ApplyResources(this.numRatingSoundcloud, "numRatingSoundcloud");
            this.numRatingSoundcloud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingSoundcloud.Name = "numRatingSoundcloud";
            this.numRatingSoundcloud.ValueChanged += new System.EventHandler(this.numRatingSoundcloud_ValueChanged);
            this.numRatingSoundcloud.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lRatingSoundcloud
            // 
            resources.ApplyResources(this.lRatingSoundcloud, "lRatingSoundcloud");
            this.lRatingSoundcloud.Name = "lRatingSoundcloud";
            // 
            // tbComposer
            // 
            resources.ApplyResources(this.tbComposer, "tbComposer");
            this.tbComposer.Name = "tbComposer";
            this.tbComposer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tFileChanged
            // 
            this.tFileChanged.Interval = 1000;
            this.tFileChanged.Tick += new System.EventHandler(this.tFileChanged_Tick);
            // 
            // numDiscNumber
            // 
            resources.ApplyResources(this.numDiscNumber, "numDiscNumber");
            this.numDiscNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDiscNumber.Name = "numDiscNumber";
            this.numDiscNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDiscNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numSpotifyMaxPlays
            // 
            resources.ApplyResources(this.numSpotifyMaxPlays, "numSpotifyMaxPlays");
            this.numSpotifyMaxPlays.Maximum = new decimal(new int[] {
            -294967296,
            0,
            0,
            0});
            this.numSpotifyMaxPlays.Name = "numSpotifyMaxPlays";
            this.toolTip.SetToolTip(this.numSpotifyMaxPlays, resources.GetString("numSpotifyMaxPlays.ToolTip"));
            this.numSpotifyMaxPlays.ValueChanged += new System.EventHandler(this.numSpotify_ValueChanged);
            this.numSpotifyMaxPlays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.numSpotifyMaxPlays.Leave += new System.EventHandler(this.numSpotifyMaxPlays_Leave);
            // 
            // numSpotifyPlays
            // 
            resources.ApplyResources(this.numSpotifyPlays, "numSpotifyPlays");
            this.numSpotifyPlays.Maximum = new decimal(new int[] {
            -294967296,
            0,
            0,
            0});
            this.numSpotifyPlays.Name = "numSpotifyPlays";
            this.toolTip.SetToolTip(this.numSpotifyPlays, resources.GetString("numSpotifyPlays.ToolTip"));
            this.numSpotifyPlays.ValueChanged += new System.EventHandler(this.numSpotify_ValueChanged);
            this.numSpotifyPlays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numYTDislikes
            // 
            resources.ApplyResources(this.numYTDislikes, "numYTDislikes");
            this.numYTDislikes.Maximum = new decimal(new int[] {
            21000000,
            0,
            0,
            0});
            this.numYTDislikes.Name = "numYTDislikes";
            this.toolTip.SetToolTip(this.numYTDislikes, resources.GetString("numYTDislikes.ToolTip"));
            this.numYTDislikes.ValueChanged += new System.EventHandler(this.numYT_ValueChanged);
            this.numYTDislikes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numYTLikes
            // 
            resources.ApplyResources(this.numYTLikes, "numYTLikes");
            this.numYTLikes.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numYTLikes.Name = "numYTLikes";
            this.toolTip.SetToolTip(this.numYTLikes, resources.GetString("numYTLikes.ToolTip"));
            this.numYTLikes.ValueChanged += new System.EventHandler(this.numYT_ValueChanged);
            this.numYTLikes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numSCLikes
            // 
            resources.ApplyResources(this.numSCLikes, "numSCLikes");
            this.numSCLikes.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numSCLikes.Name = "numSCLikes";
            this.toolTip.SetToolTip(this.numSCLikes, resources.GetString("numSCLikes.ToolTip"));
            this.numSCLikes.ValueChanged += new System.EventHandler(this.numSC_ValueChanged);
            this.numSCLikes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numSCPlays
            // 
            resources.ApplyResources(this.numSCPlays, "numSCPlays");
            this.numSCPlays.Maximum = new decimal(new int[] {
            400000000,
            0,
            0,
            0});
            this.numSCPlays.Name = "numSCPlays";
            this.toolTip.SetToolTip(this.numSCPlays, resources.GetString("numSCPlays.ToolTip"));
            this.numSCPlays.ValueChanged += new System.EventHandler(this.numSC_ValueChanged);
            this.numSCPlays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.numSCPlays.Leave += new System.EventHandler(this.numSCPlays_Leave);
            // 
            // numSCRepost
            // 
            resources.ApplyResources(this.numSCRepost, "numSCRepost");
            this.numSCRepost.Maximum = new decimal(new int[] {
            400000000,
            0,
            0,
            0});
            this.numSCRepost.Name = "numSCRepost";
            this.toolTip.SetToolTip(this.numSCRepost, resources.GetString("numSCRepost.ToolTip"));
            this.numSCRepost.ValueChanged += new System.EventHandler(this.numSC_ValueChanged);
            this.numSCRepost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // bFileFromTags
            // 
            resources.ApplyResources(this.bFileFromTags, "bFileFromTags");
            this.bFileFromTags.Name = "bFileFromTags";
            this.toolTip.SetToolTip(this.bFileFromTags, resources.GetString("bFileFromTags.ToolTip"));
            this.bFileFromTags.UseVisualStyleBackColor = true;
            this.bFileFromTags.Click += new System.EventHandler(this.bFileFromTags_Click);
            this.bFileFromTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numYTMDislikes
            // 
            resources.ApplyResources(this.numYTMDislikes, "numYTMDislikes");
            this.numYTMDislikes.Maximum = new decimal(new int[] {
            21000000,
            0,
            0,
            0});
            this.numYTMDislikes.Name = "numYTMDislikes";
            this.toolTip.SetToolTip(this.numYTMDislikes, resources.GetString("numYTMDislikes.ToolTip"));
            this.numYTMDislikes.ValueChanged += new System.EventHandler(this.numYTM_ValueChanged);
            this.numYTMDislikes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numYTMLikes
            // 
            resources.ApplyResources(this.numYTMLikes, "numYTMLikes");
            this.numYTMLikes.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numYTMLikes.Name = "numYTMLikes";
            this.toolTip.SetToolTip(this.numYTMLikes, resources.GetString("numYTMLikes.ToolTip"));
            this.numYTMLikes.ValueChanged += new System.EventHandler(this.numYTM_ValueChanged);
            this.numYTMLikes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbRemixer
            // 
            resources.ApplyResources(this.tbRemixer, "tbRemixer");
            this.tbRemixer.Name = "tbRemixer";
            this.tbRemixer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // chbAlbum
            // 
            resources.ApplyResources(this.chbAlbum, "chbAlbum");
            this.chbAlbum.Checked = true;
            this.chbAlbum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAlbum.Name = "chbAlbum";
            this.chbAlbum.UseVisualStyleBackColor = true;
            this.chbAlbum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // chbYear
            // 
            resources.ApplyResources(this.chbYear, "chbYear");
            this.chbYear.Checked = true;
            this.chbYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbYear.Name = "chbYear";
            this.chbYear.UseVisualStyleBackColor = true;
            this.chbYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // chbTrack
            // 
            resources.ApplyResources(this.chbTrack, "chbTrack");
            this.chbTrack.Checked = true;
            this.chbTrack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTrack.Name = "chbTrack";
            this.chbTrack.UseVisualStyleBackColor = true;
            this.chbTrack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // chbDisk
            // 
            resources.ApplyResources(this.chbDisk, "chbDisk");
            this.chbDisk.Name = "chbDisk";
            this.chbDisk.UseVisualStyleBackColor = true;
            this.chbDisk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // chbGenres
            // 
            resources.ApplyResources(this.chbGenres, "chbGenres");
            this.chbGenres.Checked = true;
            this.chbGenres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGenres.Name = "chbGenres";
            this.chbGenres.UseVisualStyleBackColor = true;
            this.chbGenres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // chbAlbumArtists
            // 
            resources.ApplyResources(this.chbAlbumArtists, "chbAlbumArtists");
            this.chbAlbumArtists.Name = "chbAlbumArtists";
            this.chbAlbumArtists.UseVisualStyleBackColor = true;
            this.chbAlbumArtists.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // chbComposers
            // 
            resources.ApplyResources(this.chbComposers, "chbComposers");
            this.chbComposers.Name = "chbComposers";
            this.chbComposers.UseVisualStyleBackColor = true;
            this.chbComposers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // chbRemixer
            // 
            resources.ApplyResources(this.chbRemixer, "chbRemixer");
            this.chbRemixer.Name = "chbRemixer";
            this.chbRemixer.UseVisualStyleBackColor = true;
            this.chbRemixer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lRatingYouTubeMusic
            // 
            resources.ApplyResources(this.lRatingYouTubeMusic, "lRatingYouTubeMusic");
            this.lRatingYouTubeMusic.Name = "lRatingYouTubeMusic";
            // 
            // numRatingYouTubeMusic
            // 
            resources.ApplyResources(this.numRatingYouTubeMusic, "numRatingYouTubeMusic");
            this.numRatingYouTubeMusic.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingYouTubeMusic.Name = "numRatingYouTubeMusic";
            this.numRatingYouTubeMusic.ValueChanged += new System.EventHandler(this.numRatingYouTubeMusic_ValueChanged);
            this.numRatingYouTubeMusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbStarsYouTubeMusic
            // 
            resources.ApplyResources(this.tbStarsYouTubeMusic, "tbStarsYouTubeMusic");
            this.tbStarsYouTubeMusic.LargeChange = 1;
            this.tbStarsYouTubeMusic.Maximum = 5;
            this.tbStarsYouTubeMusic.Name = "tbStarsYouTubeMusic";
            // 
            // tDontNull
            // 
            this.tDontNull.Enabled = true;
            this.tDontNull.Interval = 1000;
            this.tDontNull.Tick += new System.EventHandler(this.tDontNull_Tick);
            // 
            // openFileDiTempl
            // 
            this.openFileDiTempl.DefaultExt = "templ";
            resources.ApplyResources(this.openFileDiTempl, "openFileDiTempl");
            this.openFileDiTempl.RestoreDirectory = true;
            // 
            // saveFileDiTempl
            // 
            this.saveFileDiTempl.DefaultExt = "templ";
            resources.ApplyResources(this.saveFileDiTempl, "saveFileDiTempl");
            this.saveFileDiTempl.RestoreDirectory = true;
            // 
            // saveFileDiMP3
            // 
            this.saveFileDiMP3.DefaultExt = "mp3";
            resources.ApplyResources(this.saveFileDiMP3, "saveFileDiMP3");
            this.saveFileDiMP3.RestoreDirectory = true;
            // 
            // tbSortArtist
            // 
            resources.ApplyResources(this.tbSortArtist, "tbSortArtist");
            this.tbSortArtist.Name = "tbSortArtist";
            // 
            // tbSortTitle
            // 
            resources.ApplyResources(this.tbSortTitle, "tbSortTitle");
            this.tbSortTitle.Name = "tbSortTitle";
            // 
            // tbSortAlbum
            // 
            resources.ApplyResources(this.tbSortAlbum, "tbSortAlbum");
            this.tbSortAlbum.Name = "tbSortAlbum";
            // 
            // chbSortArtist
            // 
            resources.ApplyResources(this.chbSortArtist, "chbSortArtist");
            this.chbSortArtist.Name = "chbSortArtist";
            this.chbSortArtist.UseVisualStyleBackColor = true;
            // 
            // chbSortTitle
            // 
            resources.ApplyResources(this.chbSortTitle, "chbSortTitle");
            this.chbSortTitle.Name = "chbSortTitle";
            this.chbSortTitle.UseVisualStyleBackColor = true;
            // 
            // chbSortAlbum
            // 
            resources.ApplyResources(this.chbSortAlbum, "chbSortAlbum");
            this.chbSortAlbum.Name = "chbSortAlbum";
            this.chbSortAlbum.UseVisualStyleBackColor = true;
            // 
            // pBoxAlbum
            // 
            this.pBoxAlbum.AllowDrop = true;
            resources.ApplyResources(this.pBoxAlbum, "pBoxAlbum");
            this.pBoxAlbum.Name = "pBoxAlbum";
            this.pBoxAlbum.TabStop = false;
            this.toolTip.SetToolTip(this.pBoxAlbum, resources.GetString("pBoxAlbum.ToolTip"));
            this.pBoxAlbum.DragDrop += new System.Windows.Forms.DragEventHandler(this.pBoxAlbum_DragDrop);
            this.pBoxAlbum.DragEnter += new System.Windows.Forms.DragEventHandler(this.pBoxAlbum_DragEnter);
            this.pBoxAlbum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxAlbum_MouseClick);
            this.pBoxAlbum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pBoxAlbum_MouseDoubleClick);
            // 
            // tsbOpenMP3
            // 
            this.tsbOpenMP3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbOpenMP3, "tsbOpenMP3");
            this.tsbOpenMP3.Name = "tsbOpenMP3";
            this.tsbOpenMP3.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // tsbOpenTempl
            // 
            this.tsbOpenTempl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenTempl.Image = global::Titel_WinForm.Properties.Resources.file_invoice_96px;
            resources.ApplyResources(this.tsbOpenTempl, "tsbOpenTempl");
            this.tsbOpenTempl.Name = "tsbOpenTempl";
            this.tsbOpenTempl.Click += new System.EventHandler(this.tsbOpenTempl_Click);
            // 
            // tssbSave
            // 
            this.tssbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiSaveAs,
            this.tsmiSaveTemplate,
            this.tsmiSaveImage});
            resources.ApplyResources(this.tssbSave, "tssbSave");
            this.tssbSave.Name = "tssbSave";
            this.tssbSave.ButtonClick += new System.EventHandler(this.tssbSave_ButtonClick);
            // 
            // tsmiSave
            // 
            resources.ApplyResources(this.tsmiSave, "tsmiSave");
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Click += new System.EventHandler(this.tssbSave_ButtonClick);
            // 
            // tsmiSaveAs
            // 
            resources.ApplyResources(this.tsmiSaveAs, "tsmiSaveAs");
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiSaveTemplate
            // 
            this.tsmiSaveTemplate.Image = global::Titel_WinForm.Properties.Resources.create_96px;
            this.tsmiSaveTemplate.Name = "tsmiSaveTemplate";
            resources.ApplyResources(this.tsmiSaveTemplate, "tsmiSaveTemplate");
            this.tsmiSaveTemplate.Click += new System.EventHandler(this.tsmiSaveTemplate_Click);
            // 
            // tsmiSaveImage
            // 
            this.tsmiSaveImage.Image = global::Titel_WinForm.Properties.Resources.save_image_96px;
            this.tsmiSaveImage.Name = "tsmiSaveImage";
            resources.ApplyResources(this.tsmiSaveImage, "tsmiSaveImage");
            this.tsmiSaveImage.Click += new System.EventHandler(this.tsmiSaveImage_Click);
            // 
            // tsbCloseFile
            // 
            this.tsbCloseFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbCloseFile, "tsbCloseFile");
            this.tsbCloseFile.Name = "tsbCloseFile";
            this.tsbCloseFile.Click += new System.EventHandler(this.tsbCloseFile_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbSortAlbum);
            this.Controls.Add(this.chbSortTitle);
            this.Controls.Add(this.chbSortArtist);
            this.Controls.Add(this.tbSortAlbum);
            this.Controls.Add(this.tbSortTitle);
            this.Controls.Add(this.tbSortArtist);
            this.Controls.Add(this.numYTMDislikes);
            this.Controls.Add(this.numYTMLikes);
            this.Controls.Add(this.numRatingYouTubeMusic);
            this.Controls.Add(this.lRatingYouTubeMusic);
            this.Controls.Add(this.numSCRepost);
            this.Controls.Add(this.numSCLikes);
            this.Controls.Add(this.numSCPlays);
            this.Controls.Add(this.numYTDislikes);
            this.Controls.Add(this.numYTLikes);
            this.Controls.Add(this.numSpotifyMaxPlays);
            this.Controls.Add(this.numSpotifyPlays);
            this.Controls.Add(this.bFileFromTags);
            this.Controls.Add(this.tbRemixer);
            this.Controls.Add(this.numDiscNumber);
            this.Controls.Add(this.tbComposer);
            this.Controls.Add(this.tbStarsSoundcloud);
            this.Controls.Add(this.numRatingSoundcloud);
            this.Controls.Add(this.lRatingSoundcloud);
            this.Controls.Add(this.tbStarsYouTube);
            this.Controls.Add(this.numRatingYouTube);
            this.Controls.Add(this.lRatingYouTube);
            this.Controls.Add(this.tbStarsSpotify);
            this.Controls.Add(this.numRatingSpotify);
            this.Controls.Add(this.lRatingSpotify);
            this.Controls.Add(this.numTrackNumber);
            this.Controls.Add(this.numDate);
            this.Controls.Add(this.bOpenPicture);
            this.Controls.Add(this.lResulution);
            this.Controls.Add(this.pBoxAlbum);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.lArtist);
            this.Controls.Add(this.tbAlbumArtist);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lFileName);
            this.Controls.Add(this.tsTop);
            this.Controls.Add(this.chbAlbum);
            this.Controls.Add(this.chbYear);
            this.Controls.Add(this.chbTrack);
            this.Controls.Add(this.chbDisk);
            this.Controls.Add(this.chbGenres);
            this.Controls.Add(this.chbAlbumArtists);
            this.Controls.Add(this.chbComposers);
            this.Controls.Add(this.chbRemixer);
            this.Controls.Add(this.tbStarsYouTubeMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsYouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingYouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSoundcloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSoundcloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpotifyMaxPlays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpotifyPlays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTDislikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSCLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSCPlays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSCRepost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTMDislikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYTMLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingYouTubeMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsYouTubeMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsbOpenMP3;
        public System.Windows.Forms.OpenFileDialog openFileDiMP3;
        private System.Windows.Forms.Label lFileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbAlbumArtist;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox pBoxAlbum;
        private System.Windows.Forms.Label lResulution;
        private System.Windows.Forms.Button bOpenPicture;
        private System.Windows.Forms.OpenFileDialog openFileDiPic;
        private System.Windows.Forms.ToolStripLabel tslChanges;
        private System.Windows.Forms.NumericUpDown numDate;
        private System.Windows.Forms.NumericUpDown numTrackNumber;
        private System.Windows.Forms.TrackBar tbStarsSpotify;
        private System.Windows.Forms.Label lRatingSpotify;
        private System.Windows.Forms.TrackBar tbStarsYouTube;
        private System.Windows.Forms.Label lRatingYouTube;
        private System.Windows.Forms.TrackBar tbStarsSoundcloud;
        private System.Windows.Forms.Label lRatingSoundcloud;
        private System.Windows.Forms.TextBox tbComposer;
        private System.Windows.Forms.ToolStripSeparator tsSp;
        public System.Windows.Forms.Timer tFileChanged;
        private System.Windows.Forms.ToolStripSplitButton tssbSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripButton tsbCloseFile;
        private System.Windows.Forms.NumericUpDown numDiscNumber;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tbRemixer;
        private System.Windows.Forms.Button bFileFromTags;
        private System.Windows.Forms.CheckBox chbAlbum;
        private System.Windows.Forms.CheckBox chbYear;
        private System.Windows.Forms.CheckBox chbTrack;
        private System.Windows.Forms.CheckBox chbDisk;
        private System.Windows.Forms.CheckBox chbGenres;
        private System.Windows.Forms.CheckBox chbAlbumArtists;
        private System.Windows.Forms.CheckBox chbComposers;
        private System.Windows.Forms.CheckBox chbRemixer;
        private System.Windows.Forms.NumericUpDown numRatingSpotify;
        private System.Windows.Forms.NumericUpDown numRatingYouTube;
        private System.Windows.Forms.NumericUpDown numRatingSoundcloud;
        private System.Windows.Forms.NumericUpDown numSpotifyMaxPlays;
        private System.Windows.Forms.NumericUpDown numSpotifyPlays;
        private System.Windows.Forms.NumericUpDown numYTDislikes;
        private System.Windows.Forms.NumericUpDown numYTLikes;
        private System.Windows.Forms.NumericUpDown numSCLikes;
        private System.Windows.Forms.NumericUpDown numSCPlays;
        private System.Windows.Forms.NumericUpDown numSCRepost;
        private System.Windows.Forms.Timer tDontNull;
        private System.Windows.Forms.ToolStripButton tsbOpenTempl;
        private System.Windows.Forms.OpenFileDialog openFileDiTempl;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveTemplate;
        private System.Windows.Forms.SaveFileDialog saveFileDiTempl;
        private System.Windows.Forms.SaveFileDialog saveFileDiMP3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveImage;
        private System.Windows.Forms.Label lRatingYouTubeMusic;
        private System.Windows.Forms.NumericUpDown numYTMDislikes;
        private System.Windows.Forms.NumericUpDown numYTMLikes;
        private System.Windows.Forms.NumericUpDown numRatingYouTubeMusic;
        private System.Windows.Forms.TrackBar tbStarsYouTubeMusic;
        private System.Windows.Forms.TextBox tbSortArtist;
        private System.Windows.Forms.TextBox tbSortTitle;
        private System.Windows.Forms.TextBox tbSortAlbum;
        private System.Windows.Forms.CheckBox chbSortArtist;
        private System.Windows.Forms.CheckBox chbSortTitle;
        private System.Windows.Forms.CheckBox chbSortAlbum;
    }
}

