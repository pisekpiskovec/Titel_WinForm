using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Titel_WinForm.Properties;
using Titel__WinFrorm_;

namespace Titel_WinForm
{
    public partial class rating_calculator : Form
    {
        decimal starsBlank;
        decimal starsSpotify;
        decimal starsYT;
        decimal starsSC;

        Form1 f1 = new Form1();

        public rating_calculator() {InitializeComponent(); }

        void spotifyCalculator(NumericUpDown current, NumericUpDown maximum, Label resultLabel)
        {
            starsSpotify = (current.Value / maximum.Value) * 255;
            resultLabel.Text = "Result: " + starsSpotify;
        }

        void blankCalculator(NumericUpDown current, NumericUpDown maximum, Label resultLabel)
        {
            starsBlank = (current.Value / maximum.Value) * 255;
            resultLabel.Text = "Result: " + starsBlank;
        }
        void youtubeCalculator(NumericUpDown likes, NumericUpDown dislikes, Label resultLabel)
        {
            starsYT = (likes.Value / (dislikes.Value + likes.Value)) * 255;
            resultLabel.Text = "Result: " + starsYT;
        }
        void soundcloudCalculator(NumericUpDown plays, NumericUpDown likes, Label resultLabel)
        {
            starsSC = (likes.Value / plays.Value) * 255;
            resultLabel.Text = "Result: " + starsSC;
        }

        private void numSpotify_ValueChanged(object sender, EventArgs e) {spotifyCalculator(numSpotifyPlays, numSpotifyMaxPlays, lSpotifyResult); }
        private void numBlank_ValueChanged(object sender, EventArgs e) {blankCalculator(numBlankStars, numBlankMaxStars, lBlankResult); }
        private void numYT_ValueChanged(object sender, EventArgs e) {youtubeCalculator(numYTLikes, numYTDislikes, lYTResult); }
        private void numSC_ValueChanged(object sender, EventArgs e) { soundcloudCalculator(numSCPlays, numSCLikes, lSCResult); }
        private void tDontNull_Tick(object sender, EventArgs e) {if (numBlankMaxStars.Value == 0) { numBlankStars.Enabled = false; } else { numBlankStars.Enabled = true; } if (numSpotifyMaxPlays.Value == 0) { numSpotifyPlays.Enabled = false; } else { numSpotifyPlays.Enabled = true; } if (numSCPlays.Value == 0) { numSCLikes.Enabled = false; } else { numSCLikes.Enabled = true; } }
        private void bBlankPaste_Click(object sender, EventArgs e) {f1.numRatingBlank.Value = starsBlank; }
        private void bSpotifyPaste_Click(object sender, EventArgs e) {f1.numRatingSpotify.Value = starsSpotify; }
        private void bYTPaste_Click(object sender, EventArgs e) {f1.numRatingYouTube.Value = starsYT; }
        private void bSCPaste_Click(object sender, EventArgs e) {f1.numRatingSoundcloud.Value = starsSC; }
    }
}
