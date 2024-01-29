using System;   
using System.Drawing;
using System.Windows.Forms;
using TagLib;
using System.IO;
using Titel_WinForm.Properties;
using Microsoft.Win32;
using System.Drawing.Imaging;
using System.Linq;

namespace Titel_WinForm
{
    public partial class Form1 : Form
    {
        string albumArtworkURL; //set album artwork path or default || done
        string musFileSName; //get file safe name
        string musFilePath; //get song's path || done
        string musFileName; //get song's full path (file path + safe file name)
        string[] _args;

        public Form1(string[] args) { InitializeComponent(); _args = args; }

        private void fileStatus(int status)
        {
            switch (status)
            {
                case 0:
                    tslChanges.Text = "File not loaded.";
                    this.Text = "Titel | File not loaded";
                    break;
                case 1:
                    tslChanges.Text = "File loading...";
                    this.Text = "Titel | File loading...";
                    break;
                case 2:
                    tslChanges.Text = "No changes";
                    this.Text = "Titel | " + musFileSName;
                    break;
                case 3:
                    tslChanges.Text = "Unsaved change(s)";
                    this.Text = "Titel | " + musFileSName;
                    break;
            }
        }

        public void tsbtnOpen_Click(object sender, EventArgs e)
        {
            tFileChanged.Stop();
            openFileDiMP3.InitialDirectory = Settings.Default.ofdMp3;
            try
            {
                if (openFileDiMP3.ShowDialog() == DialogResult.OK) { loadMusic(openFileDiMP3.FileName); }
                else { fileStatus(0); }
            } catch { fileStatus(0); MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingBlank.Value == 0) { tbStarsBlank.Value = 0; }
            else if (numRatingBlank.Value >= 1 && numRatingBlank.Value <= 31) { tbStarsBlank.Value = 1; }
            else if (numRatingBlank.Value >= 32 && numRatingBlank.Value <= 95) { tbStarsBlank.Value = 2; }
            else if (numRatingBlank.Value >= 96 && numRatingBlank.Value <= 159) { tbStarsBlank.Value = 3; }
            else if (numRatingBlank.Value >= 160 && numRatingBlank.Value <= 223) { tbStarsBlank.Value = 4; }
            else if (numRatingBlank.Value >= 224 && numRatingBlank.Value <= 255) { tbStarsBlank.Value = 5; }
        }

        private void tbStarsBlank_Scroll(object sender, EventArgs e)
        {
            switch (tbStarsBlank.Value)
            {
                case 0:
                    numRatingBlank.Value = 0;
                    break;
                case 1:
                    numRatingBlank.Value = 31;
                    break;
                case 2:
                    numRatingBlank.Value = 95;
                    break;
                case 3:
                    numRatingBlank.Value = 159;
                    break;
                case 4:
                    numRatingBlank.Value = 223;
                    break;
                case 5:
                    numRatingBlank.Value = 225;
                    break;
            }

        }

        private void bOpenPicture_Click(object sender, EventArgs e)
        {
            openFileDiPic.InitialDirectory = Settings.Default.ofdPic;
            if (openFileDiPic.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDiPic.FileName);
                Settings.Default.ofdPic = fInfo.DirectoryName;
                pBoxAlbum.BackgroundImage = new Bitmap(openFileDiPic.FileName);
                albumArtworkURL = openFileDiPic.FileName;
                lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height;
            }
        }

        private void tFileChanged_Tick(object sender, EventArgs e) { if (Checker("album") == true || Checker("albumArtist") == true || Checker("artist") == true || Checker("composers") == true || Checker("fileName") == true || Checker("genres") == true || Checker("title") == true || Checker("year") == true || Checker("track") == true || Checker("rating") == true || Checker("albumArtwork") == true || Checker("disk") == true || Checker("remixer") == true) { fileStatus(3); tsbCloseFile.Enabled = false; } else { fileStatus(2); tsbCloseFile.Enabled = true; } }

