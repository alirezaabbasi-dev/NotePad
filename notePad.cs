﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using note_pad_yp;
using MetroFramework;

namespace YP_NotePad
{
    public partial class notePad : Telerik.WinControls.UI.RadForm
    {
        public notePad()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInput.BackColor = colorDialog1.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInput.ForeColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void notePad_Load(object sender, EventArgs e)
        {
            if (panelSave.Visible == true)
            {
                Menu.Enabled = false;
            }
            {
                {
                    if (panelSave.Visible == true)
                    {
                        this.Enabled = false;
                    }
                    else
                        this.Enabled = true;
                    ControlBox = true;
                    if (txtInput.BackColor == Color.White)
                    {
                        //whiteModeToolStripMenuItem.Enabled = false;
                    }


                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dgr;
            dgr = MetroFramework.MetroMessageBox.Show(this, "do You want clear your changes and open new paper ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dgr == DialogResult.Yes)
                txtInput.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Yp NotePad (*.ypn) |*.ypn;|Yp Text (*.yptxt)|*.yptxt;|YP Keyboard (*.ypk)|*.ypk";
            saveFileDialog1.FileName = "Untitled";
            saveFileDialog1.Title = "YP NotePad-Save as";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInput.SaveFile(saveFileDialog1.FileName);
                MetroFramework.MetroMessageBox.Show(this, "Comeleted!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Refresh();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Yp NotePad (*.ypn) |*.ypn;|Yp Text (*.yptxt)|*.yptxt;|YP Keyboard (*.ypk)|*.ypk";
            OpenFileDialog.Title = "YP NotePad-Open";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.LoadFile(OpenFileDialog.FileName);
            }

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                txtInput.Font = fontDialog1.Font;
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                txtInput.BackColor = colorDialog1.Color;
        }

        private void backColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                txtInput.SelectionBackColor = colorDialog1.Color;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                txtInput.ForeColor = colorDialog1.Color;
            if (txtInput.ForeColor == Color.White)
            {
                txtInput.ForeColor = Color.Black; MetroMessageBox.Show(this, "You Can't Select this because Page color is white.", "YP NotePad-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void wpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PDF Document |*.pdf;|Word Document|*.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtInput.SaveFile(saveFileDialog1.FileName);

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }


        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtInput.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (txtInput.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "There is no text to copy", "YP NotePad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(txtInput.Text);
            }

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtInput.Text += Clipboard.GetText();
        }

        private void cutmscript_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "There is no text to cut", "YP NotePad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(txtInput.Text);
                txtInput.Text = "";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtInput.SelectAll();
            if (txtInput.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Error for empty", "YP NotePad,Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {


        }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeDateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (txtInput.Text == "")
            {

                txtInput.Text += DateTime.Now.ToString() + "  ";
            }
            else
                txtInput.Text += " " + DateTime.Now.ToString() + "  ";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtInput.Text == "")
            {


            }
            else
            {
                panelSave.Visible = true;
                e.Cancel = true;
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            panelSave.Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            panelSave.Visible = false;
            saveFileDialog1.Filter = "Yp NotePad (*.ypn) |*.ypn;|Yp Text (*.yptxt)|*.yptxt;|YP Keyboard (*.ypk)|*.ypk";
            saveFileDialog1.FileName = "Untitled";
            saveFileDialog1.Title = "YP NotePad-Save as";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInput.SaveFile(saveFileDialog1.FileName);
                MetroFramework.MetroMessageBox.Show(this, "Save Comeleted!", "YP NotePad", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Refresh();
            }
        }

        private void ve_Tick(object sender, EventArgs e)
        {
            if (panelSave.Visible == true)
            {

                this.txtInput.Enabled = false;
                radMenu1.Enabled = false;
                MinimizeBox = false; MaximizeBox = false;

            }
            else
            {
                this.txtInput.Enabled = true;
                radMenu1.Enabled = true;
                MinimizeBox = true; MaximizeBox = true;
            }


        }

        private void timermohem_Tick(object sender, EventArgs e)
        {


        }

        private void timerhelp_Tick(object sender, EventArgs e)
        {

        }

        private void fullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void normallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void timermenu_Tick(object sender, EventArgs e)
        {
            if (panelSave.Visible == true)
            {
                Menu.Enabled = false;
            }
            else
                Menu.Enabled = true;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void RadMenuItem18_Click(object sender, EventArgs e)
        {
            helpFrm help = new helpFrm();
            help.ShowDialog();

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aboutFrm about = new aboutFrm();
            about.ShowDialog();
        }

        private void panelSave_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}






