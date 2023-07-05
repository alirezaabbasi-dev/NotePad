namespace YP_NotePad
{
    partial class notePad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notePad));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tdToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sclaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timedateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tXTCOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fONTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ve = new System.Windows.Forms.Timer(this.components);
            this.timerhelp = new System.Windows.Forms.Timer(this.components);
            this.timermenu = new System.Windows.Forms.Timer(this.components);
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.fileMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.newMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.openMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.saveMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.editMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.undoMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.copyMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.cutMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.pasteMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.sellAllMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.timeMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.formatMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.fontMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.viewMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.textColorMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.aboutToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.helpToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.saveBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.panelSave = new Telerik.WinControls.UI.RadPanel();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSave)).BeginInit();
            this.panelSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ypToolStripMenuItem});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Menu.Location = new System.Drawing.Point(624, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.ShowItemToolTips = true;
            this.Menu.Size = new System.Drawing.Size(157, 371);
            this.Menu.TabIndex = 1;
            this.Menu.Visible = false;
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ypToolStripMenuItem
            // 
            this.ypToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.tdToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.sclaToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.timedateToolStripMenuItem,
            this.toolStripSeparator1,
            this.tXTCOLORToolStripMenuItem,
            this.fONTToolStripMenuItem});
            this.ypToolStripMenuItem.Name = "ypToolStripMenuItem";
            this.ypToolStripMenuItem.Size = new System.Drawing.Size(31, 18);
            this.ypToolStripMenuItem.Text = "yp";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.newToolStripMenuItem.Text = "new";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // tdToolStripMenuItem
            // 
            this.tdToolStripMenuItem.Name = "tdToolStripMenuItem";
            this.tdToolStripMenuItem.Size = new System.Drawing.Size(184, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.undoToolStripMenuItem.Text = "undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.copyToolStripMenuItem.Text = "copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cutToolStripMenuItem.Text = "cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutmscript_Click);
            // 
            // sclaToolStripMenuItem
            // 
            this.sclaToolStripMenuItem.Name = "sclaToolStripMenuItem";
            this.sclaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.sclaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sclaToolStripMenuItem.Text = "scla";
            this.sclaToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click_1);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pasteToolStripMenuItem.Text = "paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // timedateToolStripMenuItem
            // 
            this.timedateToolStripMenuItem.Name = "timedateToolStripMenuItem";
            this.timedateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.timedateToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.timedateToolStripMenuItem.Text = "time/date";
            this.timedateToolStripMenuItem.Click += new System.EventHandler(this.timeDateToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // tXTCOLORToolStripMenuItem
            // 
            this.tXTCOLORToolStripMenuItem.Name = "tXTCOLORToolStripMenuItem";
            this.tXTCOLORToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.tXTCOLORToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tXTCOLORToolStripMenuItem.Text = "TXTCOLOR";
            this.tXTCOLORToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // fONTToolStripMenuItem
            // 
            this.fONTToolStripMenuItem.Name = "fONTToolStripMenuItem";
            this.fONTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fONTToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.fONTToolStripMenuItem.Text = "FONT";
            this.fONTToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ve
            // 
            this.ve.Enabled = true;
            this.ve.Tick += new System.EventHandler(this.ve_Tick);
            // 
            // timerhelp
            // 
            this.timerhelp.Tick += new System.EventHandler(this.timerhelp_Tick);
            // 
            // timermenu
            // 
            this.timermenu.Enabled = true;
            this.timermenu.Tick += new System.EventHandler(this.timermenu_Tick);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_plus_48;
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShowArrow = true;
            this.newMenuItem.Text = "New";
            this.newMenuItem.ToolTipText = "New (Ctrl+N)";
            this.newMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_open_in_popup_96;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Text = "Open";
            this.openMenuItem.ToolTipText = "Open (Ctrl+O)";
            this.openMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_save_all_96;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.ToolTipText = "Save (Ctrl+S)";
            this.saveMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.undoMenuItem,
            this.copyMenuItem,
            this.cutMenuItem,
            this.pasteMenuItem,
            this.sellAllMenuItem,
            this.timeMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Text = "Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_undo_96;
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.Text = "undo";
            this.undoMenuItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.undoMenuItem.ToolTipText = "Undo (Ctrl+Z)";
            this.undoMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_copy_961;
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Text = "copy";
            this.copyMenuItem.ToolTipText = "Copy (Ctrl+C)";
            this.copyMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_cut_96;
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.Text = "cut";
            this.cutMenuItem.ToolTipText = "Cut (Ctrl+X)";
            this.cutMenuItem.Click += new System.EventHandler(this.cutmscript_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_paste_96;
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.Text = "Paste";
            this.pasteMenuItem.ToolTipText = "Paste (Ctrl+V)";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // sellAllMenuItem
            // 
            this.sellAllMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_select_all_96;
            this.sellAllMenuItem.Name = "sellAllMenuItem";
            this.sellAllMenuItem.Text = "Select All";
            this.sellAllMenuItem.ToolTipText = "Select All (Ctrl+A)";
            this.sellAllMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click_1);
            // 
            // timeMenuItem
            // 
            this.timeMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_day_view_96;
            this.timeMenuItem.Name = "timeMenuItem";
            this.timeMenuItem.Text = "Time/Date";
            this.timeMenuItem.ToolTipText = "Time/Date (F5)";
            this.timeMenuItem.Click += new System.EventHandler(this.timeDateToolStripMenuItem_Click_1);
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.fontMenuItem});
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Text = "Format";
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_choose_font_96;
            this.fontMenuItem.Name = "fontMenuItem";
            this.fontMenuItem.Text = "Font";
            this.fontMenuItem.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.fontMenuItem.ToolTipText = "Font (Ctrl+F)";
            this.fontMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.textColorMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Text = "View";
            // 
            // textColorMenuItem
            // 
            this.textColorMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_color_wheel_96;
            this.textColorMenuItem.Name = "textColorMenuItem";
            this.textColorMenuItem.Text = "Text Color";
            this.textColorMenuItem.ToolTipText = "Text Color (Ctrl+Alt+T)";
            this.textColorMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_about_96;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::YP_NotePad.Properties.Resources.icons8_help_96;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.RadMenuItem18_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(0, 34);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(781, 337);
            this.txtInput.TabIndex = 5;
            this.txtInput.Text = "";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton1.Location = new System.Drawing.Point(345, 71);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(84, 24);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "Don\'t Save";
            this.radButton1.ThemeName = "Crystal";
            this.radButton1.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton2.Location = new System.Drawing.Point(438, 71);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(84, 24);
            this.radButton2.TabIndex = 0;
            this.radButton2.Text = "Cancel";
            this.radButton2.ThemeName = "Crystal";
            this.radButton2.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBtn.Location = new System.Drawing.Point(250, 71);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(84, 24);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.ThemeName = "Crystal";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(245, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(291, 24);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Do you want to save changes to Untitled?";
            this.radLabel1.ThemeName = "Crystal";
            // 
            // panelSave
            // 
            this.panelSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSave.Controls.Add(this.radLabel1);
            this.panelSave.Controls.Add(this.saveBtn);
            this.panelSave.Controls.Add(this.radButton1);
            this.panelSave.Controls.Add(this.radButton2);
            this.panelSave.Location = new System.Drawing.Point(0, 118);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(781, 107);
            this.panelSave.TabIndex = 8;
            this.panelSave.ThemeName = "Crystal";
            this.panelSave.Visible = false;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.formatMenuItem,
            this.viewMenuItem,
            this.radMenuItem5});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(781, 34);
            this.radMenu1.TabIndex = 4;
            this.radMenu1.ThemeName = "Crystal";
            // 
            // notePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 371);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "notePad";
            this.Opacity = 0.99D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YP NotePad";
            this.ThemeName = "Crystal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.notePad_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSave)).EndInit();
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.Timer ve;
        private System.Windows.Forms.Timer timerhelp;
        private System.Windows.Forms.Timer timermenu;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem fileMenuItem;
        private Telerik.WinControls.UI.RadMenuItem newMenuItem;
        private Telerik.WinControls.UI.RadMenuItem editMenuItem;
        private Telerik.WinControls.UI.RadMenuItem formatMenuItem;
        private Telerik.WinControls.UI.RadMenuItem viewMenuItem;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem openMenuItem;
        private Telerik.WinControls.UI.RadMenuItem saveMenuItem;
        private Telerik.WinControls.UI.RadMenuItem undoMenuItem;
        private Telerik.WinControls.UI.RadMenuItem copyMenuItem;
        private Telerik.WinControls.UI.RadMenuItem cutMenuItem;
        private Telerik.WinControls.UI.RadMenuItem pasteMenuItem;
        private Telerik.WinControls.UI.RadMenuItem sellAllMenuItem;
        private Telerik.WinControls.UI.RadMenuItem timeMenuItem;
        private Telerik.WinControls.UI.RadMenuItem fontMenuItem;
        private Telerik.WinControls.UI.RadMenuItem textColorMenuItem;
        private Telerik.WinControls.UI.RadMenuItem aboutToolStripMenuItem;
        private Telerik.WinControls.UI.RadMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtInput;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton saveBtn;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel panelSave;
        private System.Windows.Forms.ToolStripMenuItem ypToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sclaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timedateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tXTCOLORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fONTToolStripMenuItem;
    }
}

