using System;
using System.Windows.Forms;

namespace YP_NotePad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool runed;

            System.Threading.Mutex mtx = new System.Threading.Mutex(true, "yp-ntpd-ver:--22.2.0.0", out runed);

            if (!runed)
            {
                notePad jh = new notePad();
               
                 jh.Refresh();
                //    RadMessageBox.ThemeName = flnt.ThemeName;

                // Telerik.WinControls.RadMessageBox.Show("The " + "YP Windows Manager(Laptop)" + " is running", "YP", MessageBoxButtons.OK);
                /*  if (RadMessageBox.ThemeName==flnt.ThemeName)
                  {
                      Form1 nv = new Form1();nv.Enabled = false; Form2 nv0 = new Form2();  nv0.Enabled = false;Form3 nv1 = new Form3();nv1.Enabled = false;
                    Form4 nv2 = new Form4();
                     nv2.Enabled = false;
                    Form5 nv3 = new Form5();nv3.Enabled = false;
                      Form6 nv4 = new Form6();
                       nv4.Enabled = false;






                  }*/
            }
            else
            {
                Application.Run(new notePad());
            }
        }
    }
}
