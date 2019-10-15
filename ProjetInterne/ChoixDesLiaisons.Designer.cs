namespace ProjetInterne
{
    partial class ChoixDesLiaisons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixDesLiaisons));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LiaisonMainFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.LiaisonHeader = new System.Windows.Forms.Panel();
            this.LiaisonFormClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LiaisonHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LiaisonMainFlow
            // 
            this.LiaisonMainFlow.AutoScroll = true;
            this.LiaisonMainFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LiaisonMainFlow.Location = new System.Drawing.Point(64, 39);
            this.LiaisonMainFlow.Name = "LiaisonMainFlow";
            this.LiaisonMainFlow.Size = new System.Drawing.Size(340, 215);
            this.LiaisonMainFlow.TabIndex = 0;
            this.LiaisonMainFlow.WrapContents = false;
            // 
            // LiaisonHeader
            // 
            this.LiaisonHeader.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LiaisonHeader.Controls.Add(this.LiaisonFormClose);
            this.LiaisonHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LiaisonHeader.Location = new System.Drawing.Point(0, 0);
            this.LiaisonHeader.Name = "LiaisonHeader";
            this.LiaisonHeader.Size = new System.Drawing.Size(547, 33);
            this.LiaisonHeader.TabIndex = 1;
            // 
            // LiaisonFormClose
            // 
            this.LiaisonFormClose.ActiveImage = null;
            this.LiaisonFormClose.AllowAnimations = true;
            this.LiaisonFormClose.AllowZooming = true;
            this.LiaisonFormClose.BackColor = System.Drawing.Color.Transparent;
            this.LiaisonFormClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("LiaisonFormClose.ErrorImage")));
            this.LiaisonFormClose.FadeWhenInactive = false;
            this.LiaisonFormClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.LiaisonFormClose.Image = global::ProjetInterne.Properties.Resources.SoftwareTools13;
            this.LiaisonFormClose.ImageActive = null;
            this.LiaisonFormClose.ImageLocation = null;
            this.LiaisonFormClose.ImageMargin = 5;
            this.LiaisonFormClose.ImageSize = new System.Drawing.Size(20, 19);
            this.LiaisonFormClose.ImageZoomSize = new System.Drawing.Size(25, 24);
            this.LiaisonFormClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("LiaisonFormClose.InitialImage")));
            this.LiaisonFormClose.Location = new System.Drawing.Point(510, 6);
            this.LiaisonFormClose.Name = "LiaisonFormClose";
            this.LiaisonFormClose.Rotation = 0;
            this.LiaisonFormClose.ShowActiveImage = true;
            this.LiaisonFormClose.ShowCursorChanges = true;
            this.LiaisonFormClose.ShowImageBorders = false;
            this.LiaisonFormClose.ShowSizeMarkers = false;
            this.LiaisonFormClose.Size = new System.Drawing.Size(25, 24);
            this.LiaisonFormClose.TabIndex = 2;
            this.LiaisonFormClose.ToolTipText = "";
            this.LiaisonFormClose.WaitOnLoad = false;
            this.LiaisonFormClose.Zoom = 5;
            this.LiaisonFormClose.ZoomSpeed = 10;
            this.LiaisonFormClose.Click += new System.EventHandler(this.LiaisonFormClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.LiaisonHeader;
            this.bunifuDragControl1.Vertical = true;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(410, 206);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(125, 48);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Confirmer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Corbel", 10F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // ChoixDesLiaisons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 290);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.LiaisonHeader);
            this.Controls.Add(this.LiaisonMainFlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoixDesLiaisons";
            this.Text = "ChoixDesLiaisons";
            this.LiaisonHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel LiaisonMainFlow;
        private System.Windows.Forms.Panel LiaisonHeader;
        private Bunifu.UI.WinForms.BunifuImageButton LiaisonFormClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}