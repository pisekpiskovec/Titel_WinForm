using System;
using System.Reflection;
using System.Windows.Forms;

namespace Titel_WinForm
{
    public partial class About : Form
    {
        public About() { InitializeComponent(); rbTemplRevA.Checked = Properties.Settings.Default.templYTMSupport; rbTempl.Checked = !rbTemplRevA.Checked; }
        private void pbIcon_Click(object sender, EventArgs e) { lbShortcuts.Items.Add("Lament"); }
        private void About_Load(object sender, EventArgs e) { lAbout.Text = $"Titel_WinForm\nver. {Assembly.GetExecutingAssembly().GetName().Version}\nTagLibSharp\nver. {Assembly.GetAssembly(typeof(TagLib.Tag)).GetName().Version}"; }
        private void About_FormClosing(object sender, FormClosingEventArgs e) { Properties.Settings.Default.Save(); }
        private void rbTemplRevA_CheckedChanged(object sender, EventArgs e) { Properties.Settings.Default.templYTMSupport = rbTemplRevA.Checked; }
    }
}
