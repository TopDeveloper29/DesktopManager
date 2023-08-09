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
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string[] files;
        string[] directories;
        string current_path;

        public Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            MainList.ItemDoubleClicked += MainList_ItemDoubleClicked;
        }

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

        private void back_bt_Click(object sender, EventArgs e)
        {
            int max_back = desktopPath.Split(new string[] { @"\" }, StringSplitOptions.None).Length;
            string[] splipted_path = current_path.Split(new string[] { @"\" }, StringSplitOptions.None);
            string last_part_of_split = splipted_path[splipted_path.Length-1];
            string back_path = current_path.Replace($@"\{last_part_of_split}", null);
            if(splipted_path.Length > max_back)
            {
                Load_Folder(back_path);
            }
        }

        private void home_bt_Click(object sender, EventArgs e)
        {
            Load_Folder(desktopPath);
        }
    }
}
