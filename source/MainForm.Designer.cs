namespace Text.NET
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_newfile = new System.Windows.Forms.Button();
            this.mStrip_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_open = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_saveas = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.marker_01 = new System.Windows.Forms.Label();
            this.button_bbcode = new System.Windows.Forms.Button();
            this.marker_02 = new System.Windows.Forms.Label();
            this.button_paste = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_cut = new System.Windows.Forms.Button();
            this.richTB_main = new System.Windows.Forms.RichTextBox();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marker_03 = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.mStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_newfile
            // 
            this.button_newfile.Image = global::Text.NET.Properties.Resources.page_cream_add;
            this.button_newfile.Location = new System.Drawing.Point(12, 30);
            this.button_newfile.Name = "button_newfile";
            this.button_newfile.Size = new System.Drawing.Size(24, 24);
            this.button_newfile.TabIndex = 0;
            this.button_newfile.UseVisualStyleBackColor = true;
            this.button_newfile.Click += new System.EventHandler(this.File_New);
            // 
            // mStrip_main
            // 
            this.mStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mStrip_main.Location = new System.Drawing.Point(0, 0);
            this.mStrip_main.Name = "mStrip_main";
            this.mStrip_main.Size = new System.Drawing.Size(584, 27);
            this.mStrip_main.TabIndex = 1;
            this.mStrip_main.Text = "mStrip_main";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // button_open
            // 
            this.button_open.Image = global::Text.NET.Properties.Resources.folder_open;
            this.button_open.Location = new System.Drawing.Point(42, 30);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(24, 24);
            this.button_open.TabIndex = 2;
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.File_Open);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // button_saveas
            // 
            this.button_saveas.Image = global::Text.NET.Properties.Resources.disk_add;
            this.button_saveas.Location = new System.Drawing.Point(102, 30);
            this.button_saveas.Name = "button_saveas";
            this.button_saveas.Size = new System.Drawing.Size(24, 24);
            this.button_saveas.TabIndex = 4;
            this.button_saveas.UseVisualStyleBackColor = true;
            this.button_saveas.Click += new System.EventHandler(this.File_SaveAs);
            // 
            // button_save
            // 
            this.button_save.Image = global::Text.NET.Properties.Resources.disk;
            this.button_save.Location = new System.Drawing.Point(72, 30);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(24, 24);
            this.button_save.TabIndex = 3;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.File_Save);
            // 
            // marker_01
            // 
            this.marker_01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.marker_01.Location = new System.Drawing.Point(132, 30);
            this.marker_01.Name = "marker_01";
            this.marker_01.Size = new System.Drawing.Size(2, 24);
            this.marker_01.TabIndex = 5;
            // 
            // button_bbcode
            // 
            this.button_bbcode.Image = global::Text.NET.Properties.Resources.bbcode;
            this.button_bbcode.Location = new System.Drawing.Point(140, 30);
            this.button_bbcode.Name = "button_bbcode";
            this.button_bbcode.Size = new System.Drawing.Size(24, 24);
            this.button_bbcode.TabIndex = 6;
            this.button_bbcode.UseVisualStyleBackColor = true;
            // 
            // marker_02
            // 
            this.marker_02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.marker_02.Location = new System.Drawing.Point(170, 30);
            this.marker_02.Name = "marker_02";
            this.marker_02.Size = new System.Drawing.Size(2, 24);
            this.marker_02.TabIndex = 7;
            // 
            // button_paste
            // 
            this.button_paste.Image = global::Text.NET.Properties.Resources.paste_plain;
            this.button_paste.Location = new System.Drawing.Point(238, 30);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(24, 24);
            this.button_paste.TabIndex = 10;
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.Edit_Paste);
            // 
            // button_copy
            // 
            this.button_copy.Image = global::Text.NET.Properties.Resources.page_white_copy;
            this.button_copy.Location = new System.Drawing.Point(208, 30);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(24, 24);
            this.button_copy.TabIndex = 9;
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.Edit_Copy);
            // 
            // button_cut
            // 
            this.button_cut.Image = global::Text.NET.Properties.Resources.scissors;
            this.button_cut.Location = new System.Drawing.Point(178, 30);
            this.button_cut.Name = "button_cut";
            this.button_cut.Size = new System.Drawing.Size(24, 24);
            this.button_cut.TabIndex = 8;
            this.button_cut.UseVisualStyleBackColor = true;
            this.button_cut.Click += new System.EventHandler(this.Edit_Cut);
            // 
            // richTB_main
            // 
            this.richTB_main.AcceptsTab = true;
            this.richTB_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTB_main.EnableAutoDragDrop = true;
            this.richTB_main.Location = new System.Drawing.Point(12, 60);
            this.richTB_main.Name = "richTB_main";
            this.richTB_main.Size = new System.Drawing.Size(560, 289);
            this.richTB_main.TabIndex = 11;
            this.richTB_main.Text = "";
            this.richTB_main.WordWrap = false;
            this.richTB_main.SelectionChanged += new System.EventHandler(this.NewSelectionMade);
            this.richTB_main.Click += new System.EventHandler(this.Click_Refresh);
            this.richTB_main.TextChanged += new System.EventHandler(this.ChangesMade);
            this.richTB_main.MouseHover += new System.EventHandler(this.Hover_Refresh);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Image = global::Text.NET.Properties.Resources.page_cream_add;
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.File_New);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = global::Text.NET.Properties.Resources.folder_open;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.File_Open);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Text.NET.Properties.Resources.disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.File_Save);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Text.NET.Properties.Resources.disk_add;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.File_SaveAs);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Text.NET.Properties.Resources.help;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aboutToolStripMenuItem.Text = "About Page";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.View_About);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Text.NET.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.AppExit);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::Text.NET.Properties.Resources.scissors;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.Edit_Cut);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Text.NET.Properties.Resources.page_white_copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.Edit_Copy);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::Text.NET.Properties.Resources.paste_plain;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.Edit_Paste);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Text.NET.Properties.Resources.wrench;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.View_Settings);
            // 
            // marker_03
            // 
            this.marker_03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.marker_03.Location = new System.Drawing.Point(268, 30);
            this.marker_03.Name = "marker_03";
            this.marker_03.Size = new System.Drawing.Size(2, 24);
            this.marker_03.TabIndex = 12;
            this.marker_03.Visible = false;
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about.Image = global::Text.NET.Properties.Resources.help;
            this.button_about.Location = new System.Drawing.Point(548, 30);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(24, 24);
            this.button_about.TabIndex = 14;
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.View_About);
            // 
            // button_settings
            // 
            this.button_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_settings.Image = global::Text.NET.Properties.Resources.wrench;
            this.button_settings.Location = new System.Drawing.Point(518, 30);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(24, 24);
            this.button_settings.TabIndex = 13;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.View_Settings);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.marker_03);
            this.Controls.Add(this.richTB_main);
            this.Controls.Add(this.button_paste);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_cut);
            this.Controls.Add(this.marker_02);
            this.Controls.Add(this.button_bbcode);
            this.Controls.Add(this.marker_01);
            this.Controls.Add(this.button_saveas);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_newfile);
            this.Controls.Add(this.mStrip_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mStrip_main;
            this.MinimumSize = new System.Drawing.Size(360, 145);
            this.Name = "MainForm";
            this.Text = "new | Notepad.NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_Closing);
            this.Load += new System.EventHandler(this.App_Loaded);
            this.SizeChanged += new System.EventHandler(this.App_Sized);
            this.Click += new System.EventHandler(this.Click_Refresh);
            this.MouseHover += new System.EventHandler(this.Hover_Refresh);
            this.mStrip_main.ResumeLayout(false);
            this.mStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button button_newfile;
        private System.Windows.Forms.MenuStrip mStrip_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_saveas;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label marker_01;
        private System.Windows.Forms.Button button_bbcode;
        private System.Windows.Forms.Label marker_02;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_cut;
        private System.Windows.Forms.RichTextBox richTB_main;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label marker_03;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_settings;
    }
}

