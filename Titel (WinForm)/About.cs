using System;
using System.Reflection;
using System.Windows.Forms;

namespace Titel_WinForm
{
    public partial class About : Form
    {
        public About() { InitializeComponent(); }
        private void pbIcon_Click(object sender, EventArgs e) { lbShortcuts.Items.Add("Lament"); }
        private void About_Load(object sender, EventArgs e) { lAbout.Text = $"Titel_WinForm\nver. {Assembly.GetExecutingAssembly().GetName().Version}\nTagLibSharp\nver. {Assembly.GetAssembly(typeof(TagLib.Tag)).GetName().Version}"; }
    }
}
