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
            this.back_p = new System.Windows.Forms.Panel();
            this.global_panel = new System.Windows.Forms.Panel();
            this.home_p = new System.Windows.Forms.Panel();
            this.back_bt = new MaterialSkin.Controls.MaterialButton();
            this.home_bt = new MaterialSkin.Controls.MaterialButton();
            this.MainList = new FileFolder.FileFolderListView();
            this.fileFolderItem1 = new FileFolder.FileFolderItem();
            this.back_p.SuspendLayout();
            this.global_panel.SuspendLayout();
            this.home_p.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_p
            // 
            this.back_p.Controls.Add(this.back_bt);
            this.back_p.Dock = System.Windows.Forms.DockStyle.Left;
            this.back_p.Location = new System.Drawing.Point(0, 0);
            this.back_p.Name = "back_p";
            this.back_p.Size = new System.Drawing.Size(134, 58);
            this.back_p.TabIndex = 2;
            // 
            // global_panel
            // 
            this.global_panel.Controls.Add(this.home_p);
            this.global_panel.Controls.Add(this.back_p);
            this.global_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.global_panel.Location = new System.Drawing.Point(4, 563);
            this.global_panel.Name = "global_panel";
            this.global_panel.Size = new System.Drawing.Size(1072, 58);
            this.global_panel.TabIndex = 3;
            // 
            // home_p
            // 
            this.home_p.Controls.Add(this.home_bt);
            this.home_p.Dock = System.Windows.Forms.DockStyle.Right;
            this.home_p.Location = new System.Drawing.Point(949, 0);
            this.home_p.Name = "home_p";
            this.home_p.Size = new System.Drawing.Size(123, 58);
            this.home_p.TabIndex = 3;
            // 
            // back_bt
            // 
            this.back_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.back_bt.Depth = 0;
            this.back_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_bt.HighEmphasis = true;
            this.back_bt.Icon = null;
            this.back_bt.Location = new System.Drawing.Point(0, 0);
            this.back_bt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.back_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_bt.Name = "back_bt";
            this.back_bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.back_bt.Size = new System.Drawing.Size(134, 58);
            this.back_bt.TabIndex = 0;
            this.back_bt.Text = "Back";
            this.back_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.back_bt.UseAccentColor = false;
            this.back_bt.UseVisualStyleBackColor = true;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // home_bt
            // 
            this.home_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.home_bt.Depth = 0;
            this.home_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_bt.HighEmphasis = true;
            this.home_bt.Icon = null;
            this.home_bt.Location = new System.Drawing.Point(0, 0);
            this.home_bt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.home_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.home_bt.Name = "home_bt";
            this.home_bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.home_bt.Size = new System.Drawing.Size(123, 58);
            this.home_bt.TabIndex = 0;
            this.home_bt.Text = "Home";
            this.home_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.home_bt.UseAccentColor = false;
            this.home_bt.UseVisualStyleBackColor = true;
            this.home_bt.Click += new System.EventHandler(this.home_bt_Click);
            // 
            // MainList
            // 
            this.MainList.AutoScroll = true;
            this.MainList.BackColor = System.Drawing.Color.White;
            this.MainList.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainList.Location = new System.Drawing.Point(4, 37);
            this.MainList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(1072, 521);
            this.MainList.TabIndex = 0;
            // 
            // fileFolderItem1
            // 
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 626);
            this.Controls.Add(this.global_panel);
            this.Controls.Add(this.MainList);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.Padding = new System.Windows.Forms.Padding(4, 37, 4, 5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.back_p.ResumeLayout(false);
            this.back_p.PerformLayout();
            this.global_panel.ResumeLayout(false);
            this.home_p.ResumeLayout(false);
            this.home_p.PerformLayout();
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
    }
}

