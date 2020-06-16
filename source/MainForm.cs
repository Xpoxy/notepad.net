using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Text.NET
{
    public partial class MainForm : Form
    {
        public string current_file_directory;
        public string[] fileName_Hierarchy;
        public string current_file_no_change;

        public MainForm()
        {
            InitializeComponent();
        }

        private void File_Open(object sender, EventArgs e)
        {
            if (this.Text.Contains("* | Notepad.NET"))
            {
                if (Properties.Settings.Default.setting_general_01)
                {
                    if (MessageBox.Show("This file has unsaved changes.\nDiscard changes and open another file?", "Unsaved Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        OpenFileDialog dialog_open = new OpenFileDialog();
                        if (dialog_open.ShowDialog() == DialogResult.OK)
                        {
                            current_file_directory = dialog_open.FileName;
                            StreamReader stream_reader = new StreamReader(dialog_open.FileName, Encoding.Default, true);
                            richTB_main.Text = stream_reader.ReadToEnd();
                            current_file_no_change = richTB_main.Text;
                            stream_reader.Close();
                            stream_reader.Dispose();
                            fileName_Hierarchy = dialog_open.FileName.Split('\\');
                            this.Text = fileName_Hierarchy[fileName_Hierarchy.Length - 1] + " | Notepad.NET";
                            this.Refresh();
                        }
                    }
                }
                else
                {
                    OpenFileDialog dialog_open = new OpenFileDialog();
                    if (dialog_open.ShowDialog() == DialogResult.OK)
                    {
                        current_file_directory = dialog_open.FileName;
                        StreamReader stream_reader = new StreamReader(dialog_open.FileName, Encoding.Default, true);
                        richTB_main.Text = stream_reader.ReadToEnd();
                        current_file_no_change = richTB_main.Text;
                        stream_reader.Close();
                        stream_reader.Dispose();
                        fileName_Hierarchy = dialog_open.FileName.Split('\\');
                        this.Text = fileName_Hierarchy[fileName_Hierarchy.Length - 1] + " | Notepad.NET";
                        this.Refresh();
                    }
                }
            }
            else
            {
                OpenFileDialog dialog_open = new OpenFileDialog();
                if (dialog_open.ShowDialog() == DialogResult.OK)
                {
                    current_file_directory = dialog_open.FileName;
                    StreamReader stream_reader = new StreamReader(dialog_open.FileName, Encoding.Default, true);
                    richTB_main.Text = stream_reader.ReadToEnd();
                    current_file_no_change = richTB_main.Text;
                    stream_reader.Close();
                    stream_reader.Dispose();
                    fileName_Hierarchy = dialog_open.FileName.Split('\\');
                    this.Text = fileName_Hierarchy[fileName_Hierarchy.Length - 1] + " | Notepad.NET";
                    this.Refresh();
                }
            }
            
        }

        private void File_Save(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(current_file_directory) == false)
            {
                StreamWriter stream_writer = new StreamWriter(current_file_directory);
                stream_writer.Write(richTB_main.Text);
                stream_writer.Close();
                stream_writer.Dispose();
                this.Text = fileName_Hierarchy[fileName_Hierarchy.Length - 1] + " | Notepad.NET";
                current_file_no_change = richTB_main.Text;
            }
            else
            {
                File_SaveAs(sender, e);
            }
        }

        private void File_SaveAs(object sender, EventArgs e)
        {
            SaveFileDialog dialog_save = new SaveFileDialog();
            dialog_save.FileName = "*.txt";
            dialog_save.DefaultExt = ".txt";
            dialog_save.Filter = "Text File (.txt)|*.txt|All Files (*.*)|*.txt";
            if (dialog_save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream_writer = new StreamWriter(dialog_save.FileName);
                stream_writer.Write(richTB_main.Text);
                stream_writer.Close();
                stream_writer.Dispose();
                fileName_Hierarchy = dialog_save.FileName.Split('\\');
                this.Text = fileName_Hierarchy[fileName_Hierarchy.Length - 1] + " | Notepad.NET";
                current_file_no_change = richTB_main.Text;
            }
        }

        private void ChangesMade(object sender, EventArgs e)
        {
            if (fileName_Hierarchy != null)
            {
                if(current_file_no_change != richTB_main.Text)
                {
                    this.Text = fileName_Hierarchy[fileName_Hierarchy.Length - 1] + "* | Notepad.NET";
                }
                else
                {
                    this.Text = fileName_Hierarchy[fileName_Hierarchy.Length - 1] + " | Notepad.NET";
                }
            }
            else
            {
                this.Text = "new* | Notepad.NET";
            }
        }

        private void File_New(object sender, EventArgs e)
        {
            if(this.Text.Contains("* | Notepad.NET"))
            {
                if (Properties.Settings.Default.setting_general_01)
                {
                    if (MessageBox.Show("This file has unsaved changes.\nDiscard changes and start a new file?", "Unsaved Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        richTB_main.Clear();
                        this.Text = "new | Notepad.NET";
                        current_file_directory = null;
                        fileName_Hierarchy = null;
                        current_file_no_change = null;
                    }
                }
                else
                {
                    richTB_main.Clear();
                    this.Text = "new | Notepad.NET";
                    current_file_directory = null;
                    fileName_Hierarchy = null;
                    current_file_no_change = null;
                }
            }
            else
            {
                richTB_main.Clear();
                this.Text = "new | Notepad.NET";
                current_file_directory = null;
                fileName_Hierarchy = null;
                current_file_no_change = null;
            }
        }

        private void View_About(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }

        private void View_Settings(object sender, EventArgs e)
        {
            Properties.Settings.Default.setting_tab = 0;
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        private void App_Closing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.setting_general_04 == true)
            {
                Properties.Settings.Default.LastFormSize = this.Size;
                Properties.Settings.Default.LastFormPos = this.Location;
                Properties.Settings.Default.Save();
            }

        }

        private void App_Loaded(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.LastFormSize;
            this.Location = Properties.Settings.Default.LastFormPos;
            button_copy.Enabled = false;
            button_cut.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Enabled = false;
            Hover_Refresh(sender, e);
            try
            {
                String.IsNullOrEmpty(Clipboard.GetData(DataFormats.Text).ToString());
            }
            catch (Exception ex)
            {
                button_paste.Enabled = false;
            }
            if (String.IsNullOrEmpty(Properties.Settings.Default.openwith_file) == false)
            {
                try
                {
                    StreamReader stream_reader = new StreamReader(Properties.Settings.Default.openwith_file);
                    richTB_main.Text = stream_reader.ReadToEnd();
                    current_file_no_change = richTB_main.Text;
                    stream_reader.Close();
                    stream_reader.Dispose();
                    fileName_Hierarchy = Properties.Settings.Default.openwith_file.Split('\\');
                    current_file_directory = Properties.Settings.Default.openwith_file;
                    this.Text = fileName_Hierarchy[fileName_Hierarchy.Length - 1] + " | Notepad.NET";
                    Properties.Settings.Default.openwith_file = String.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File directory could not be found. Most likely, the file have been deleted during opening.", "File not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Properties.Settings.Default.openwith_file = String.Empty;
                }
            }
        }

        private void Click_Refresh(object sender, EventArgs e)
        {
            Hover_Refresh(sender, e);
        }

        private void Hover_Refresh(object sender, EventArgs e)
        {
            richTB_main.Font = Properties.Settings.Default.setting_general_02;
            richTB_main.WordWrap = Properties.Settings.Default.setting_general_03;
        }

        private void App_Sized(object sender, EventArgs e)
        {
            if (this.Size.Width == this.MinimumSize.Width)
            {
                marker_03.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                marker_03.BorderStyle = BorderStyle.None;
            }
        }

        private void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Edit_Paste(object sender, EventArgs e)
        {
            if (richTB_main.SelectedText != null)
            {
                try
                {
                    richTB_main.SelectedText = Clipboard.GetData(DataFormats.Text).ToString();
                }
                catch (Exception ex)
                {
                    button_paste.Enabled = false;
                    pasteToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                try
                {
                    richTB_main.Text = richTB_main.Text + Clipboard.GetData(DataFormats.Text).ToString();
                }
                catch (Exception ex)
                {
                    button_paste.Enabled = false;
                    pasteToolStripMenuItem.Enabled = false;
                }
            }
            
        }

        private void Edit_Cut(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTB_main.SelectedText) == false)
            {
                Clipboard.SetText(richTB_main.SelectedText);
                richTB_main.SelectedText = "";
            }
        }

        private void Edit_Copy(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTB_main.SelectedText) == false)
            {
                Clipboard.SetText(richTB_main.SelectedText);
                button_paste.Enabled = true;
                pasteToolStripMenuItem.Enabled = true;
            }
        }

        private void NewSelectionMade(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTB_main.SelectedText) == false)
            {
                button_copy.Enabled = true;
                button_cut.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
            }
            else
            {
                button_copy.Enabled = false;
                button_cut.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
            }
        }

        private void View_Settings_Design(object sender, EventArgs e)
        {
            Properties.Settings.Default.setting_tab = 1;
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }
    }
}
