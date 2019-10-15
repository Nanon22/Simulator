namespace ProjetInterne
{
    partial class ChoixNombreRouter
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixNombreRouter));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NombreRouterBox = new System.Windows.Forms.NumericUpDown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NbRouterHeader = new System.Windows.Forms.Panel();
            this.NbRouterClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NombreRouterBox)).BeginInit();
            this.NbRouterHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(143, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner le nombre de machines";
            // 
            // NombreRouterBox
            // 
            this.NombreRouterBox.Location = new System.Drawing.Point(239, 150);
            this.NombreRouterBox.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NombreRouterBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NombreRouterBox.Name = "NombreRouterBox";
            this.NombreRouterBox.ReadOnly = true;
            this.NombreRouterBox.Size = new System.Drawing.Size(52, 20);
            this.NombreRouterBox.TabIndex = 1;
            this.NombreRouterBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Confirmer";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(393, 230);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(125, 48);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Confirmer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Corbel", 10F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // NbRouterHeader
            // 
            this.NbRouterHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NbRouterHeader.Controls.Add(this.NbRouterClose);
            this.NbRouterHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.NbRouterHeader.Location = new System.Drawing.Point(0, 0);
            this.NbRouterHeader.Name = "NbRouterHeader";
            this.NbRouterHeader.Size = new System.Drawing.Size(547, 37);
            this.NbRouterHeader.TabIndex = 3;
            // 
            // NbRouterClose
            // 
            this.NbRouterClose.ActiveImage = null;
            this.NbRouterClose.AllowAnimations = true;
            this.NbRouterClose.AllowZooming = true;
            this.NbRouterClose.BackColor = System.Drawing.Color.Transparent;
            this.NbRouterClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("NbRouterClose.ErrorImage")));
            this.NbRouterClose.FadeWhenInactive = false;
            this.NbRouterClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.NbRouterClose.Image = global::ProjetInterne.Properties.Resources.SoftwareTools13;
            this.NbRouterClose.ImageActive = null;
            this.NbRouterClose.ImageLocation = null;
            this.NbRouterClose.ImageMargin = 5;
            this.NbRouterClose.ImageSize = new System.Drawing.Size(21, 22);
            this.NbRouterClose.ImageZoomSize = new System.Drawing.Size(26, 27);
            this.NbRouterClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("NbRouterClose.InitialImage")));
            this.NbRouterClose.Location = new System.Drawing.Point(509, 7);
            this.NbRouterClose.Name = "NbRouterClose";
            this.NbRouterClose.Rotation = 0;
            this.NbRouterClose.ShowActiveImage = true;
            this.NbRouterClose.ShowCursorChanges = true;
            this.NbRouterClose.ShowImageBorders = false;
            this.NbRouterClose.ShowSizeMarkers = false;
            this.NbRouterClose.Size = new System.Drawing.Size(26, 27);
            this.NbRouterClose.TabIndex = 4;
            this.NbRouterClose.ToolTipText = "";
            this.NbRouterClose.WaitOnLoad = false;
            this.NbRouterClose.Zoom = 5;
            this.NbRouterClose.ZoomSpeed = 10;
            this.NbRouterClose.Click += new System.EventHandler(this.NbRouterClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.NbRouterHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ChoixNombreRouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 290);
            this.Controls.Add(this.NbRouterHeader);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.NombreRouterBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoixNombreRouter";
            this.Text = "ChoixNombreRouter";
            ((System.ComponentModel.ISupportInitialize)(this.NombreRouterBox)).EndInit();
            this.NbRouterHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.NumericUpDown NombreRouterBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel NbRouterHeader;
        private Bunifu.UI.WinForms.BunifuImageButton NbRouterClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}