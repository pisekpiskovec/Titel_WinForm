using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using System.IO;
using Titel_WinFrorm.Properties;

namespace Titel__WinFrorm_
{
    public partial class Form1 : Form
    {
        string albumArtworkURL;

        public Form1() { InitializeComponent(); }

        private void fileStatus(int status)
        {
            Form1 wnF = new Form1();
            switch (status)
            {
                case 0:
                    tslChanges.Text = "File not loaded.";
                    wnF.Text = "Titel | File not loaded";
                    break;
                case 1:
                    tslChanges.Text = "File loading...";
                    wnF.Text = "Titel | File loading...";
                    break;
                case 2:
                    tslChanges.Text = "No changes";
                    break;
                case 3:
                    tslChanges.Text = "Unsaved change(s)";
                    break;
            }
        }

        public void tsbtnOpen_Click(object sender, EventArgs e)
        {
            tFileChanged.Stop();
            openFileDiMP3.InitialDirectory = Settings.Default.ofdMp3;
            fileStatus(1);
            if (openFileDiMP3.ShowDialog() == DialogResult.OK) {
                Settings.Default.ofdMp3 = new System.IO.FileInfo(openFileDiMP3.FileName).DirectoryName;
                TagLib.File musFile = TagLib.File.Create(openFileDiMP3.FileName);
                tbFileName.Text = openFileDiMP3.SafeFileName;

                if (musFile.Tag.Pictures.Length >= 1) {
                    pBoxAlbum.BackgroundImage = Image.FromStream(new MemoryStream(musFile.Tag.Pictures[0].Data.Data));
                    lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height;
                } else {
                    //pBoxAlbum.BackgroundImage = null; 
                    lResulution.Text = "null"; }
                albumArtworkURL = "Album artwork♪";

                tbArtist.Text = string.Join("|", musFile.Tag.Performers);
                tbTitle.Text = musFile.Tag.Title;
                tbAlbum.Text = musFile.Tag.Album;
                numDate.Value = musFile.Tag.Year;
                numTrackNumber.Value = musFile.Tag.Track;
                numDiscNumber.Value = musFile.Tag.Disc;
                tbGenre.Text = string.Join("|", musFile.Tag.Genres);
                tbAlbumArtist.Text = string.Join("|", musFile.Tag.AlbumArtists);
                tbComposer.Text = string.Join("|", musFile.Tag.Composers);

                TagLib.Tag tag123 = musFile.GetTag(TagLib.TagTypes.Id3v2);
                TagLib.Id3v2.PopularimeterFrame frameBlank = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, "", true);
                TagLib.Id3v2.PopularimeterFrame frameSpotify = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, "open.spotify.com", true);
                TagLib.Id3v2.PopularimeterFrame frameYouTube = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, "youtube.com", true);
                TagLib.Id3v2.PopularimeterFrame frameSoundcloud = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, "soundcloud.com", true);
                numRatingBlank.Value = frameBlank.Rating;
                numRatingSpotify.Value = frameSpotify.Rating;
                numRatingYouTube.Value = frameYouTube.Rating;
                numRatingSoundcloud.Value = frameSoundcloud.Rating;

                fileStatus(2);
                this.Text = "Titel | " + openFileDiMP3.SafeFileName;

                
            } 
            else {fileStatus(0); tFileChanged.Start(); }
        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {
            if(numRatingBlank.Value == 0){
                tbStarsBlank.Value = 0;
            }else if(numRatingBlank.Value >= 1 && numRatingBlank.Value <= 31)
            {
                tbStarsBlank.Value = 1;
            }else if (numRatingBlank.Value >= 32 && numRatingBlank.Value <= 95)
            {
                tbStarsBlank.Value = 2;
            }else if (numRatingBlank.Value >= 96 && numRatingBlank.Value <= 159)
            {
                tbStarsBlank.Value = 3;
            }else if (numRatingBlank.Value >= 160 && numRatingBlank.Value <= 223)
            {
                tbStarsBlank.Value = 4;
            }else if (numRatingBlank.Value >= 224 && numRatingBlank.Value <= 255)
            {
                tbStarsBlank.Value = 5;
            }
        }

        private void tbStarsBlank_Scroll(object sender, EventArgs e)
        {
            if(tbStarsBlank.Value == 0)
            {
                numRatingBlank.Value = 0;
            }else if (tbStarsBlank.Value == 1)
            {
                numRatingBlank.Value = 31;
            }else if (tbStarsBlank.Value == 2)
            {
                numRatingBlank.Value = 95;
            }
            else if (tbStarsBlank.Value == 3)
            {
                numRatingBlank.Value = 159;
            }
            else if (tbStarsBlank.Value == 4)
            {
                numRatingBlank.Value = 223;
            }
            else if (tbStarsBlank.Value == 5)
            {
                numRatingBlank.Value = 225;
            }
        }

        private void bOpenPicture_Click(object sender, EventArgs e)
        {
            openFileDiJPGPNG.InitialDirectory = Settings.Default.ofdPic;   
            if (openFileDiJPGPNG.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDiJPGPNG.FileName);
                Settings.Default.ofdPic = fInfo.DirectoryName;
                pBoxAlbum.BackgroundImage = new Bitmap(openFileDiJPGPNG.FileName);
                albumArtworkURL = openFileDiJPGPNG.FileName;
                lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height;
            }
        }

        private void tFileSelected_Tick(object sender, EventArgs e)
        {
            var musFileTag = TagLib.File.Create(openFileDiMP3.FileName).Tag;
            var musFile = TagLib.File.Create(openFileDiMP3.FileName);

            string[] musAlbumArtistArr = musFileTag.AlbumArtists;
            string musAlbumArtist = string.Join("|", musAlbumArtistArr);

            string[] musArtistArr = musFileTag.Performers;
            string musArtist = string.Join("|", musArtistArr);

            string[] musGenreArr = musFileTag.Genres;
            string musGenre = string.Join("|", musGenreArr);

            string[] musComposersArr = musFileTag.Composers;
            string musComposers = string.Join("|", musComposersArr);

            TagLib.Tag tag123 = musFile.GetTag(TagLib.TagTypes.Id3v2);
            var usrBlank = "";
            TagLib.Id3v2.PopularimeterFrame frameBlank = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrBlank, true);
            var usrSpotify = "open.spotify.com";
            TagLib.Id3v2.PopularimeterFrame frameSpotify = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrSpotify, true);
            var usrYouTube = "youtube.com";
            TagLib.Id3v2.PopularimeterFrame frameYouTube = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrYouTube, true);
            var usrSoundCloud = "soundcloud.com";
            TagLib.Id3v2.PopularimeterFrame frameSoundcloud = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrSoundCloud, true);

            if (tbAlbum.Text != musFileTag.Album || tbAlbumArtist.Text != musAlbumArtist || tbArtist.Text != musArtist || tbComposer.Text != musComposers || tbFileName.Text != openFileDiMP3.SafeFileName || tbGenre.Text != musGenre || tbTitle.Text != musFileTag.Title || numDate.Value != musFileTag.Year || numTrackNumber.Value != musFileTag.Track || numRatingBlank.Value != frameBlank.Rating || numRatingSpotify.Value != frameSpotify.Rating || numRatingYouTube.Value != frameYouTube.Rating || numRatingSoundcloud.Value != frameSoundcloud.Rating || albumArtworkURL != "Album artwork♪" || numDiscNumber.Value != musFile.Tag.Disc) {fileStatus(3); } else {fileStatus(2); }
        }

        private void Form1_Load(object sender, EventArgs e) {fileStatus(0); pBoxAlbum.AllowDrop = true; }

        private void numRatingSpotify_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingSpotify.Value == 0)
            {
                tbStarsSpotify.Value = 0;
            }
            else if (numRatingSpotify.Value >= 1 && numRatingSpotify.Value <= 31)
            {
                tbStarsSpotify.Value = 1;
            }
            else if (numRatingSpotify.Value >= 32 && numRatingSpotify.Value <= 95)
            {
                tbStarsSpotify.Value = 2;
            }
            else if (numRatingSpotify.Value >= 96 && numRatingSpotify.Value <= 159)
            {
                tbStarsSpotify.Value = 3;
            }
            else if (numRatingSpotify.Value >= 160 && numRatingSpotify.Value <= 223)
            {
                tbStarsSpotify.Value = 4;
            }
            else if (numRatingSpotify.Value >= 224 && numRatingSpotify.Value <= 255)
            {
                tbStarsSpotify.Value = 5;
            }
        }

        private void numRatingYouTube_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingYouTube.Value == 0)
            {
                tbStarsYouTube.Value = 0;
            }
            else if (numRatingYouTube.Value >= 1 && numRatingYouTube.Value <= 31)
            {
                tbStarsYouTube.Value = 1;
            }
            else if (numRatingYouTube.Value >= 32 && numRatingYouTube.Value <= 95)
            {
                tbStarsYouTube.Value = 2;
            }
            else if (numRatingYouTube.Value >= 96 && numRatingYouTube.Value <= 159)
            {
                tbStarsYouTube.Value = 3;
            }
            else if (numRatingYouTube.Value >= 160 && numRatingYouTube.Value <= 223)
            {
                tbStarsYouTube.Value = 4;
            }
            else if (numRatingYouTube.Value >= 224 && numRatingYouTube.Value <= 255)
            {
                tbStarsYouTube.Value = 5;
            }
        }

        private void numRatingSoundcloud_ValueChanged(object sender, EventArgs e)
        {
            if (numRatingSoundcloud.Value == 0)
            {
                tbStarsSoundcloud.Value = 0;
            }
            else if (numRatingSoundcloud.Value >= 1 && numRatingSoundcloud.Value <= 31)
            {
                tbStarsSoundcloud.Value = 1;
            }
            else if (numRatingSoundcloud.Value >= 32 && numRatingSoundcloud.Value <= 95)
            {
                tbStarsSoundcloud.Value = 2;
            }
            else if (numRatingSoundcloud.Value >= 96 && numRatingSoundcloud.Value <= 159)
            {
                tbStarsSoundcloud.Value = 3;
            }
            else if (numRatingSoundcloud.Value >= 160 && numRatingSoundcloud.Value <= 223)
            {
                tbStarsSoundcloud.Value = 4;
            }
            else if (numRatingSoundcloud.Value >= 224 && numRatingSoundcloud.Value <= 255)
            {
                tbStarsSoundcloud.Value = 5;
            }
        }

        private void tbStarsSpotify_Scroll(object sender, EventArgs e)
        {
            if (tbStarsSpotify.Value == 0)
            {
                numRatingSpotify.Value = 0;
            }
            else if (tbStarsSpotify.Value == 1)
            {
                numRatingSpotify.Value = 31;
            }
            else if (tbStarsSpotify.Value == 2)
            {
                numRatingSpotify.Value = 95;
            }
            else if (tbStarsSpotify.Value == 3)
            {
                numRatingSpotify.Value = 159;
            }
            else if (tbStarsSpotify.Value == 4)
            {
                numRatingSpotify.Value = 223;
            }
            else if (tbStarsSpotify.Value == 5)
            {
                numRatingSpotify.Value = 225;
            }
        }

        private void tbStarsYouTube_Scroll(object sender, EventArgs e)
        {
            if (tbStarsYouTube.Value == 0)
            {
                numRatingYouTube.Value = 0;
            }
            else if (tbStarsYouTube.Value == 1)
            {
                numRatingYouTube.Value = 31;
            }
            else if (tbStarsYouTube.Value == 2)
            {
                numRatingYouTube.Value = 95;
            }
            else if (tbStarsYouTube.Value == 3)
            {
                numRatingYouTube.Value = 159;
            }
            else if (tbStarsYouTube.Value == 4)
            {
                numRatingYouTube.Value = 223;
            }
            else if (tbStarsYouTube.Value == 5)
            {
                numRatingYouTube.Value = 225;
            }
        }

        private void tbStarsSoundcloud_Scroll(object sender, EventArgs e)
        {
            if (tbStarsSoundcloud.Value == 0)
            {
                numRatingSoundcloud.Value = 0;
            }
            else if (tbStarsSoundcloud.Value == 1)
            {
                numRatingSoundcloud.Value = 31;
            }
            else if (tbStarsSoundcloud.Value == 2)
            {
                numRatingSoundcloud.Value = 95;
            }
            else if (tbStarsSoundcloud.Value == 3)
            {
                numRatingSoundcloud.Value = 159;
            }
            else if (tbStarsSoundcloud.Value == 4)
            {
                numRatingSoundcloud.Value = 223;
            }
            else if (tbStarsSoundcloud.Value == 5)
            {
                numRatingSoundcloud.Value = 225;
            }
        }

        private void tssbSave_ButtonClick(object sender, EventArgs e)
        {
            if (tbFileName.Text != "")
            {
                tFileChanged.Stop();

                TagLib.Id3v2.Tag.DefaultVersion = 3;
                TagLib.Id3v2.Tag.ForceDefaultVersion = true;
                TagLib.Id3v2.Tag.UseNumericGenres = false;
                TagLib.File musFile = TagLib.File.Create(openFileDiMP3.FileName);

                if (albumArtworkURL != "Album artwork♪") { musFile.Tag.Pictures = new TagLib.IPicture[] { new TagLib.Picture(new TagLib.ByteVector((byte[])new ImageConverter().ConvertTo(System.Drawing.Image.FromFile(openFileDiJPGPNG.FileName), typeof(byte[])))) }; albumArtworkURL = "Album artwork♪"; }

                musFile.Tag.Performers = tbArtist.Text.Split('|');
                musFile.Tag.Title = tbTitle.Text;
                musFile.Tag.Album = tbAlbum.Text;
                musFile.Tag.Year = Convert.ToUInt32(numDate.Value);
                musFile.Tag.Track = Convert.ToUInt32(numTrackNumber.Value);
                musFile.Tag.Disc = Convert.ToUInt32(numDiscNumber.Value);
                musFile.Tag.Genres = tbGenre.Text.Split('|');
                musFile.Tag.AlbumArtists = tbAlbumArtist.Text.Split('|');
                musFile.Tag.Composers = tbComposer.Text.Split('|');

                TagLib.Tag tag123 = musFile.GetTag(TagLib.TagTypes.Id3v2);
                if (numRatingBlank.Value != 0) {var usrBlank = ""; TagLib.Id3v2.PopularimeterFrame frameBlank = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrBlank, numRatingBlank.Value != 0) ; frameBlank.Rating = Convert.ToByte(numRatingBlank.Value); }
                if (numRatingSpotify.Value != 0) {var usrSpotify = "open.spotify.com"; TagLib.Id3v2.PopularimeterFrame frameSpotify = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrSpotify, true); frameSpotify.Rating = Convert.ToByte(numRatingSpotify.Value); }
                if (numRatingYouTube.Value != 0) { var usrYouTube = "youtube.com"; TagLib.Id3v2.PopularimeterFrame frameYouTube = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrYouTube, true); frameYouTube.Rating = Convert.ToByte(numRatingYouTube.Value); }
                if (numRatingSoundcloud.Value != 0) {var usrSoundCloud = "soundcloud.com"; TagLib.Id3v2.PopularimeterFrame frameSoundcloud = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrSoundCloud, true); frameSoundcloud.Rating = Convert.ToByte(numRatingSoundcloud.Value); }

                musFile.RemoveTags(TagTypes.Id3v1);
                musFile.Save();

                if (tbFileName.Text != openFileDiMP3.SafeFileName)
                {
                    
                }

                tFileChanged.Start();
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            var musFileTag = TagLib.File.Create(openFileDiMP3.FileName).Tag;
            var musFile = TagLib.File.Create(openFileDiMP3.FileName);

            string[] musAlbumArtistArr = musFileTag.AlbumArtists;
            string musAlbumArtist = string.Join("|", musAlbumArtistArr);

            string[] musArtistArr = musFileTag.Performers;
            string musArtist = string.Join("|", musArtistArr);

            string[] musGenreArr = musFileTag.Genres;
            string musGenre = string.Join("|", musGenreArr);

            string[] musComposersArr = musFileTag.Composers;
            string musComposers = string.Join("|", musComposersArr);

            TagLib.Tag tag123 = musFile.GetTag(TagLib.TagTypes.Id3v2);
            var usrBlank = "";
            TagLib.Id3v2.PopularimeterFrame frameBlank = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrBlank, true);
            var usrSpotify = "open.spotify.com";
            TagLib.Id3v2.PopularimeterFrame frameSpotify = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrSpotify, true);
            var usrYouTube = "youtube.com";
            TagLib.Id3v2.PopularimeterFrame frameYouTube = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrYouTube, true);
            var usrSoundCloud = "soundcloud.com";
            TagLib.Id3v2.PopularimeterFrame frameSoundcloud = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)tag123, usrSoundCloud, true);
        }

        private void pBoxAlbum_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0) pBoxAlbum.BackgroundImage = Image.FromFile(fileNames[0]); albumArtworkURL = fileNames[0]; lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height;
            }
        }

        private void pBoxAlbum_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pBoxAlbum_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button) { 
                case MouseButtons.Right: 
                    {
                        if(pBoxAlbum.BackgroundImage != null)
                        {
                            var musFileTag = TagLib.File.Create(openFileDiMP3.FileName).Tag;
                            pBoxAlbum.BackgroundImage = System.Drawing.Image.FromStream(new MemoryStream(musFileTag.Pictures[0].Data.Data));
                            lResulution.Text = pBoxAlbum.BackgroundImage.Width + "x" + pBoxAlbum.BackgroundImage.Height;
                            albumArtworkURL = "Album artwork♪";
                        }
                    } break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
