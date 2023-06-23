using System;
using System.Text;
using System.Windows.Forms;

namespace YP_NotePad
{
    public partial class aboutFrm : Telerik.WinControls.UI.RadForm
    {
        public aboutFrm()
        {
            InitializeComponent();
        }

            private void About_Load(object sender, EventArgs e)
            {
                MinimizeBox = false;
                MaximizeBox = false;
            }

            private void githubBtn_Click(object sender, EventArgs e)
            {
              System.Diagnostics.Process.Start("https://github.com/alirezaabbasi-dev");
            }
            private void okBtn_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
