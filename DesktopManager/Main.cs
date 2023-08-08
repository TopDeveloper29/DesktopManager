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

namespace DesktopManager
{
    public partial class Main : Form
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string[] files;
        string[] directories;

        public Main()
        {
            InitializeComponent();
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
                FileFolderItem item = new FileFolderItem();
                FolderFileList.Items.Add(item);
            }
        }
    }
}
