using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopManager
{
    public partial class Popup : MaterialForm
    {
        public string Mode { get; set; }
        public string Path { get; set; }
        public Popup(string _mode, string _path)
        {
            Mode = _mode;
            Path = _path;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            switch (Mode)
            {
                case "AddDir":
                    this.text_box.Visible = true;
                    this.Text = $"New directory in {Path}";
                    break;
                case "AddFile":
                    this.text_box.Visible = true;
                    this.Text = $"New file in {Path}";
                    break;
                case "Rename":
                    this.text_box.Visible = true;
                    string[] splipted_path = Path.Split(new string[] { @"\" }, StringSplitOptions.None);
                    string last_part_of_split = splipted_path[splipted_path.Length - 1];
                    this.text_box.Text = last_part_of_split;
                    this.Text = $"Rename {Path}";
                    break;
                case "Delete":
                    this.Text = $"Delete {Path}";
                    break;
                default:
                    MessageBox.Show($"The popup don't know {Mode} mode!!!", "Warning Ivalid Mode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case "AddDir":
                    try
                    {
                        Directory.CreateDirectory($@"{Path}\{text_box.Text}");
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show($@"Canot create this directory: {Path}\{text_box.Text} Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    break;
                case "AddFile":
                    try
                    { 
                        File.Create($@"{Path}\{text_box.Text}");
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show($@"Canot create this file: {Path}\{text_box.Text} Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            break;
                case "Rename":

                    if (File.Exists(Path))
                    {
                        string[] splipted_path = Path.Split(new string[] { @"\" }, StringSplitOptions.None);
                        string last_part_of_split = splipted_path[splipted_path.Length - 1];
                        string simple_path = Path.Replace($@"\{last_part_of_split}", null);
                        File.Move(Path, $@"{simple_path}\{text_box.Text}");
                        this.Close();
                    }
                    else
                    {
                        if (Directory.Exists(Path))
                        {
                            string[] splipted_path = Path.Split(new string[] { @"\" }, StringSplitOptions.None);
                            string last_part_of_split = splipted_path[splipted_path.Length - 1];
                            string simple_path = Path.Replace($@"\{last_part_of_split}", null);
                            Directory.Move(Path, $@"{simple_path}\{text_box.Text}");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"The path {Path} was not found !!!", "Warning not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                        break;
                case "Delete":
                    if (File.Exists(Path))
                    {
                        File.Delete(Path);
                        this.Close();
                    }
                    else
                    {
                        if (Directory.Exists(Path))
                        {
                            Directory.Delete(Path, true);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"The path {Path} was not found !!!", "Warning not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                        break;
                default:
                        MessageBox.Show("The popup as not mode set and don't know what do with data !!!","Warning no Mode set",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        break;
            }
        }
    }
}
