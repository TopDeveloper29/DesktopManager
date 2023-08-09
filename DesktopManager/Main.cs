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
using FileFolder;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopManager
{
    public partial class Main : MaterialForm
    {
        // internal variable
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string[] files;
        string[] directories = new string[] { };
        string current_path = "";

        // Event
        private void MainList_ItemDoubleClicked(object sender, FileFolderItemEventArgs e)
        {
            FileFolderItem item = e.Item;
            string path = item.Path;
            if (!File.Exists(path))
            { Load_Folder(path); }
            else
            {
                System.Diagnostics.Process.Start(path);
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {
            Load_Folder(desktopPath);
        }
        private void back_bt_Click(object sender, EventArgs e)
        {
            int max_back = desktopPath.Split(new string[] { @"\" }, StringSplitOptions.None).Length;
            string[] splipted_path = current_path.Split(new string[] { @"\" }, StringSplitOptions.None);
            string last_part_of_split = splipted_path[splipted_path.Length - 1];
            string back_path = current_path.Replace($@"\{last_part_of_split}", null);
            if (splipted_path.Length > max_back)
            {
                Load_Folder(back_path);
            }
        }
        private void home_bt_Click(object sender, EventArgs e)
        {
            Load_Folder(desktopPath);
        }
        private void createDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Popup("AddDir", current_path).ShowDialog();
            Load_Folder(current_path);
        }
        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Popup("AddFile", current_path).ShowDialog();
            Load_Folder(current_path);
        }
        private void MainList_ItemChanged(object sender, EventArgs e)
        {
            Load_Folder(current_path);
        }

        private void back_bt_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged item is a panel
            if (e.Data.GetDataPresent(typeof(FileFolderItem)))
            {

                FileFolderItem item = (FileFolderItem)e.Data.GetData(typeof(FileFolderItem));
                string item_path = item.Path;
                int max_back = desktopPath.Split(new string[] { @"\" }, StringSplitOptions.None).Length;
                string[] splipted_path = current_path.Split(new string[] { @"\" }, StringSplitOptions.None);
                string last_part_of_split = splipted_path[splipted_path.Length - 1];
                string back_path = current_path.Replace($@"\{last_part_of_split}", null);

                if (splipted_path.Length > max_back)
                {
                    e.Effect = DragDropEffects.Move; // Allow the drop
                }
                else
                {
                    e.Effect = DragDropEffects.None; // Don't allow the drop
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void home_bt_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged item is a panel
            if (e.Data.GetDataPresent(typeof(FileFolderItem)))
            {
                if (current_path != desktopPath)
                {
                    e.Effect = DragDropEffects.Move; // Allow the drop
                }
                else
                {
                    e.Effect = DragDropEffects.None; // Don't allow the drop
                }
            }
            else
            {
                e.Effect = DragDropEffects.None; // Don't allow the drop
            }
        }
        private void home_bt_DragDrop(object sender, DragEventArgs e)
        {
            if (current_path != desktopPath)
            {
                FileFolderItem item = (FileFolderItem)e.Data.GetData(typeof(FileFolderItem));
                string item_path = item.Path;
                if (File.Exists(item_path))
                {
                    string[] splipted_path2 = item_path.Split(new string[] { @"\" }, StringSplitOptions.None);
                    string last_part_of_split2 = splipted_path2[splipted_path2.Length - 1];
                    File.Move(item_path, $@"{desktopPath}\{last_part_of_split2}");
                    Load_Folder(current_path);
                }
                else
                {
                    string[] splipted_path2 = item_path.Split(new string[] { @"\" }, StringSplitOptions.None);
                    string last_part_of_split2 = splipted_path2[splipted_path2.Length - 1];
                    Directory.Move(item_path, $@"{desktopPath}\{last_part_of_split2}");
                    Load_Folder(current_path);
                }
            }
        }
        private void back_bt_DragDrop(object sender, DragEventArgs e)
        {
            FileFolderItem item = (FileFolderItem)e.Data.GetData(typeof(FileFolderItem));
            string item_path = item.Path;
            int max_back = desktopPath.Split(new string[] { @"\" }, StringSplitOptions.None).Length;
            string[] splipted_path = current_path.Split(new string[] { @"\" }, StringSplitOptions.None);
            string last_part_of_split = splipted_path[splipted_path.Length - 1];
            string back_path = current_path.Replace($@"\{last_part_of_split}", null);

            if (splipted_path.Length > max_back)
            {
                if (File.Exists(item_path))
                {
                    string[] splipted_path2 = item_path.Split(new string[] { @"\" }, StringSplitOptions.None);
                    string last_part_of_split2 = splipted_path2[splipted_path2.Length - 1];
                    File.Move(item_path, $@"{back_path}\{last_part_of_split2}");
                    Load_Folder(current_path);
                }
                else
                {
                    string[] splipted_path2 = item_path.Split(new string[] { @"\" }, StringSplitOptions.None);
                    string last_part_of_split2 = splipted_path2[splipted_path2.Length - 1];
                    Directory.Move(item_path, $@"{back_path}\{last_part_of_split2}");
                    Load_Folder(current_path);
                }
            }
        }

        

        //constructor
        public Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            MainList.ItemDoubleClicked += MainList_ItemDoubleClicked;
            MainList.ItemsChanged += MainList_ItemChanged;
        }

        // private function
        private void Load_Folder(string path)
        {
            current_path = path;
            MainList.Items.Clear();
            files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            directories = Directory.GetDirectories(path);

            foreach (string dir in directories)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                FileFolderItem item = new FileFolderItem();
                item.Text = dirInfo.Name;
                item.Path = dir;
                item.Picture = global::DesktopManager.Properties.Resources.dir;
                MainList.Items.Add(item);
            }

            foreach (string file in files)
            {
                if (!file.Contains("desktop.ini"))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(file);
                    FileFolderItem item = new FileFolderItem();
                    item.Text = dirInfo.Name;
                    item.Path = file;
                    Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(file);
                    Image image = icon.ToBitmap();

                    item.Picture = image;
                    MainList.Items.Add(item);
                }
            }
        }
    }
}
