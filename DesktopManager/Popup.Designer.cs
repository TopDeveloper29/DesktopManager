namespace DesktopManager
{
    partial class Popup
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.body = new System.Windows.Forms.Panel();
            this.text_box = new MaterialSkin.Controls.MaterialTextBox2();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ok_bt = new MaterialSkin.Controls.MaterialButton();
            this.cancel_bt = new MaterialSkin.Controls.MaterialButton();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.Controls.Add(this.text_box);
            this.body.Controls.Add(this.splitContainer1);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(3, 88);
            this.body.Margin = new System.Windows.Forms.Padding(2);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(578, 113);
            this.body.TabIndex = 1;
            // 
            // text_box
            // 
            this.text_box.AnimateReadOnly = false;
            this.text_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.text_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text_box.Depth = 0;
            this.text_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.text_box.HideSelection = true;
            this.text_box.Hint = "New Name";
            this.text_box.LeadingIcon = null;
            this.text_box.LeaveOnEnterKey = true;
            this.text_box.Location = new System.Drawing.Point(0, 0);
            this.text_box.Margin = new System.Windows.Forms.Padding(2);
            this.text_box.MaxLength = 32767;
            this.text_box.MouseState = MaterialSkin.MouseState.OUT;
            this.text_box.Name = "text_box";
            this.text_box.PasswordChar = '\0';
            this.text_box.PrefixSuffixText = null;
            this.text_box.ReadOnly = false;
            this.text_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_box.SelectedText = "";
            this.text_box.SelectionLength = 0;
            this.text_box.SelectionStart = 0;
            this.text_box.ShortcutsEnabled = true;
            this.text_box.Size = new System.Drawing.Size(578, 48);
            this.text_box.TabIndex = 0;
            this.text_box.TabStop = false;
            this.text_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_box.TrailingIcon = null;
            this.text_box.UseSystemPasswordChar = false;
            this.text_box.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 65);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ok_bt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cancel_bt);
            this.splitContainer1.Size = new System.Drawing.Size(578, 48);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // ok_bt
            // 
            this.ok_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ok_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ok_bt.Depth = 0;
            this.ok_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok_bt.HighEmphasis = true;
            this.ok_bt.Icon = null;
            this.ok_bt.Location = new System.Drawing.Point(0, 0);
            this.ok_bt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ok_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ok_bt.Size = new System.Drawing.Size(281, 48);
            this.ok_bt.TabIndex = 0;
            this.ok_bt.Text = "Ok";
            this.ok_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ok_bt.UseAccentColor = false;
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancel_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancel_bt.Depth = 0;
            this.cancel_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel_bt.HighEmphasis = true;
            this.cancel_bt.Icon = null;
            this.cancel_bt.Location = new System.Drawing.Point(0, 0);
            this.cancel_bt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancel_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancel_bt.Size = new System.Drawing.Size(295, 48);
            this.cancel_bt.TabIndex = 1;
            this.cancel_bt.Text = "Cancel";
            this.cancel_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancel_bt.UseAccentColor = false;
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 7F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 203);
            this.Controls.Add(this.body);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(3, 88, 2, 2);
            this.body.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialButton ok_bt;
        private MaterialSkin.Controls.MaterialButton cancel_bt;
        private MaterialSkin.Controls.MaterialTextBox2 text_box;
    }
}
