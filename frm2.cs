using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Calculator;

namespace Calculator
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resizable = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Movable = true;
            ShowIcon = false;
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel0.Visible = true;
            ControlBox = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel0.Visible = false;
            ControlBox = true;
        }
    }
}
