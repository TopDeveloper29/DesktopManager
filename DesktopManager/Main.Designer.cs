using MaterialSkin.Controls;

namespace DesktopManager
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.back_p = new System.Windows.Forms.Panel();
            this.back_bt = new MaterialSkin.Controls.MaterialButton();
            this.global_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bottom = new System.Windows.Forms.Panel();
            this.path_box = new MaterialSkin.Controls.MaterialTextBox();
            this.home_p = new System.Windows.Forms.Panel();
            this.home_bt = new MaterialSkin.Controls.MaterialButton();
            
            this.MainContextMenu = new MaterialContextMenuStrip();
            this.createDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainList = new FileFolder.FileFolderListView();
            this.fileFolderItem1 = new FileFolder.FileFolderItem();
            this.back_p.SuspendLayout();
            this.global_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bottom.SuspendLayout();
            this.home_p.SuspendLayout();
            this.MainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_p
            // 
            this.back_p.Controls.Add(this.back_bt);
            this.back_p.Dock = System.Windows.Forms.DockStyle.Left;
            this.back_p.Location = new System.Drawing.Point(0, 0);
            this.back_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_p.Name = "back_p";
            this.back_p.Size = new System.Drawing.Size(119, 40);
            this.back_p.TabIndex = 2;
            // 
            // back_bt
            // 
            this.back_bt.AllowDrop = true;
            this.back_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.back_bt.Depth = 0;
            this.back_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_bt.HighEmphasis = true;
            this.back_bt.Icon = null;
            this.back_bt.Location = new System.Drawing.Point(0, 0);
            this.back_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_bt.Name = "back_bt";
            this.back_bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.back_bt.Size = new System.Drawing.Size(119, 40);
            this.back_bt.TabIndex = 0;
            this.back_bt.Text = "Back";
            this.back_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.back_bt.UseAccentColor = false;
            this.back_bt.UseVisualStyleBackColor = true;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            this.back_bt.DragDrop += new System.Windows.Forms.DragEventHandler(this.back_bt_DragDrop);
            this.back_bt.DragEnter += new System.Windows.Forms.DragEventHandler(this.back_bt_DragEnter);
            // 
            // global_panel
            // 
            this.global_panel.Controls.Add(this.panel2);
            this.global_panel.Controls.Add(this.home_p);
            this.global_panel.Controls.Add(this.back_p);
            this.global_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.global_panel.Location = new System.Drawing.Point(4, 511);
            this.global_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.global_panel.Name = "global_panel";
            this.global_panel.Size = new System.Drawing.Size(952, 40);
            this.global_panel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bottom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(119, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 40);
            this.panel2.TabIndex = 4;
            // 
            // bottom
            // 
            this.bottom.Controls.Add(this.path_box);
            this.bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom.Location = new System.Drawing.Point(0, 0);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(724, 40);
            this.bottom.TabIndex = 1;
            // 
            // path_box
            // 
            this.path_box.AnimateReadOnly = true;
            this.path_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path_box.Depth = 0;
            this.path_box.DetectUrls = false;
            this.path_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.path_box.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.path_box.Hint = "Current Path";
            this.path_box.LeadingIcon = null;
            this.path_box.Location = new System.Drawing.Point(0, 0);
            this.path_box.MaxLength = 50;
            this.path_box.MouseState = MaterialSkin.MouseState.OUT;
            this.path_box.Multiline = false;
            this.path_box.Name = "path_box";
            this.path_box.ReadOnly = true;
            this.path_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.path_box.ShortcutsEnabled = false;
            this.path_box.Size = new System.Drawing.Size(724, 36);
            this.path_box.TabIndex = 0;
            this.path_box.Text = "";
            this.path_box.TrailingIcon = null;
            this.path_box.UseTallSize = false;
            // 
            // home_p
            // 
            this.home_p.Controls.Add(this.home_bt);
            this.home_p.Dock = System.Windows.Forms.DockStyle.Right;
            this.home_p.Location = new System.Drawing.Point(843, 0);
            this.home_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home_p.Name = "home_p";
            this.home_p.Size = new System.Drawing.Size(109, 40);
            this.home_p.TabIndex = 3;
            // 
            // home_bt
            // 
            this.home_bt.AllowDrop = true;
            this.home_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.home_bt.Depth = 0;
            this.home_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_bt.HighEmphasis = true;
            this.home_bt.Icon = null;
            this.home_bt.Location = new System.Drawing.Point(0, 0);
            this.home_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.home_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.home_bt.Name = "home_bt";
            this.home_bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.home_bt.Size = new System.Drawing.Size(109, 40);
            this.home_bt.TabIndex = 0;
            this.home_bt.Text = "Home";
            this.home_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.home_bt.UseAccentColor = false;
            this.home_bt.UseVisualStyleBackColor = true;
            this.home_bt.Click += new System.EventHandler(this.home_bt_Click);
            this.home_bt.DragDrop += new System.Windows.Forms.DragEventHandler(this.home_bt_DragDrop);
            this.home_bt.DragEnter += new System.Windows.Forms.DragEventHandler(this.home_bt_DragEnter);
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDirectoryToolStripMenuItem,
            this.createFileToolStripMenuItem});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.Size = new System.Drawing.Size(174, 52);
            // 
            // createDirectoryToolStripMenuItem
            // 
            this.createDirectoryToolStripMenuItem.Name = "createDirectoryToolStripMenuItem";
            this.createDirectoryToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.createDirectoryToolStripMenuItem.Text = "New Directory";
            this.createDirectoryToolStripMenuItem.Click += new System.EventHandler(this.createDirectoryToolStripMenuItem_Click);
            // 
            // createFileToolStripMenuItem
            // 
            this.createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            this.createFileToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.createFileToolStripMenuItem.Text = "New File";
            this.createFileToolStripMenuItem.Click += new System.EventHandler(this.createFileToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(362, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // MainList
            // 
            this.MainList.AutoScroll = true;
            this.MainList.BackColor = System.Drawing.Color.White;
            this.MainList.ContextMenuStrip = this.MainContextMenu;
            this.MainList.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainList.Location = new System.Drawing.Point(4, 30);
            this.MainList.Margin = new System.Windows.Forms.Padding(4);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(952, 475);
            this.MainList.TabIndex = 0;
            // 
            // fileFolderItem1
            // 
            this.fileFolderItem1.AllowDrop = true;
            this.fileFolderItem1.Location = new System.Drawing.Point(0, 0);
            this.fileFolderItem1.Name = "fileFolderItem1";
            this.fileFolderItem1.Path = null;
            this.fileFolderItem1.Picture = null;
            this.fileFolderItem1.Size = new System.Drawing.Size(200, 100);
            this.fileFolderItem1.TabIndex = 0;
            this.fileFolderItem1.Text = null;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 555);
            this.Controls.Add(this.global_panel);
            this.Controls.Add(this.MainList);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.Padding = new System.Windows.Forms.Padding(4, 30, 4, 4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.back_p.ResumeLayout(false);
            this.back_p.PerformLayout();
            this.global_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.bottom.ResumeLayout(false);
            this.home_p.ResumeLayout(false);
            this.home_p.PerformLayout();
            this.MainContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FileFolder.FileFolderListView MainList;
        private FileFolder.FileFolderItem fileFolderItem1;
        private System.Windows.Forms.Panel back_p;
        private System.Windows.Forms.Panel global_panel;
        private System.Windows.Forms.Panel home_p;
        private MaterialSkin.Controls.MaterialButton back_bt;
        private MaterialSkin.Controls.MaterialButton home_bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem createDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel bottom;
        private MaterialSkin.Controls.MaterialTextBox path_box;
    }
}

