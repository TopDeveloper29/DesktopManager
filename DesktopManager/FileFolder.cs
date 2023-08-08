using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace FileFolder
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(FileFolderItem))]
    public class FileFolderItem : Panel
    {
        private Label label { get; set; }
        private PictureBox pictureBox { get; set; }
        private string _text;
        private Image _image;

        [Browsable(true)]
        public override string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                if (!string.IsNullOrEmpty(_text))
                {
                    label.Text = _text;
                }
            }
        }

        [Browsable(true)]
        public Image Picture
        {
            get { return _image; }
            set
            {
                _image = value;
                if (_image != null)
                {
                    pictureBox.Image = _image;
                }
            }
        }

        public FileFolderItem()
        {
            label = new Label();
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.Dock = DockStyle.Fill;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.AutoSize = false;

            Panel labpan = new Panel();
            Panel picpan = new Panel();
            labpan.Controls.Add(label);
            picpan.Controls.Add(pictureBox);
            picpan.Dock = DockStyle.Top;
            labpan.Dock = DockStyle.Bottom;
            this.Controls.Add(picpan);
            this.Controls.Add(labpan);
        }
    }
    public class FileFolderCollection : IEnumerable<FileFolderItem>
    {
        public FileFolderCollection()
        {

        }

        public delegate void FileFolderHandler(object sender, EventArgs e);
        public event FileFolderHandler ItemsChanged;

        private List<FileFolderItem> _items = new List<FileFolderItem>();

        public void Add(FileFolderItem item)
        {
            this._items.Add(item);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Remove(int index)
        {
            _items.RemoveAt(index);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Clear()
        {
            _items.Clear();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        public IEnumerator<FileFolderItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(FileFolderListView))]
    public class FileFolderListView : Panel
    {
        public FileFolderCollection Items { get; set; }
        public FileFolderListView()
        {
            Items.ItemsChanged += ItemsChanged;
        }
        private void ItemsChanged(object sender, EventArgs e)
        {
            foreach (FileFolderItem item in this.Items)
            {
                Panel panel = new Panel();
                panel.Controls.Add(item);
            }
        }
    }

}
