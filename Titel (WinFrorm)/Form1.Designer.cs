namespace Titel__WinFrorm_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tssbSave = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCloseFile = new System.Windows.Forms.ToolStripButton();
            this.tsSp1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.lAlbum = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lTrackNumber = new System.Windows.Forms.Label();
            this.lGenre = new System.Windows.Forms.Label();
            this.lAlbumArtist = new System.Windows.Forms.Label();
            this.lPicture = new System.Windows.Forms.Label();
            this.lResulution = new System.Windows.Forms.Label();
            this.bOpenPicture = new System.Windows.Forms.Button();
            this.lRatingBlank = new System.Windows.Forms.Label();
            this.numRatingBlank = new System.Windows.Forms.NumericUpDown();
            this.tbStarsBlank = new System.Windows.Forms.TrackBar();
            this.openFileDiJPGPNG = new System.Windows.Forms.OpenFileDialog();
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
            this.lComposer = new System.Windows.Forms.Label();
            this.tbComposer = new System.Windows.Forms.TextBox();
            this.lDiscNumber = new System.Windows.Forms.Label();
            this.tFileChanged = new System.Windows.Forms.Timer(this.components);
            this.numDiscNumber = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pBoxAlbum = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSpotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsYouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingYouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSoundcloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSoundcloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // tsTop
            // 
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tssbSave,
            this.tsbCloseFile,
            this.tsSp1,
            this.tslChanges});
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(464, 25);
            this.tsTop.Stretch = true;
            this.tsTop.TabIndex = 0;
            this.tsTop.Text = "toolStrip";
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::Titel_WinFrorm.Properties.Resources.opened_folder_96px;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "Open File";
            this.tsbOpen.ToolTipText = "Open MP3 file...";
            this.tsbOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // tssbSave
            // 
            this.tssbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiSaveAs});
            this.tssbSave.Image = global::Titel_WinFrorm.Properties.Resources.save_96px;
            this.tssbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSave.Name = "tssbSave";
            this.tssbSave.Size = new System.Drawing.Size(32, 22);
            this.tssbSave.Text = "Save";
            this.tssbSave.ToolTipText = "Save... or Save as...";
            this.tssbSave.ButtonClick += new System.EventHandler(this.tssbSave_ButtonClick);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = global::Titel_WinFrorm.Properties.Resources.save_96px;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(114, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tssbSave_ButtonClick);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Image = global::Titel_WinFrorm.Properties.Resources.save_as_96px;
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(114, 22);
            this.tsmiSaveAs.Text = "Save As";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsbCloseFile
            // 
            this.tsbCloseFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseFile.Image = global::Titel_WinFrorm.Properties.Resources.close_tab_96px;
            this.tsbCloseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseFile.Name = "tsbCloseFile";
            this.tsbCloseFile.Size = new System.Drawing.Size(23, 22);
            this.tsbCloseFile.Text = "Close file";
            this.tsbCloseFile.Click += new System.EventHandler(this.tsbCloseFile_Click);
            // 
            // tsSp1
            // 
            this.tsSp1.Name = "tsSp1";
            this.tsSp1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslChanges
            // 
            this.tslChanges.Name = "tslChanges";
            this.tslChanges.Size = new System.Drawing.Size(39, 22);
            this.tslChanges.Text = "Status";
            // 
            // openFileDiMP3
            // 
            this.openFileDiMP3.DefaultExt = "mp3";
            this.openFileDiMP3.Filter = "MP3 Audio Files|*.mp3";
            this.openFileDiMP3.RestoreDirectory = true;
            this.openFileDiMP3.Title = "Open MP3 file...";
            // 
            // lFileName
            // 
            this.lFileName.AutoSize = true;
            this.lFileName.Location = new System.Drawing.Point(12, 34);
            this.lFileName.Name = "lFileName";
            this.lFileName.Size = new System.Drawing.Size(26, 13);
            this.lFileName.TabIndex = 1;
            this.lFileName.Text = "File:";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(44, 31);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(409, 20);
            this.tbFileName.TabIndex = 2;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(51, 83);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(402, 20);
            this.tbArtist.TabIndex = 4;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(48, 109);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(405, 20);
            this.tbTitle.TabIndex = 6;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(57, 135);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(396, 20);
            this.tbAlbum.TabIndex = 8;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(56, 240);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(396, 20);
            this.tbGenre.TabIndex = 16;
            // 
            // tbAlbumArtist
            // 
            this.tbAlbumArtist.Location = new System.Drawing.Point(83, 266);
            this.tbAlbumArtist.Name = "tbAlbumArtist";
            this.tbAlbumArtist.Size = new System.Drawing.Size(369, 20);
            this.tbAlbumArtist.TabIndex = 18;
            // 
            // lArtist
            // 
            this.lArtist.AutoSize = true;
            this.lArtist.Location = new System.Drawing.Point(12, 86);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(33, 13);
            this.lArtist.TabIndex = 3;
            this.lArtist.Text = "Artist:";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(12, 112);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(30, 13);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "Title:";
            // 
            // lAlbum
            // 
            this.lAlbum.AutoSize = true;
            this.lAlbum.Location = new System.Drawing.Point(12, 138);
            this.lAlbum.Name = "lAlbum";
            this.lAlbum.Size = new System.Drawing.Size(39, 13);
            this.lAlbum.TabIndex = 7;
            this.lAlbum.Text = "Album:";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(12, 164);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(33, 13);
            this.lDate.TabIndex = 9;
            this.lDate.Text = "Date:";
            // 
            // lTrackNumber
            // 
            this.lTrackNumber.AutoSize = true;
            this.lTrackNumber.Location = new System.Drawing.Point(12, 190);
            this.lTrackNumber.Name = "lTrackNumber";
            this.lTrackNumber.Size = new System.Drawing.Size(78, 13);
            this.lTrackNumber.TabIndex = 11;
            this.lTrackNumber.Text = "Track Number:";
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Location = new System.Drawing.Point(12, 243);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(39, 13);
            this.lGenre.TabIndex = 15;
            this.lGenre.Text = "Genre:";
            // 
            // lAlbumArtist
            // 
            this.lAlbumArtist.AutoSize = true;
            this.lAlbumArtist.Location = new System.Drawing.Point(12, 269);
            this.lAlbumArtist.Name = "lAlbumArtist";
            this.lAlbumArtist.Size = new System.Drawing.Size(65, 13);
            this.lAlbumArtist.TabIndex = 17;
            this.lAlbumArtist.Text = "Album Artist:";
            // 
            // lPicture
            // 
            this.lPicture.AutoSize = true;
            this.lPicture.Location = new System.Drawing.Point(303, 292);
            this.lPicture.Name = "lPicture";
            this.lPicture.Size = new System.Drawing.Size(43, 13);
            this.lPicture.TabIndex = 35;
            this.lPicture.Text = "Picture:";
            // 
            // lResulution
            // 
            this.lResulution.Location = new System.Drawing.Point(287, 305);
            this.lResulution.Name = "lResulution";
            this.lResulution.Size = new System.Drawing.Size(60, 13);
            this.lResulution.TabIndex = 36;
            this.lResulution.Text = "null";
            this.lResulution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bOpenPicture
            // 
            this.bOpenPicture.Location = new System.Drawing.Point(352, 398);
            this.bOpenPicture.Name = "bOpenPicture";
            this.bOpenPicture.Size = new System.Drawing.Size(100, 23);
            this.bOpenPicture.TabIndex = 37;
            this.bOpenPicture.Text = "Open Picture";
            this.bOpenPicture.UseVisualStyleBackColor = true;
            this.bOpenPicture.Click += new System.EventHandler(this.bOpenPicture_Click);
            // 
            // lRatingBlank
            // 
            this.lRatingBlank.AutoSize = true;
            this.lRatingBlank.Location = new System.Drawing.Point(12, 346);
            this.lRatingBlank.Name = "lRatingBlank";
            this.lRatingBlank.Size = new System.Drawing.Size(99, 13);
            this.lRatingBlank.TabIndex = 23;
            this.lRatingBlank.Text = "Rating (from blank):";
            // 
            // numRatingBlank
            // 
            this.numRatingBlank.Location = new System.Drawing.Point(117, 344);
            this.numRatingBlank.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingBlank.Name = "numRatingBlank";
            this.numRatingBlank.Size = new System.Drawing.Size(47, 20);
            this.numRatingBlank.TabIndex = 24;
            this.numRatingBlank.ValueChanged += new System.EventHandler(this.numRating_ValueChanged);
            // 
            // tbStarsBlank
            // 
            this.tbStarsBlank.LargeChange = 1;
            this.tbStarsBlank.Location = new System.Drawing.Point(15, 370);
            this.tbStarsBlank.Maximum = 5;
            this.tbStarsBlank.Name = "tbStarsBlank";
            this.tbStarsBlank.Size = new System.Drawing.Size(149, 45);
            this.tbStarsBlank.TabIndex = 25;
            this.tbStarsBlank.Scroll += new System.EventHandler(this.tbStarsBlank_Scroll);
            // 
            // openFileDiJPGPNG
            // 
            this.openFileDiJPGPNG.Filter = "PNG image|*.png|JPG image|*.jpg";
            this.openFileDiJPGPNG.RestoreDirectory = true;
            this.openFileDiJPGPNG.Title = "Open image file...";
            // 
            // numDate
            // 
            this.numDate.Location = new System.Drawing.Point(51, 161);
            this.numDate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numDate.Name = "numDate";
            this.numDate.Size = new System.Drawing.Size(402, 20);
            this.numDate.TabIndex = 10;
            this.numDate.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // numTrackNumber
            // 
            this.numTrackNumber.Location = new System.Drawing.Point(96, 188);
            this.numTrackNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numTrackNumber.Name = "numTrackNumber";
            this.numTrackNumber.Size = new System.Drawing.Size(357, 20);
            this.numTrackNumber.TabIndex = 12;
            this.numTrackNumber.ThousandsSeparator = true;
            this.numTrackNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbStarsSpotify
            // 
            this.tbStarsSpotify.LargeChange = 1;
            this.tbStarsSpotify.Location = new System.Drawing.Point(173, 370);
            this.tbStarsSpotify.Maximum = 5;
            this.tbStarsSpotify.Name = "tbStarsSpotify";
            this.tbStarsSpotify.Size = new System.Drawing.Size(132, 45);
            this.tbStarsSpotify.TabIndex = 28;
            this.tbStarsSpotify.Scroll += new System.EventHandler(this.tbStarsSpotify_Scroll);
            // 
            // numRatingSpotify
            // 
            this.numRatingSpotify.Location = new System.Drawing.Point(258, 344);
            this.numRatingSpotify.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingSpotify.Name = "numRatingSpotify";
            this.numRatingSpotify.Size = new System.Drawing.Size(47, 20);
            this.numRatingSpotify.TabIndex = 27;
            this.numRatingSpotify.ValueChanged += new System.EventHandler(this.numRatingSpotify_ValueChanged);
            // 
            // lRatingSpotify
            // 
            this.lRatingSpotify.AutoSize = true;
            this.lRatingSpotify.Location = new System.Drawing.Point(170, 346);
            this.lRatingSpotify.Name = "lRatingSpotify";
            this.lRatingSpotify.Size = new System.Drawing.Size(82, 13);
            this.lRatingSpotify.TabIndex = 26;
            this.lRatingSpotify.Text = "Rating (Spotify):";
            // 
            // tbStarsYouTube
            // 
            this.tbStarsYouTube.LargeChange = 1;
            this.tbStarsYouTube.Location = new System.Drawing.Point(15, 448);
            this.tbStarsYouTube.Maximum = 5;
            this.tbStarsYouTube.Name = "tbStarsYouTube";
            this.tbStarsYouTube.Size = new System.Drawing.Size(144, 45);
            this.tbStarsYouTube.TabIndex = 31;
            this.tbStarsYouTube.Scroll += new System.EventHandler(this.tbStarsYouTube_Scroll);
            // 
            // numRatingYouTube
            // 
            this.numRatingYouTube.Location = new System.Drawing.Point(112, 421);
            this.numRatingYouTube.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingYouTube.Name = "numRatingYouTube";
            this.numRatingYouTube.Size = new System.Drawing.Size(47, 20);
            this.numRatingYouTube.TabIndex = 30;
            this.numRatingYouTube.ValueChanged += new System.EventHandler(this.numRatingYouTube_ValueChanged);
            // 
            // lRatingYouTube
            // 
            this.lRatingYouTube.AutoSize = true;
            this.lRatingYouTube.Location = new System.Drawing.Point(12, 423);
            this.lRatingYouTube.Name = "lRatingYouTube";
            this.lRatingYouTube.Size = new System.Drawing.Size(94, 13);
            this.lRatingYouTube.TabIndex = 29;
            this.lRatingYouTube.Text = "Rating (YouTube):";
            // 
            // tbStarsSoundcloud
            // 
            this.tbStarsSoundcloud.LargeChange = 1;
            this.tbStarsSoundcloud.Location = new System.Drawing.Point(168, 448);
            this.tbStarsSoundcloud.Maximum = 5;
            this.tbStarsSoundcloud.Name = "tbStarsSoundcloud";
            this.tbStarsSoundcloud.Size = new System.Drawing.Size(157, 45);
            this.tbStarsSoundcloud.TabIndex = 34;
            this.tbStarsSoundcloud.Scroll += new System.EventHandler(this.tbStarsSoundcloud_Scroll);
            // 
            // numRatingSoundcloud
            // 
            this.numRatingSoundcloud.Location = new System.Drawing.Point(278, 421);
            this.numRatingSoundcloud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRatingSoundcloud.Name = "numRatingSoundcloud";
            this.numRatingSoundcloud.Size = new System.Drawing.Size(47, 20);
            this.numRatingSoundcloud.TabIndex = 33;
            this.numRatingSoundcloud.ValueChanged += new System.EventHandler(this.numRatingSoundcloud_ValueChanged);
            // 
            // lRatingSoundcloud
            // 
            this.lRatingSoundcloud.AutoSize = true;
            this.lRatingSoundcloud.Location = new System.Drawing.Point(165, 423);
            this.lRatingSoundcloud.Name = "lRatingSoundcloud";
            this.lRatingSoundcloud.Size = new System.Drawing.Size(107, 13);
            this.lRatingSoundcloud.TabIndex = 32;
            this.lRatingSoundcloud.Text = "Rating (Soundcloud):";
            // 
            // lComposer
            // 
            this.lComposer.AutoSize = true;
            this.lComposer.Location = new System.Drawing.Point(12, 295);
            this.lComposer.Name = "lComposer";
            this.lComposer.Size = new System.Drawing.Size(57, 13);
            this.lComposer.TabIndex = 19;
            this.lComposer.Text = "Composer:";
            // 
            // tbComposer
            // 
            this.tbComposer.Location = new System.Drawing.Point(75, 292);
            this.tbComposer.Name = "tbComposer";
            this.tbComposer.Size = new System.Drawing.Size(206, 20);
            this.tbComposer.TabIndex = 20;
            // 
            // lDiscNumber
            // 
            this.lDiscNumber.AutoSize = true;
            this.lDiscNumber.Location = new System.Drawing.Point(12, 216);
            this.lDiscNumber.Name = "lDiscNumber";
            this.lDiscNumber.Size = new System.Drawing.Size(71, 13);
            this.lDiscNumber.TabIndex = 13;
            this.lDiscNumber.Text = "Disc Number:";
            // 
            // tFileChanged
            // 
            this.tFileChanged.Interval = 1000;
            this.tFileChanged.Tick += new System.EventHandler(this.tFileChanged_Tick);
            // 
            // numDiscNumber
            // 
            this.numDiscNumber.Location = new System.Drawing.Point(89, 214);
            this.numDiscNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDiscNumber.Name = "numDiscNumber";
            this.numDiscNumber.Size = new System.Drawing.Size(363, 20);
            this.numDiscNumber.TabIndex = 14;
            this.numDiscNumber.ThousandsSeparator = true;
            this.numDiscNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pBoxAlbum
            // 
            this.pBoxAlbum.BackgroundImage = global::Titel_WinFrorm.Properties.Resources.generic_music_file_100px;
            this.pBoxAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAlbum.Location = new System.Drawing.Point(352, 292);
            this.pBoxAlbum.Name = "pBoxAlbum";
            this.pBoxAlbum.Size = new System.Drawing.Size(100, 100);
            this.pBoxAlbum.TabIndex = 18;
            this.pBoxAlbum.TabStop = false;
            this.toolTip.SetToolTip(this.pBoxAlbum, "Left Click to Delete\r\nRight Click to Reset");
            this.pBoxAlbum.DragDrop += new System.Windows.Forms.DragEventHandler(this.pBoxAlbum_DragDrop);
            this.pBoxAlbum.DragEnter += new System.Windows.Forms.DragEventHandler(this.pBoxAlbum_DragEnter);
            this.pBoxAlbum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxAlbum_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Remixed by:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 481);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDiscNumber);
            this.Controls.Add(this.lDiscNumber);
            this.Controls.Add(this.lComposer);
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
            this.Controls.Add(this.tbStarsBlank);
            this.Controls.Add(this.numRatingBlank);
            this.Controls.Add(this.lRatingBlank);
            this.Controls.Add(this.bOpenPicture);
            this.Controls.Add(this.lResulution);
            this.Controls.Add(this.lPicture);
            this.Controls.Add(this.pBoxAlbum);
            this.Controls.Add(this.lAlbumArtist);
            this.Controls.Add(this.lGenre);
            this.Controls.Add(this.lTrackNumber);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lAlbum);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Titel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSpotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsYouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingYouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStarsSoundcloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSoundcloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsbOpen;
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
        private System.Windows.Forms.Label lAlbum;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lTrackNumber;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.Label lAlbumArtist;
        private System.Windows.Forms.PictureBox pBoxAlbum;
        private System.Windows.Forms.Label lPicture;
        private System.Windows.Forms.Label lResulution;
        private System.Windows.Forms.Button bOpenPicture;
        private System.Windows.Forms.Label lRatingBlank;
        private System.Windows.Forms.NumericUpDown numRatingBlank;
        private System.Windows.Forms.TrackBar tbStarsBlank;
        private System.Windows.Forms.OpenFileDialog openFileDiJPGPNG;
        private System.Windows.Forms.ToolStripLabel tslChanges;
        private System.Windows.Forms.NumericUpDown numDate;
        private System.Windows.Forms.NumericUpDown numTrackNumber;
        private System.Windows.Forms.TrackBar tbStarsSpotify;
        private System.Windows.Forms.NumericUpDown numRatingSpotify;
        private System.Windows.Forms.Label lRatingSpotify;
        private System.Windows.Forms.TrackBar tbStarsYouTube;
        private System.Windows.Forms.NumericUpDown numRatingYouTube;
        private System.Windows.Forms.Label lRatingYouTube;
        private System.Windows.Forms.TrackBar tbStarsSoundcloud;
        private System.Windows.Forms.NumericUpDown numRatingSoundcloud;
        private System.Windows.Forms.Label lRatingSoundcloud;
        private System.Windows.Forms.Label lComposer;
        private System.Windows.Forms.TextBox tbComposer;
        private System.Windows.Forms.Label lDiscNumber;
        private System.Windows.Forms.ToolStripSeparator tsSp1;
        public System.Windows.Forms.Timer tFileChanged;
        private System.Windows.Forms.ToolStripSplitButton tssbSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripButton tsbCloseFile;
        private System.Windows.Forms.NumericUpDown numDiscNumber;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

