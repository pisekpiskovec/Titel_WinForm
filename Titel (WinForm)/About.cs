using System;
using System.Windows.Forms;

namespace Titel_WinForm
{
    public partial class About : Form
    {
        public About() { InitializeComponent(); }
        private void pbIcon_Click(object sender, EventArgs e) { lbShortcuts.Items.Add("Lament"); }
    }
}