        Boolean Checker(String stringTag)
        {
            var musFileTag = TagLib.File.Create(musFileName).Tag;
            bool returningValue = false;

            switch (stringTag)
            {
                case "album":
                    if (chbAlbum.Checked == true && tbAlbum.Text != musFileTag.Album) { returningValue = true; }
                    break;
                case "albumArtist":
                    if (chbAlbumArtists.Checked == true && tbAlbumArtist.Text != string.Join("|", musFileTag.AlbumArtists)) { returningValue = true; }
                    break;
                case "artist":
                    if (tbArtist.Text != string.Join("|", musFileTag.Performers)) { returningValue = true; }
                    break;
                case "composers":
                    if (chbComposers.Checked == true && tbComposer.Text != string.Join("|", musFileTag.Composers)) { returningValue = true; }
                    break;
                case "fileName":
                    if (tbFileName.Text != musFileSName) { returningValue = true; }
                    break;
                case "genres":
                    if (chbGenres.Checked == true && tbGenre.Text != string.Join("|", musFileTag.Genres)) { returningValue = true; }
                    break;
                case "title":
                    if (tbTitle.Text != musFileTag.Title) { returningValue = true; }
                    break;
                case "year":
                    if (chbYear.Checked == true && numDate.Value != musFileTag.Year) { returningValue = true; }
                    break;
                case "track":
                    if (chbTrack.Checked == true && numTrackNumber.Value != musFileTag.Track) { returningValue = true; }
                    break;
                case "rating":
                    if (numRatingBlank.Value != TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)TagLib.File.Create(musFileName).GetTag(TagLib.TagTypes.Id3v2), "", true).Rating || numRatingSpotify.Value != TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)TagLib.File.Create(musFileName).GetTag(TagLib.TagTypes.Id3v2), "open.spotify.com", true).Rating || numRatingYouTube.Value != TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)TagLib.File.Create(musFileName).GetTag(TagLib.TagTypes.Id3v2), "youtube.com", true).Rating || numRatingSoundcloud.Value != TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)TagLib.File.Create(musFileName).GetTag(TagLib.TagTypes.Id3v2), "soundcloud.com", true).Rating) { returningValue = true; }
                    break;
                case "albumArtwork":
                    if (albumArtworkURL != "Album artwork♪") { returningValue = true; }
                    break;
                case "disk":
                    if (chbDisk.Checked == true && numDiscNumber.Value != musFileTag.Disc) { returningValue = true; }
                    break;
                case "remixer":
                    if (chbRemixer.Checked == true && tbRemixer.Text != musFileTag.RemixedBy) { returningValue = true; }
                    break;
            }
            return returningValue;
        }

        private void Form1_Load(object sender, EventArgs e) { this.Location = Settings.Default.lastPos; fileStatus(0); pBoxAlbum.AllowDrop = true; numDate.Value = DateTime.Today.Year; tsbCloseFile.Enabled = false; albumArtworkURL = "null♪"; CreateExtend(); if (_args.Length > 0)
            {
                if (System.IO.File.Exists(_args[0]) && new System.IO.FileInfo(_args[0]).Extension == ".mp3") { loadMusic(_args[0]); }
                else if (System.IO.File.Exists(_args[0]) && new System.IO.FileInfo(_args[0]).Extension == ".templ") { loadTemplate(_args[0]); }
            }
        }

        private void numRatingSpotify_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingSpotify.Value == 0) { tbStarsSpotify.Value = 0; }
            else if (numRatingSpotify.Value >= 1 && numRatingSpotify.Value <= 31) { tbStarsSpotify.Value = 1; }
            else if (numRatingSpotify.Value >= 32 && numRatingSpotify.Value <= 95) { tbStarsSpotify.Value = 2; }
            else if (numRatingSpotify.Value >= 96 && numRatingSpotify.Value <= 159) { tbStarsSpotify.Value = 3; }
            else if (numRatingSpotify.Value >= 160 && numRatingSpotify.Value <= 223) { tbStarsSpotify.Value = 4; }
            else if (numRatingSpotify.Value >= 224 && numRatingSpotify.Value <= 255) { tbStarsSpotify.Value = 5; }
        }

        private void numRatingYouTube_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingYouTube.Value == 0) { tbStarsYouTube.Value = 0; }
            else if (numRatingYouTube.Value >= 1 && numRatingYouTube.Value <= 31) { tbStarsYouTube.Value = 1; }
            else if (numRatingYouTube.Value >= 32 && numRatingYouTube.Value <= 95) { tbStarsYouTube.Value = 2; }
            else if (numRatingYouTube.Value >= 96 && numRatingYouTube.Value <= 159) { tbStarsYouTube.Value = 3; }
            else if (numRatingYouTube.Value >= 160 && numRatingYouTube.Value <= 223) { tbStarsYouTube.Value = 4; }
            else if (numRatingYouTube.Value >= 224 && numRatingYouTube.Value <= 255) { tbStarsYouTube.Value = 5; }
        }

        private void numRatingYouTubeMusic_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingYouTubeMusic.Value == 0) { tbStarsYouTubeMusic.Value = 0; }
            else if (numRatingYouTubeMusic.Value >= 1 && numRatingYouTubeMusic.Value <= 31) { tbStarsYouTubeMusic.Value = 1; }
            else if (numRatingYouTubeMusic.Value >= 32 && numRatingYouTubeMusic.Value <= 95) { tbStarsYouTubeMusic.Value = 2; }
            else if (numRatingYouTubeMusic.Value >= 96 && numRatingYouTubeMusic.Value <= 159) { tbStarsYouTubeMusic.Value = 3; }
            else if (numRatingYouTubeMusic.Value >= 160 && numRatingYouTubeMusic.Value <= 223) { tbStarsYouTubeMusic.Value = 4; }
            else if (numRatingYouTubeMusic.Value >= 224 && numRatingYouTubeMusic.Value <= 255) { tbStarsYouTubeMusic.Value = 5; }
        }

        private void numRatingSoundcloud_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingSoundcloud.Value == 0) { tbStarsSoundcloud.Value = 0; }
            else if (numRatingSoundcloud.Value >= 1 && numRatingSoundcloud.Value <= 31) { tbStarsSoundcloud.Value = 1; }
            else if (numRatingSoundcloud.Value >= 32 && numRatingSoundcloud.Value <= 95) { tbStarsSoundcloud.Value = 2; }
            else if (numRatingSoundcloud.Value >= 96 && numRatingSoundcloud.Value <= 159) { tbStarsSoundcloud.Value = 3; }
            else if (numRatingSoundcloud.Value >= 160 && numRatingSoundcloud.Value <= 223) { tbStarsSoundcloud.Value = 4; }
            else if (numRatingSoundcloud.Value >= 224 && numRatingSoundcloud.Value <= 255) { tbStarsSoundcloud.Value = 5; }
        }

        private void tbStarsSpotify_Scroll(object sender, EventArgs e)
        {
            switch (tbStarsSpotify.Value)
            {
                case 0:
                    numRatingSpotify.Value = 0;
                    break;
                case 1:
                    numRatingSpotify.Value = 31;
                    break;
                case 2:
                    numRatingSpotify.Value = 95;
                    break;
                case 3:
                    numRatingSpotify.Value = 159;
                    break;
                case 4:
                    numRatingSpotify.Value = 223;
                    break;
                case 5:
                    numRatingSpotify.Value = 225;
                    break;
            }
        }

        private void tbStarsYouTube_Scroll(object sender, EventArgs e)
        {
            switch (tbStarsYouTube.Value)
            {
                case 0:
                    numRatingYouTube.Value = 0;
                    break;
                case 1:
                    numRatingYouTube.Value = 31;
                    break;
                case 2:
                    numRatingYouTube.Value = 95;
                    break;
                case 3:
                    numRatingYouTube.Value = 159;
                    break;
                case 4:
                    numRatingYouTube.Value = 223;
                    break;
                case 5:
                    numRatingYouTube.Value = 225;
                    break;
            }
        }

        private void tbStarsSoundcloud_Scroll(object sender, EventArgs e)
        {
            switch (tbStarsSoundcloud.Value)
            {
                case 0:
                    numRatingSoundcloud.Value = 0;
                    break;
                case 1:
                    numRatingSoundcloud.Value = 31;
                    break;
                case 2:
                    numRatingSoundcloud.Value = 95;
                    break;
                case 3:
                    numRatingSoundcloud.Value = 159;
                    break;
                case 4:
                    numRatingSoundcloud.Value = 223;
                    break;
                case 5:
                    numRatingSoundcloud.Value = 225;
                    break;
            }
        }

        private void tssbSave_ButtonClick(object sender, EventArgs e)
        {
            if (tbFileName.Text != "")
            {
                tFileChanged.Stop();

                trimTextBoxes(tbFileName); trimTextBoxes(tbArtist); trimTextBoxes(tbTitle); trimTextBoxes(tbAlbum); trimTextBoxes(tbGenre); trimTextBoxes(tbAlbumArtist); trimTextBoxes(tbComposer); trimTextBoxes(tbRemixer); trimTextBoxes(tbFileName);

                TagLib.Id3v2.Tag.DefaultVersion = 3;
                TagLib.Id3v2.Tag.ForceDefaultVersion = true;
                TagLib.Id3v2.Tag.UseNumericGenres = false;
                TagLib.File musFile = TagLib.File.Create(musFileName);

                if (albumArtworkURL != "Album artwork♪" && albumArtworkURL != "null♪") { musFile.Tag.Pictures = new TagLib.IPicture[] { new TagLib.Picture(new TagLib.ByteVector((byte[])new ImageConverter().ConvertTo(System.Drawing.Image.FromFile(albumArtworkURL), typeof(byte[])))) }; albumArtworkURL = "Album artwork♪"; }
                else if (albumArtworkURL == "null♪") { musFile.Tag.Pictures = null; }

                musFile.Tag.Performers = tbArtist.Text.Split('|');
                musFile.Tag.Title = tbTitle.Text;
                if (chbAlbum.Checked == true) { musFile.Tag.Album = tbAlbum.Text; }
                if (chbYear.Checked == true) { musFile.Tag.Year = Convert.ToUInt32(numDate.Value); }
                if (chbTrack.Checked == true) { musFile.Tag.Track = Convert.ToUInt32(numTrackNumber.Value); }
                if (chbDisk.Checked == true) { musFile.Tag.Disc = Convert.ToUInt32(numDiscNumber.Value); }
                if (chbGenres.Checked == true) { musFile.Tag.Genres = tbGenre.Text.Split('|'); }
                if (chbAlbumArtists.Checked == true) { musFile.Tag.AlbumArtists = tbAlbumArtist.Text.Split('|'); }
                if (chbComposers.Checked == true) { musFile.Tag.Composers = tbComposer.Text.Split('|'); }
                if (chbRemixer.Checked == true) { musFile.Tag.RemixedBy = tbRemixer.Text; }

                if (numRatingBlank.Value != 0) { TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "", true).Rating = Convert.ToByte(numRatingBlank.Value); }
                if (numRatingSpotify.Value != 0) { TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "open.spotify.com", true).Rating = Convert.ToByte(numRatingSpotify.Value); }
                if (numRatingYouTube.Value != 0) { TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "youtube.com", true).Rating = Convert.ToByte(numRatingYouTube.Value); }
                if (numRatingSoundcloud.Value != 0) { TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "soundcloud.com", true).Rating = Convert.ToByte(numRatingSoundcloud.Value); }

                musFile.RemoveTags(TagTypes.Id3v1);
                musFile.Save();

                if (tbFileName.Text != musFileSName && !tbFileName.Text.Contains("\\") && !tbFileName.Text.Contains("/") && !tbFileName.Text.Contains(":") && !tbFileName.Text.Contains("*") && !tbFileName.Text.Contains("?") && !tbFileName.Text.Contains(Char.ToString('"')) && !tbFileName.Text.Contains("<") && !tbFileName.Text.Contains(">") && !tbFileName.Text.Contains("|"))
                {
                    trimTextBoxes(tbFileName);
                    System.IO.File.Move(musFilePath + musFileSName, musFilePath + tbFileName.Text);
                    musFileSName = tbFileName.Text;
                    musFileName = musFilePath + musFileSName;
                }

                tFileChanged.Start();
            }
            else if (tbFileName.Text == "") { MessageBox.Show("Enter file name.", "Invalid file name", MessageBoxButtons.OK, MessageBoxIcon.Error); tbFileName.Text = musFileSName; }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (tbFileName.Text != "")
            {
                saveFileDiMP3.InitialDirectory = Settings.Default.sfdMp3;
                if (tbFileName.Text != musFileSName) { saveFileDiMP3.FileName = tbFileName.Text; }
                try {
                    if (saveFileDiMP3.ShowDialog() == DialogResult.OK)
                    {
                        trimTextBoxes(tbFileName); trimTextBoxes(tbArtist); trimTextBoxes(tbTitle); trimTextBoxes(tbAlbum); trimTextBoxes(tbGenre); trimTextBoxes(tbAlbumArtist); trimTextBoxes(tbComposer); trimTextBoxes(tbRemixer);


                        TagLib.Id3v2.Tag.DefaultVersion = 3;
                        TagLib.Id3v2.Tag.ForceDefaultVersion = true;
                        TagLib.Id3v2.Tag.UseNumericGenres = false;

                        Settings.Default.sfdMp3 = new System.IO.FileInfo(saveFileDiMP3.FileName).DirectoryName;
                        if (!System.IO.File.Exists(saveFileDiMP3.FileName)) { System.IO.File.Copy(musFileName, saveFileDiMP3.FileName); }
                        TagLib.File musFile = TagLib.File.Create(saveFileDiMP3.FileName);

                        if (albumArtworkURL != "Album artwork♪" && albumArtworkURL != "null♪") { musFile.Tag.Pictures = new TagLib.IPicture[] { new TagLib.Picture(new TagLib.ByteVector((byte[])new ImageConverter().ConvertTo(System.Drawing.Image.FromFile(albumArtworkURL), typeof(byte[])))) }; albumArtworkURL = "Album artwork♪"; }
                        else if (albumArtworkURL == "null♪") { musFile.Tag.Pictures = null; }

                        musFile.Tag.Performers = tbArtist.Text.Split('|');
                        musFile.Tag.Title = tbTitle.Text;
                        if (chbAlbum.Checked == true) { musFile.Tag.Album = tbAlbum.Text; }
                        if (chbYear.Checked == true) { musFile.Tag.Year = Convert.ToUInt32(numDate.Value); }
                        if (chbTrack.Checked == true) { musFile.Tag.Track = Convert.ToUInt32(numTrackNumber.Value); }
                        if (chbDisk.Checked == true) { musFile.Tag.Disc = Convert.ToUInt32(numDiscNumber.Value); }
                        if (chbGenres.Checked == true) { musFile.Tag.Genres = tbGenre.Text.Split('|'); }
                        if (chbAlbumArtists.Checked == true) { musFile.Tag.AlbumArtists = tbAlbumArtist.Text.Split('|'); }
                        if (chbComposers.Checked == true) { musFile.Tag.Composers = tbComposer.Text.Split('|'); }
                        if (chbRemixer.Checked == true) { musFile.Tag.RemixedBy = tbRemixer.Text; }

                        if (numRatingBlank.Value != 0) { TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "", true).Rating = Convert.ToByte(numRatingBlank.Value); }
                        if (numRatingSpotify.Value != 0) { TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "open.spotify.com", true).Rating = Convert.ToByte(numRatingSpotify.Value); }
                        if (numRatingYouTube.Value != 0) { TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "youtube.com", true).Rating = Convert.ToByte(numRatingYouTube.Value); }
                        if (numRatingSoundcloud.Value != 0) { TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "soundcloud.com", true).Rating = Convert.ToByte(numRatingSoundcloud.Value); }

                        musFile.RemoveTags(TagTypes.Id3v1);
                        musFile.Save();
                    }
                    else if (tbFileName.Text == "") { MessageBox.Show("Enter file name.", "Invalid file name", MessageBoxButtons.OK, MessageBoxIcon.Error); tbFileName.Text = musFileSName; }
                    } catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
        }

        private void tsmiSaveTemplate_Click(object sender, EventArgs e)
        {
            saveFileDiTempl.InitialDirectory = Settings.Default.sfdTempl;
            try {
                if (saveFileDiTempl.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.sfdTempl = new System.IO.FileInfo(saveFileDiTempl.FileName).DirectoryName;
                    if (saveFileDiTempl.FileName != "")
                    {
                        string[] inputing = { tbArtist.Text, tbTitle.Text, tbAlbum.Text, numDate.Value.ToString(), numTrackNumber.Value.ToString(), numDiscNumber.Value.ToString(), tbGenre.Text, tbAlbumArtist.Text, tbComposer.Text, tbRemixer.Text, numRatingBlank.Value.ToString(), numBlankMaxStars.Value.ToString(), numRatingSpotify.Value.ToString(), numSpotifyMaxPlays.Value.ToString(), numRatingYouTube.Value.ToString(), numRatingSoundcloud.Value.ToString(), "", "" };
                        if (albumArtworkURL == "null♪") { inputing[16] = "null"; } else if (albumArtworkURL == "Album artwork♪") { inputing[16] = ""; } else if (albumArtworkURL != "null♪" && albumArtworkURL != "Album artwork♪") { inputing[16] = "custom"; inputing[17] = albumArtworkURL; }

                        System.IO.File.WriteAllLines(saveFileDiTempl.FileName, inputing);
                    } }
            } catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsmiSaveImage_Click(object sender, EventArgs e)
        {
            var musFileTag = TagLib.File.Create(musFileName).Tag;
            if (musFileName != null && musFileTag.Pictures.Length >= 1)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        Bitmap bmp = new Bitmap(Image.FromStream(new MemoryStream(musFileTag.Pictures[0].Data.Data)));
                        bmp.Save(ms, ImageFormat.Png);
                        byte[] bytes = ms.ToArray();
                        System.IO.File.WriteAllBytes(Path.Combine(musFilePath,tbAlbum.Text + ".png"), bytes);
                    } catch { MessageBox.Show("An error occured. Cannot save into already existing file.", "File already exists", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void pBoxAlbum_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) { 
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Path.GetExtension(files[0]) == ".mp3") { loadMusic(files[0]); }
                else if (Path.GetExtension(files[0]) == ".templ") { loadTemplate(files[0]); }
                else if (Path.GetExtension(files[0]) == ".jpg" | Path.GetExtension(files[0]) == ".png" | Path.GetExtension(files[0]) == ".bmp")
                {
                    System.IO.FileInfo fInfo = new System.IO.FileInfo(files[0]);
                    Settings.Default.ofdPic = fInfo.DirectoryName;
                    pBoxAlbum.BackgroundImage = new Bitmap(files[0]);
                    albumArtworkURL = files[0];
                    lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height;
                }
            }
        }
        private void pBoxAlbum_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.Copy; }

        private void pBoxAlbum_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    if (musFileName != null)
                    {
                        var musFileTag = TagLib.File.Create(musFileName).Tag;
                        if (musFileTag.Pictures.Length >= 1)
                        {
                            pBoxAlbum.BackgroundImage = Image.FromStream(new MemoryStream(musFileTag.Pictures[0].Data.Data));
                            lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height;
                            albumArtworkURL = "Album artwork♪";
                        }
                        else { pBoxAlbum.BackgroundImage = Resources.generic_music_file_100px; lResulution.Text = "null"; }
                    }
                    break;
            }
        }

        private void pBoxAlbum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        pBoxAlbum.BackgroundImage = Resources.generic_music_file_100px;
                        lResulution.Text = "null";
                        albumArtworkURL = "null♪";
                    }
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { Settings.Default.lastPos = this.Location; Settings.Default.Save(); }

        private void tsbCloseFile_Click(object sender, EventArgs e)
        {
            if (tslChanges.Text == "No changes")
            {
                tFileChanged.Stop();
                albumArtworkURL = "null♪";
                musFileSName = null;
                musFilePath = null;
                musFileName = null;
                pBoxAlbum.BackgroundImage = Resources.generic_music_file_100px;
                lResulution.Text = "null";
                tbFileName.Text = null;
                tbArtist.Text = null;
                tbTitle.Text = null;
                tbAlbum.Text = null;
                numDate.Value = DateTime.Today.Year;
                numTrackNumber.Value = 1;
                numDiscNumber.Value = 1;
                tbGenre.Text = null;
                tbAlbumArtist.Text = null;
                tbComposer.Text = null;
                tbRemixer.Text = null;
                numRatingBlank.Value = 0;
                numRatingSpotify.Value = 0;
                numRatingYouTube.Value = 0;
                numRatingSoundcloud.Value = 0;

                chbAlbum.Checked = true;
                chbYear.Checked = true;
                chbTrack.Checked = true;
                chbDisk.Checked = false;
                chbGenres.Checked = true;
                chbAlbumArtists.Checked = false;
                chbComposers.Checked = false;
                chbRemixer.Checked = false;

                fileStatus(0);
                tsbCloseFile.Enabled = false;
            }
        }

        private void bFileFromTags_Click(object sender, EventArgs e) { if (musFileName != null) { trimTextBoxes(tbArtist); trimTextBoxes(tbTitle); tbFileName.Text = tbArtist.Text.Split('|')[0] + " - " + tbTitle.Text + ".mp3"; foreach (var c in Path.GetInvalidFileNameChars()) { tbFileName.Text = tbFileName.Text.Replace(c, '_'); } tbFileName.Text = tbFileName.Text.Replace("'", ""); tbFileName.Text = tbFileName.Text.Replace(',', '_'); tbFileName.Text = tbFileName.Text.Replace('[', '('); tbFileName.Text = tbFileName.Text.Replace(']', ')'); } }
        private void numDate_Leave(object sender, EventArgs e) { if (numDate.Text == "") { numDate.Value = DateTime.Today.Year; numDate.Text = Convert.ToString(DateTime.Today.Year); } }
        private void trimTextBoxes(System.Windows.Forms.TextBox tb) { tb.Text = tb.Text.Trim(); }
        void spotifyLikeCalculator(NumericUpDown current, NumericUpDown maximum, NumericUpDown returning) { decimal val = (current.Value / maximum.Value) * 255; returning.Value = Math.Round(val, 1, MidpointRounding.AwayFromZero); }
        void youtubeCalculator(NumericUpDown likes, NumericUpDown dislikes, NumericUpDown returning) { decimal val = (likes.Value / (dislikes.Value + likes.Value)) * 255; returning.Value = Math.Round(val, 1, MidpointRounding.AwayFromZero); }
        void soundcloudCalculator(NumericUpDown plays, NumericUpDown likes, NumericUpDown reposts, NumericUpDown returning) { decimal val = ((likes.Value + reposts.Value) / plays.Value) * 255; returning.Value = Math.Round(val, 1, MidpointRounding.AwayFromZero); }
        private void numBlank_ValueChanged(object sender, EventArgs e) { spotifyLikeCalculator(numBlankStars, numBlankMaxStars, numRatingBlank); }
        private void numSpotify_ValueChanged(object sender, EventArgs e) { numSpotifyPlays.Maximum = numSpotifyMaxPlays.Value; if (numSpotifyPlays.Value > numSpotifyMaxPlays.Value) numSpotifyPlays.Value = numSpotifyMaxPlays.Value; spotifyLikeCalculator(numSpotifyPlays, numSpotifyMaxPlays, numRatingSpotify); if (numRatingSpotify.Value == 0 && numSpotifyPlays.Value != 0) { numRatingSpotify.Value = 1; } if (numSpotifyMaxPlays.Value == 0) { numSpotifyPlays.Enabled = false; } else { numSpotifyPlays.Enabled = true; } }
        private void numYT_ValueChanged(object sender, EventArgs e) { youtubeCalculator(numYTLikes, numYTDislikes, numRatingYouTube); }
        private void numYTM_ValueChanged(object sender, EventArgs e) { youtubeCalculator(numYTMLikes, numYTMDislikes, numRatingYouTubeMusic); }
        private void numSC_ValueChanged(object sender, EventArgs e) { soundcloudCalculator(numSCPlays, numSCLikes, numSCRepost, numRatingSoundcloud); }
        private void tDontNull_Tick(object sender, EventArgs e) { if (numBlankMaxStars.Value == 0) { numBlankStars.Enabled = false; } else { numBlankStars.Enabled = true; } if (numSCPlays.Value == 0) { numSCLikes.Enabled = false; numSCRepost.Enabled = false; } else { numSCLikes.Enabled = true; numSCRepost.Enabled = true; } }

        private void tsbOpenTempl_Click(object sender, EventArgs e)
        {
            openFileDiTempl.InitialDirectory = Settings.Default.ofdTempl;
            try { if (openFileDiTempl.ShowDialog() == DialogResult.OK) { loadTemplate(openFileDiTempl.FileName); } }
            catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift)
            {
                if (e.KeyCode == Keys.O)
                {
                    e.SuppressKeyPress = true; BeginInvoke(new Action(() => tsbOpenTempl.PerformClick()));
                }
                else if (e.KeyCode == Keys.S)
                {
                    e.SuppressKeyPress = true; BeginInvoke(new Action(() => tsmiSaveAs.PerformClick()));
                }
            }
            else if (e.Control && e.Alt)
            {
                if (e.KeyCode == Keys.O)
                {
                    e.SuppressKeyPress = true; BeginInvoke(new Action(() => bOpenPicture.PerformClick()));
                }
                else if (e.KeyCode == Keys.S)
                {
                    e.SuppressKeyPress = true; BeginInvoke(new Action(() => tsmiSaveTemplate.PerformClick()));
                }
                else if (e.KeyCode == Keys.F6)
                {
                    e.SuppressKeyPress = true; this.Location= new Point(0, 0);
                }
            }
            else if (e.Control)
            {
                if (e.KeyCode == Keys.O)
                {
                    e.SuppressKeyPress = true; BeginInvoke(new Action(() => tsbOpenMP3.PerformClick()));
                }
                else if (e.KeyCode == Keys.S)
                {
                    e.SuppressKeyPress = true; BeginInvoke(new Action(() => tsmiSave.PerformClick()));
                }
                else if (e.KeyCode == Keys.W)
                {
                    e.SuppressKeyPress = true; BeginInvoke(new Action(() => tsbCloseFile.PerformClick()));
                }
                else if (e.KeyCode == Keys.D)
                {
                    e.SuppressKeyPress = true; BeginInvoke(new Action(() => bFileFromTags.PerformClick()));
                }
            }
        }
        
        private void CreateExtend()
        {
            string appName = "Titel";
            string exePath = string.Format("\"{0}\"", Application.ExecutablePath);
            string exeName = System.AppDomain.CurrentDomain.FriendlyName;

            Registry.CurrentUser.CreateSubKey(".templ").SetValue("", appName);
            Registry.CurrentUser.CreateSubKey(appName + @"\DefaultIcon").SetValue("", exePath);
            Registry.CurrentUser.CreateSubKey(appName + @"\shell\open\command").SetValue("", exePath + "\"%1\"");
            Registry.CurrentUser.CreateSubKey(appName + @"\shell\open\command").SetValue("", exePath + "\"%1\"");
            Registry.CurrentUser.CreateSubKey(string.Format(@"Applications\{0}\shell\open\command", exeName)).SetValue("", exePath + "\"%1\"");
            Registry.CurrentUser.CreateSubKey(string.Format(@"Applications\{0}\shell\edit\command", exeName)).SetValue("", exePath + "\"%1\"");

            Registry.CurrentUser.CreateSubKey(".mp3").SetValue("", appName);
            Registry.CurrentUser.CreateSubKey(appName + @"\DefaultIcon").SetValue("", exePath);
            Registry.CurrentUser.CreateSubKey(appName + @"\shell\open\command").SetValue("", exePath + "\"%1\"");
            Registry.CurrentUser.CreateSubKey(appName + @"\shell\open\command").SetValue("", exePath + "\"%1\"");
            Registry.CurrentUser.CreateSubKey(string.Format(@"Applications\{0}\shell\open\command", exeName)).SetValue("", exePath + "\"%1\"");
            Registry.CurrentUser.CreateSubKey(string.Format(@"Applications\{0}\shell\edit\command", exeName)).SetValue("", exePath + "\"%1\"");
        }
    
        void loadTemplate(string fileLoc)
        {
            Settings.Default.ofdTempl = new System.IO.FileInfo(fileLoc).DirectoryName;
            StreamReader reader = new StreamReader(fileLoc, System.Text.Encoding.Default);
            string[] inputing = reader.ReadToEnd().Split('\n');

            tbArtist.Text = inputing[0];
            tbTitle.Text = inputing[1];
            tbAlbum.Text = inputing[2];
            numDate.Value = Convert.ToDecimal(inputing[3]);
            numTrackNumber.Value = Convert.ToDecimal(inputing[4]);
            numDiscNumber.Value = Convert.ToDecimal(inputing[5]);
            tbGenre.Text = inputing[6];
            tbAlbumArtist.Text = inputing[7];
            tbComposer.Text = inputing[8];
            tbRemixer.Text = inputing[9];
            numRatingBlank.Value = Convert.ToDecimal(inputing[10]);
            numBlankMaxStars.Value = Convert.ToDecimal(inputing[11]);
            numRatingSpotify.Value = Convert.ToDecimal(inputing[12]);
            numSpotifyMaxPlays.Value = Convert.ToDecimal(inputing[13]);
            numRatingYouTube.Value = Convert.ToDecimal(inputing[14]);
            numRatingSoundcloud.Value = Convert.ToDecimal(inputing[15]);

            string picMode = inputing[16].ToString().Trim().ToLower();
            if (picMode == "null" || picMode == "empty") { pBoxAlbum.BackgroundImage = Resources.generic_music_file_100px; lResulution.Text = "null"; albumArtworkURL = "null♪"; }
            else if (picMode == "custom" || picMode == "my" || picMode == "file" || picMode == "own") { if (inputing[17].ToString().Trim().ToLower() != "") { pBoxAlbum.BackgroundImage = new Bitmap(inputing[17]); albumArtworkURL = inputing[17]; lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height; } else { pBoxAlbum.BackgroundImage = Resources.generic_music_file_100px; lResulution.Text = "null"; albumArtworkURL = "null♪"; } }
            else if (picMode == "skip" || picMode == "") { } else { }

            tbTitle.Focus();
        }
    
        void loadMusic(string fileLoc)
        {
            fileStatus(1);
            Settings.Default.ofdMp3 = new System.IO.FileInfo(fileLoc).DirectoryName;
            musFileName = new System.IO.FileInfo(fileLoc).FullName;
            musFileSName = new System.IO.FileInfo(fileLoc).Name;
            musFilePath = new System.IO.FileInfo(fileLoc).DirectoryName + "\\";

            TagLib.File musFile = TagLib.File.Create(fileLoc);

            if (musFile.Tag.Pictures.Length >= 1)
            {
                pBoxAlbum.BackgroundImage = Image.FromStream(new MemoryStream(musFile.Tag.Pictures[0].Data.Data));
                lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height;
            }
            else { pBoxAlbum.BackgroundImage = Resources.generic_music_file_100px; lResulution.Text = "null"; }
            albumArtworkURL = "Album artwork♪";

            tbFileName.Text = musFileSName;
            tbArtist.Text = string.Join("|", musFile.Tag.Performers);
            tbTitle.Text = musFile.Tag.Title;
            if (musFile.Tag.Album != "") { chbAlbum.Checked = true; } else { chbAlbum.Checked = false; }
            tbAlbum.Text = musFile.Tag.Album;
            if (musFile.Tag.Year != 0) { chbYear.Checked = true; } else { chbYear.Checked = false; }
            numDate.Value = musFile.Tag.Year;
            if (musFile.Tag.Track != 0) { chbTrack.Checked = true; } else { chbTrack.Checked = false; }
            numTrackNumber.Value = musFile.Tag.Track;
            if (musFile.Tag.Disc != 0) { chbDisk.Checked = true; } else { chbDisk.Checked = false; }
            numDiscNumber.Value = musFile.Tag.Disc;
            if (musFile.Tag.Genres.Length != 0) { chbGenres.Checked = true; } else { chbGenres.Checked = false; }
            tbGenre.Text = string.Join("|", musFile.Tag.Genres);
            if (musFile.Tag.AlbumArtists.Length != 0) { chbAlbumArtists.Checked = true; } else { chbAlbumArtists.Checked = false; }
            tbAlbumArtist.Text = string.Join("|", musFile.Tag.AlbumArtists);
            if (musFile.Tag.Composers.Length != 0) { chbComposers.Checked = true; } else { chbComposers.Checked = false; }
            tbComposer.Text = string.Join("|", musFile.Tag.Composers);
            if (musFile.Tag.RemixedBy != null) { chbRemixer.Checked = true; } else { chbRemixer.Checked = false; }
            tbRemixer.Text = musFile.Tag.RemixedBy;

            numRatingBlank.Value = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "", true).Rating;
            numRatingSpotify.Value = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "open.spotify.com", true).Rating;
            numRatingYouTube.Value = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "youtube.com", true).Rating;
            numRatingSoundcloud.Value = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)musFile.GetTag(TagLib.TagTypes.Id3v2), "soundcloud.com", true).Rating;

            fileStatus(2);
            tFileChanged.Start();
        }

        private void numSpotifyMaxPlays_Leave(object sender, EventArgs e) { if (numSpotifyMaxPlays.Value == 0) { numSpotifyPlays.Enabled = false; } else { numSpotifyPlays.Enabled = true; } }
    }
}
