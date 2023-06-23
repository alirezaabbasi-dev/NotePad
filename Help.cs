using System;
using System.Drawing;
using System.Windows.Forms;
using YP_NotePad;

namespace note_pad_yp
{
    public partial class helpFrm : Telerik.WinControls.UI.RadForm
    {
     

        public helpFrm()
        {
            InitializeComponent();
        }
        private void helpFrm_Load(object sender, EventArgs e)
        {
            MinimizeBox = false; MaximizeBox = false; ShowIcon = false; ShowInTaskbar = false;
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
