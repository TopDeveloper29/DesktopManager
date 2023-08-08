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
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.MainList = new FileFolder.FileFolderListView();
            this.SuspendLayout();
            // 
            // icons
            // 
            this.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.icons.ImageSize = new System.Drawing.Size(16, 16);
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainList
            // 
            this.MainList.AutoScroll = true;
            this.MainList.BackColor = System.Drawing.Color.White;
            this.MainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainList.Location = new System.Drawing.Point(3, 24);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(714, 380);
            this.MainList.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 407);
            this.Controls.Add(this.MainList);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList icons;
        private FileFolder.FileFolderListView MainList;
    }
}

