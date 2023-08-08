﻿using System;
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

            this.MouseEnter += new EventHandler(FileFolderItem_MouseEnter);
            label.MouseEnter += new EventHandler(FileFolderItem_MouseEnter);
            pictureBox.MouseEnter += new EventHandler(FileFolderItem_MouseEnter);
            this.MouseLeave += new EventHandler(FileFolderItem_MouseLeave);
            label.MouseLeave += new EventHandler(FileFolderItem_MouseLeave);
            pictureBox.MouseLeave += new EventHandler(FileFolderItem_MouseLeave);
        }
        private void FileFolderItem_MouseEnter(object sender, EventArgs e)
        {
            Color parentColor = this.Parent.BackColor;
            int fadeAmount = 1;
            this.BackColor = ControlPaint.Light(parentColor, fadeAmount);
            this.Cursor = Cursors.Hand;
        }

        private void FileFolderItem_MouseLeave(object sender, EventArgs e)
        {

            this.BackColor = this.Parent.BackColor;
            this.Cursor = Cursors.Default;
        }


    }
    public class FileFolderCollection : IEnumerable<FileFolderItem>
    {
        public event EventHandler ItemChanged;

        public FileFolderCollection()
        {

        }

        private List<FileFolderItem> _items = new List<FileFolderItem>();

        public void Add(FileFolderItem item)
        {
            this._items.Add(item);
            ItemChanged?.Invoke(this, EventArgs.Empty);

        }
        public void Remove(int index)
        {
            _items.RemoveAt(index);
            ItemChanged?.Invoke(this, EventArgs.Empty);

        }

        public void Clear()
        {
            _items.Clear();
            ItemChanged?.Invoke(this, EventArgs.Empty);

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
        private int RowX { get; set; }
        private int RowY { get; set; }
        private int RowWidth { get; set; }
        private int RowHeight { get; set; }
        private int RowCount { get; set; }
        private int RowMaxCount { get; set; }
        public FileFolderCollection Items { get; }
        public FileFolderListView()
        {
            RowX = 0;
            RowY = 0;
            RowCount = 0;
            RowWidth = 100;
            RowHeight = 165;

            Items = new FileFolderCollection();
            Items.ItemChanged += HandleItemChanged;

            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = false;

        }
        private void HandleItemChanged(object sender, EventArgs e)
        {
            DrawList(true);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            DrawList(false);
        }

        private void DrawList(bool must_be_draw)
        {
            if ((this.ClientSize.Width / RowWidth) != RowMaxCount || must_be_draw == true)
            {
                RowX = 0;
                RowY = 0;
                RowCount = 0;
                this.Controls.Clear();
                foreach (FileFolderItem item in this.Items)
                {
                    RowMaxCount = this.ClientSize.Width / RowWidth;

                    if (RowCount < RowMaxCount)
                    {
                        item.Location = new Point(RowX, RowY);
                        item.Size = new Size(RowWidth, RowHeight);
                        this.Controls.Add(item);
                        RowX += RowWidth;
                        RowCount++;
                    }
                    else
                    {
                        RowX = 0;
                        RowY += RowHeight;
                        RowCount = -1;
                        item.Location = new Point(RowX, RowY);
                        item.Size = new Size(RowWidth, RowHeight);
                        this.Controls.Add(item);
                        RowCount++;
                    }
                }
                this.AutoScrollMinSize = new Size(0, RowY + (RowCount > 0 ? RowHeight : 0));
            }
        }
    }
}
