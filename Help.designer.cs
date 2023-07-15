namespace note_pad_yp
{
    partial class helpFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpTxt = new System.Windows.Forms.Label();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // helpTxt
            // 
            this.helpTxt.BackColor = System.Drawing.Color.White;
            this.helpTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTxt.ForeColor = System.Drawing.Color.Black;
            this.helpTxt.Location = new System.Drawing.Point(12, 9);
            this.helpTxt.Name = "helpTxt";
            this.helpTxt.Size = new System.Drawing.Size(467, 239);
            this.helpTxt.TabIndex = 2;
            this.helpTxt.Text = "Ctrl+V=paste text\r\n\r\nCtrl+N=clear text and open new paper\r\n\r\nCtrl+S=Save Your tex" +
    "t\r\n\r\nCtrl+A=Select All text\r\n";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radButton1.Location = new System.Drawing.Point(368, 198);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(111, 50);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "OK";
            this.radButton1.ThemeName = "Crystal";
            this.radButton1.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // helpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 267);
            this.ControlBox = false;
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.helpTxt);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "helpFrm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                              Hel" +
    "p";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.helpFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label helpTxt;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
    }
}