using DesktopManager;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace FileFolder
{
    // Custom event argument class for FileFolderItem events
    public class FileFolderItemEventArgs : EventArgs
    {
        public FileFolderItem Item { get; private set; }

        public FileFolderItemEventArgs(FileFolderItem item)
        {
            Item = item;
        }
    }

    // Custom control for displaying file/folder items
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(FileFolderItem))]
    public class FileFolderItem : Panel
    {
        // Event for when an item is double-clicked
        public event EventHandler<FileFolderItemEventArgs> OnItemDoubleClicked;
        public event EventHandler ItemsChanges;

        // Event handler for when the mouse enters an item
        private void FileFolderItem_MouseEnter(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                Color parentColor = this.Parent.BackColor;
                int fadeAmount = 2;
                this.BackColor = ControlPaint.Light(parentColor, fadeAmount);
                this.Cursor = Cursors.Hand;
            }
           
        }

        // Event handler for when the mouse leaves an item
        private void FileFolderItem_MouseLeave(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.BackColor = this.Parent.BackColor;
            }
            this.Cursor = Cursors.Default;
        }

        // Event handler for when the mouse leaves an item
        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Get the clicked item
            ToolStripItem clickedItem = e.ClickedItem;

            if (clickedItem.Text == "Rename")
            {
                new Popup("Rename", this.Path).ShowDialog();
                this.ItemsChanges?.Invoke(this, new EventArgs());
            }
            else if (clickedItem.Text == "Delete")
            {
                new Popup("Delete", this.Path).ShowDialog();
                this.ItemsChanges?.Invoke(this, new EventArgs());
            }
        }
        private void _MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 2)
                {
                    OnItemDoubleClicked?.Invoke(this, new FileFolderItemEventArgs(this));
                }
                else
                {
                    // Drag-and-drop event
                    this.DoDragDrop(this, DragDropEffects.Move);
                }
            }
        }

        private void _DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged item is a panel
            if (e.Data.GetDataPresent(typeof(FileFolderItem)))
            {
                e.Effect = DragDropEffects.Move; // Allow the drop
            }
            else
            {
                e.Effect = DragDropEffects.None; // Don't allow the drop
            }
        }

        private void _DragDrop(object sender, DragEventArgs e)
        {
            FileFolderItem droppedPanel = (FileFolderItem)e.Data.GetData(typeof(FileFolderItem));
            string item_path = droppedPanel.Path;
            FileFolderItem dropPanel = (FileFolderItem)sender;
            string target_path = dropPanel.Path;
            if (item_path != this.Path)
            {
                if (File.Exists(item_path))
                {
                    string[] splipted_path = item_path.Split(new string[] { @"\" }, StringSplitOptions.None);
                    string last_part_of_split = splipted_path[splipted_path.Length - 1];
                    File.Move(item_path, $@"{target_path}\{last_part_of_split}");
                    this.ItemsChanges?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    string[] splipted_path = item_path.Split(new string[] { @"\" }, StringSplitOptions.None);
                    string last_part_of_split = splipted_path[splipted_path.Length - 1];
                    Directory.Move(item_path, $@"{target_path}\{last_part_of_split}");
                    this.ItemsChanges?.Invoke(this, EventArgs.Empty);
                }

            }
        }



        // Public properties
        public string Path { get; set; }

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

        // Private fields

        private ContextMenuStrip _ContextMenu;
        private Label label { get; set; }
        private PictureBox pictureBox { get; set; }
        private string _text;
        private Image _image;

        // Constructor
        public FileFolderItem()
        {
            //Create Context Menu
            _ContextMenu = new ContextMenuStrip();
            _ContextMenu.Items.Add("Rename");
            _ContextMenu.Items.Add("Delete");
            _ContextMenu.ItemClicked += contextMenuStrip_ItemClicked;
            this.ContextMenuStrip = _ContextMenu;
            // Create the body of the FileFolderItem (add text and image)
            label = new Label();
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.Dock = DockStyle.Fill;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.AutoSize = false;
            Panel labpan = new Panel();
            Panel picpan = new Panel();
            picpan.Height = pictureBox.Height;
            labpan.Controls.Add(label);
            picpan.Controls.Add(pictureBox);
            picpan.Dock = DockStyle.Top;
            labpan.Dock = DockStyle.Bottom;
            this.Controls.Add(picpan);
            this.Controls.Add(labpan);

            // Connect events to appropriate methods
            this.MouseEnter += new EventHandler(FileFolderItem_MouseEnter);
            label.MouseEnter += new EventHandler(FileFolderItem_MouseEnter);
            pictureBox.MouseEnter += new EventHandler(FileFolderItem_MouseEnter);
            this.MouseLeave += new EventHandler(FileFolderItem_MouseLeave);
            label.MouseLeave += new EventHandler(FileFolderItem_MouseLeave);
            pictureBox.MouseLeave += new EventHandler(FileFolderItem_MouseLeave);
            this.MouseDown += _MouseDown;
            label.MouseDown += _MouseDown;
            pictureBox.MouseDown += _MouseDown;
            this.AllowDrop = true;
            this.DragEnter += _DragEnter;
            label.DragEnter += _DragEnter;
            pictureBox.DragEnter += _DragEnter;
            this.DragDrop += _DragDrop;
            label.DragDrop += _DragDrop;
            pictureBox.DragDrop += _DragDrop;

        }

        // Public methods

        // Private functions
    }

    // Custom collection class for managing file/folder items
    public class FileFolderCollection : IEnumerable<FileFolderItem>
    {
        // Event for when an item in the collection changes
        public event EventHandler ItemChanged;
        public event EventHandler ItemChangedFromItem;

        // Event for when an item in the collection is double-clicked
        public event EventHandler<FileFolderItemEventArgs> ItemDoubleClicked;

        // Event handler for double-clicking on an item in the collection
        private void Item_DoubleClicked(object sender, FileFolderItemEventArgs e)
        {
            FileFolderItem item = e.Item;
            ItemDoubleClicked?.Invoke(this, e);
        }
        // Event handler for item change on an item in the collection
        private void Item_ChangedFromItem(object sender, EventArgs e)
        {
            ItemChangedFromItem?.Invoke(this, EventArgs.Empty);
        }


        // Internal fields and properties
        private List<FileFolderItem> _items = new List<FileFolderItem>();

        // Constructor
        public FileFolderCollection() { }

        // Public methods
        public void Add(FileFolderItem item)
        {
            item.OnItemDoubleClicked += Item_DoubleClicked;
            item.ItemsChanges += Item_ChangedFromItem;
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

        // Methods required for IEnumerable implementation to allow the class to be enumerated properly
        public IEnumerator<FileFolderItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    // Custom control for displaying a list of file/folder items
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(FileFolderListView))]
    public class FileFolderListView : Panel
    {
        // Event for when an item in the list is double-clicked
        public event EventHandler<FileFolderItemEventArgs> ItemDoubleClicked;
        public event EventHandler ItemsChanged;

        // Event handler for when an item in the collection changes
        private void HandleItemChanged(object sender, EventArgs e)
        {
            DrawList(true);
        }
        private void HandleItemsInternalChanged(object sender, EventArgs e)
        {
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        // Event handler for when the control's size changes
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            DrawList(false);
        }
        // Event handler for when the control's sgot an item clicked
        private void HandleItemClicked(object sender, FileFolderItemEventArgs e)
        {
            FileFolderItem item = e.Item;
            ItemDoubleClicked?.Invoke(this, new FileFolderItemEventArgs(item));
        }

        // Internal fields and properties
        private int RowX { get; set; }
        private int RowY { get; set; }
        private int RowWidth { get; set; }
        private int RowHeight { get; set; }
        private int RowCount { get; set; }
        private int RowMaxCount { get; set; }

        // Public fields and properties
        public FileFolderCollection Items { get; }

        // Constructor
        public FileFolderListView()
        {
            RowX = 0;
            RowY = 0;
            RowCount = 0;
            RowWidth = 95;
            RowHeight = 125;

            Items = new FileFolderCollection();
            Items.ItemChangedFromItem += HandleItemsInternalChanged;
            Items.ItemChanged += HandleItemChanged;
            Items.ItemDoubleClicked += HandleItemClicked;

            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = false;
        }

        // Public methods

        // Internal functions
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
