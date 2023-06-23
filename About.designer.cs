namespace YP_NotePad
{
    partial class aboutFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutFrm));
            this.okBtn = new Telerik.WinControls.UI.RadButton();
            this.githubBtn = new Telerik.WinControls.UI.RadButton();
            this.radColorDialog1 = new Telerik.WinControls.RadColorDialog();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.crystalTheme2 = new Telerik.WinControls.Themes.CrystalTheme();
            this.aboutTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.okBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.okBtn.Location = new System.Drawing.Point(310, 210);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(130, 51);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.ThemeName = "Crystal";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // githubBtn
            // 
            this.githubBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.githubBtn.Location = new System.Drawing.Point(12, 210);
            this.githubBtn.Name = "githubBtn";
            this.githubBtn.Size = new System.Drawing.Size(130, 51);
            this.githubBtn.TabIndex = 1;
            this.githubBtn.Text = "My Github";
            this.githubBtn.ThemeName = "Crystal";
            this.githubBtn.Click += new System.EventHandler(this.githubBtn_Click);
            // 
            // radColorDialog1
            // 
            this.radColorDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("radColorDialog1.Icon")));
            this.radColorDialog1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radColorDialog1.SelectedColor = System.Drawing.Color.Red;
            this.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0D, 1D, 1D);
            // 
            // aboutTxt
            // 
            this.aboutTxt.Location = new System.Drawing.Point(12, 10);
            this.aboutTxt.Name = "aboutTxt";
            this.aboutTxt.Size = new System.Drawing.Size(400, 184);
            this.aboutTxt.TabIndex = 3;
            this.aboutTxt.Text = "Application Name: YP NotePad\r\n\r\nApplication Version: 1.0.0\r\n\r\nCopyright by: YP\r\n\r" +
    "\nDeveloper: Alireza Abbasi\r\n\r\nApplication Icons: icons8\r\n";
            // 
            // aboutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 314);
            this.Controls.Add(this.aboutTxt);
            this.Controls.Add(this.githubBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutFrm";
            this.Opacity = 0.98D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ThemeName = "Crystal";
            this.TransparencyKey = System.Drawing.Color.Chocolate;
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.okBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton okBtn;
        private Telerik.WinControls.UI.RadButton githubBtn;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme2;
        private System.Windows.Forms.Label aboutTxt;
    }
}