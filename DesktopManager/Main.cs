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

        public Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles(desktopPath);
            directories = Directory.GetDirectories(desktopPath);

            foreach (string file in files) 
            {
                if (!file.Contains("desktop.ini"))
                {
                }
            }

            foreach (string dir in directories)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                FileFolderItem item = new FileFolderItem();
                item.Text = dirInfo.Name;
                item.Picture = global::DesktopManager.Properties.Resources.dir;
                MainList.Items.Add(item);
            }
        }
    }
}
