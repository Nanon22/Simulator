namespace ProjetInterne
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Barre = new System.Windows.Forms.Panel();
            this.BoutonRetour = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BoutonRetourMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChoixLiaisonPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BoutonValidLiaison = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LiaisonMainFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.NombreRouterPanel = new System.Windows.Forms.Panel();
            this.BoutonValidNbRouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NombreRouterBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelBonjour = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.espaceRouter = new System.Windows.Forms.Panel();
            this.algoInfoTitre = new System.Windows.Forms.Label();
            this.algoInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.algoComboBox = new System.Windows.Forms.ComboBox();
            this.algoDestinantion = new System.Windows.Forms.NumericUpDown();
            this.algoSource = new System.Windows.Forms.NumericUpDown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuHScrollBar1 = new Bunifu.UI.WinForms.BunifuHScrollBar();
            this.boutonReduction = new Bunifu.UI.WinForms.BunifuImageButton();
            this.CloseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BoutonDessinOptimal = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Barre.SuspendLayout();
            this.ChoixLiaisonPanel.SuspendLayout();
            this.NombreRouterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombreRouterBox)).BeginInit();
            this.PanelBonjour.SuspendLayout();
            this.espaceRouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.algoDestinantion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.algoSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Barre
            // 
            this.Barre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Barre.Controls.Add(this.boutonReduction);
            this.Barre.Controls.Add(this.BoutonRetour);
            this.Barre.Controls.Add(this.BoutonRetourMenu);
            this.Barre.Controls.Add(this.ChoixLiaisonPanel);
            this.Barre.Controls.Add(this.NombreRouterPanel);
            this.Barre.Controls.Add(this.PanelBonjour);
            this.Barre.Controls.Add(this.CloseButton);
            this.Barre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barre.Location = new System.Drawing.Point(0, 0);
            this.Barre.Name = "Barre";
            this.Barre.Size = new System.Drawing.Size(1351, 41);
            this.Barre.TabIndex = 0;
            // 
            // BoutonRetour
            // 
            this.BoutonRetour.Active = false;
            this.BoutonRetour.Activecolor = System.Drawing.Color.Transparent;
            this.BoutonRetour.BackColor = System.Drawing.Color.Transparent;
            this.BoutonRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutonRetour.BorderRadius = 0;
            this.BoutonRetour.ButtonText = "Retour en arriere";
            this.BoutonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoutonRetour.DisabledColor = System.Drawing.Color.Gray;
            this.BoutonRetour.Iconcolor = System.Drawing.Color.Transparent;
            this.BoutonRetour.Iconimage = null;
            this.BoutonRetour.Iconimage_right = null;
            this.BoutonRetour.Iconimage_right_Selected = null;
            this.BoutonRetour.Iconimage_Selected = null;
            this.BoutonRetour.IconMarginLeft = 0;
            this.BoutonRetour.IconMarginRight = 0;
            this.BoutonRetour.IconRightVisible = true;
            this.BoutonRetour.IconRightZoom = 0D;
            this.BoutonRetour.IconVisible = true;
            this.BoutonRetour.IconZoom = 90D;
            this.BoutonRetour.IsTab = false;
            this.BoutonRetour.Location = new System.Drawing.Point(865, 0);
            this.BoutonRetour.Name = "BoutonRetour";
            this.BoutonRetour.Normalcolor = System.Drawing.Color.Transparent;
            this.BoutonRetour.OnHovercolor = System.Drawing.Color.Transparent;
            this.BoutonRetour.OnHoverTextColor = System.Drawing.Color.LightSlateGray;
            this.BoutonRetour.selected = false;
            this.BoutonRetour.Size = new System.Drawing.Size(119, 38);
            this.BoutonRetour.TabIndex = 13;
            this.BoutonRetour.Text = "Retour en arriere";
            this.BoutonRetour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BoutonRetour.Textcolor = System.Drawing.Color.Black;
            this.BoutonRetour.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BoutonRetour.Click += new System.EventHandler(this.BoutonRetour_Click);
            // 
            // BoutonRetourMenu
            // 
            this.BoutonRetourMenu.Active = false;
            this.BoutonRetourMenu.Activecolor = System.Drawing.Color.Transparent;
            this.BoutonRetourMenu.BackColor = System.Drawing.Color.Transparent;
            this.BoutonRetourMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutonRetourMenu.BorderRadius = 0;
            this.BoutonRetourMenu.ButtonText = "Créer nouveau réseau";
            this.BoutonRetourMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoutonRetourMenu.DisabledColor = System.Drawing.Color.Gray;
            this.BoutonRetourMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.BoutonRetourMenu.Iconimage = null;
            this.BoutonRetourMenu.Iconimage_right = null;
            this.BoutonRetourMenu.Iconimage_right_Selected = null;
            this.BoutonRetourMenu.Iconimage_Selected = null;
            this.BoutonRetourMenu.IconMarginLeft = 0;
            this.BoutonRetourMenu.IconMarginRight = 0;
            this.BoutonRetourMenu.IconRightVisible = true;
            this.BoutonRetourMenu.IconRightZoom = 0D;
            this.BoutonRetourMenu.IconVisible = true;
            this.BoutonRetourMenu.IconZoom = 90D;
            this.BoutonRetourMenu.IsTab = false;
            this.BoutonRetourMenu.Location = new System.Drawing.Point(309, 3);
            this.BoutonRetourMenu.Name = "BoutonRetourMenu";
            this.BoutonRetourMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.BoutonRetourMenu.OnHovercolor = System.Drawing.Color.Transparent;
            this.BoutonRetourMenu.OnHoverTextColor = System.Drawing.Color.LightSlateGray;
            this.BoutonRetourMenu.selected = false;
            this.BoutonRetourMenu.Size = new System.Drawing.Size(171, 38);
            this.BoutonRetourMenu.TabIndex = 12;
            this.BoutonRetourMenu.Text = "Créer nouveau réseau";
            this.BoutonRetourMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BoutonRetourMenu.Textcolor = System.Drawing.Color.Black;
            this.BoutonRetourMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BoutonRetourMenu.Click += new System.EventHandler(this.BoutonRetourMenu_Click);
            // 
            // ChoixLiaisonPanel
            // 
            this.ChoixLiaisonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoixLiaisonPanel.Controls.Add(this.label4);
            this.ChoixLiaisonPanel.Controls.Add(this.BoutonValidLiaison);
            this.ChoixLiaisonPanel.Controls.Add(this.LiaisonMainFlow);
            this.ChoixLiaisonPanel.Location = new System.Drawing.Point(578, 10);
            this.ChoixLiaisonPanel.Name = "ChoixLiaisonPanel";
            this.ChoixLiaisonPanel.Size = new System.Drawing.Size(25, 24);
            this.ChoixLiaisonPanel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-93, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Determiner Les Liaisons";
            // 
            // BoutonValidLiaison
            // 
            this.BoutonValidLiaison.Active = false;
            this.BoutonValidLiaison.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BoutonValidLiaison.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonValidLiaison.BackColor = System.Drawing.Color.DimGray;
            this.BoutonValidLiaison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutonValidLiaison.BorderRadius = 0;
            this.BoutonValidLiaison.ButtonText = "Confirmer";
            this.BoutonValidLiaison.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoutonValidLiaison.DisabledColor = System.Drawing.Color.Gray;
            this.BoutonValidLiaison.Iconcolor = System.Drawing.Color.Transparent;
            this.BoutonValidLiaison.Iconimage = null;
            this.BoutonValidLiaison.Iconimage_right = null;
            this.BoutonValidLiaison.Iconimage_right_Selected = null;
            this.BoutonValidLiaison.Iconimage_Selected = null;
            this.BoutonValidLiaison.IconMarginLeft = 0;
            this.BoutonValidLiaison.IconMarginRight = 0;
            this.BoutonValidLiaison.IconRightVisible = true;
            this.BoutonValidLiaison.IconRightZoom = 0D;
            this.BoutonValidLiaison.IconVisible = true;
            this.BoutonValidLiaison.IconZoom = 90D;
            this.BoutonValidLiaison.IsTab = false;
            this.BoutonValidLiaison.Location = new System.Drawing.Point(-169, -60);
            this.BoutonValidLiaison.Name = "BoutonValidLiaison";
            this.BoutonValidLiaison.Normalcolor = System.Drawing.Color.DimGray;
            this.BoutonValidLiaison.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.BoutonValidLiaison.OnHoverTextColor = System.Drawing.Color.White;
            this.BoutonValidLiaison.selected = false;
            this.BoutonValidLiaison.Size = new System.Drawing.Size(159, 48);
            this.BoutonValidLiaison.TabIndex = 5;
            this.BoutonValidLiaison.Text = "Confirmer";
            this.BoutonValidLiaison.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoutonValidLiaison.Textcolor = System.Drawing.Color.LightGray;
            this.BoutonValidLiaison.TextFont = new System.Drawing.Font("Corbel", 10F);
            this.BoutonValidLiaison.Click += new System.EventHandler(this.BoutonValidLiaison_Click);
            // 
            // LiaisonMainFlow
            // 
            this.LiaisonMainFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LiaisonMainFlow.AutoScroll = true;
            this.LiaisonMainFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LiaisonMainFlow.Location = new System.Drawing.Point(-583, -249);
            this.LiaisonMainFlow.Name = "LiaisonMainFlow";
            this.LiaisonMainFlow.Size = new System.Drawing.Size(1051, 528);
            this.LiaisonMainFlow.TabIndex = 4;
            this.LiaisonMainFlow.WrapContents = false;
            // 
            // NombreRouterPanel
            // 
            this.NombreRouterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreRouterPanel.Controls.Add(this.BoutonValidNbRouter);
            this.NombreRouterPanel.Controls.Add(this.NombreRouterBox);
            this.NombreRouterPanel.Controls.Add(this.label2);
            this.NombreRouterPanel.Location = new System.Drawing.Point(538, 11);
            this.NombreRouterPanel.Name = "NombreRouterPanel";
            this.NombreRouterPanel.Size = new System.Drawing.Size(25, 25);
            this.NombreRouterPanel.TabIndex = 7;
            // 
            // BoutonValidNbRouter
            // 
            this.BoutonValidNbRouter.Active = false;
            this.BoutonValidNbRouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BoutonValidNbRouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoutonValidNbRouter.BackColor = System.Drawing.Color.DimGray;
            this.BoutonValidNbRouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutonValidNbRouter.BorderRadius = 0;
            this.BoutonValidNbRouter.ButtonText = "Confirmer";
            this.BoutonValidNbRouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoutonValidNbRouter.DisabledColor = System.Drawing.Color.Gray;
            this.BoutonValidNbRouter.Iconcolor = System.Drawing.Color.Transparent;
            this.BoutonValidNbRouter.Iconimage = null;
            this.BoutonValidNbRouter.Iconimage_right = null;
            this.BoutonValidNbRouter.Iconimage_right_Selected = null;
            this.BoutonValidNbRouter.Iconimage_Selected = null;
            this.BoutonValidNbRouter.IconMarginLeft = 0;
            this.BoutonValidNbRouter.IconMarginRight = 0;
            this.BoutonValidNbRouter.IconRightVisible = true;
            this.BoutonValidNbRouter.IconRightZoom = 0D;
            this.BoutonValidNbRouter.IconVisible = true;
            this.BoutonValidNbRouter.IconZoom = 90D;
            this.BoutonValidNbRouter.IsTab = false;
            this.BoutonValidNbRouter.Location = new System.Drawing.Point(-73, 39);
            this.BoutonValidNbRouter.Name = "BoutonValidNbRouter";
            this.BoutonValidNbRouter.Normalcolor = System.Drawing.Color.DimGray;
            this.BoutonValidNbRouter.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.BoutonValidNbRouter.OnHoverTextColor = System.Drawing.Color.White;
            this.BoutonValidNbRouter.selected = false;
            this.BoutonValidNbRouter.Size = new System.Drawing.Size(215, 48);
            this.BoutonValidNbRouter.TabIndex = 5;
            this.BoutonValidNbRouter.Text = "Confirmer";
            this.BoutonValidNbRouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoutonValidNbRouter.Textcolor = System.Drawing.Color.LightGray;
            this.BoutonValidNbRouter.TextFont = new System.Drawing.Font("Corbel", 10F);
            this.BoutonValidNbRouter.Click += new System.EventHandler(this.BoutonValidNbRouter_Click);
            // 
            // NombreRouterBox
            // 
            this.NombreRouterBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NombreRouterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NombreRouterBox.Location = new System.Drawing.Point(-10, -46);
            this.NombreRouterBox.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NombreRouterBox.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NombreRouterBox.Name = "NombreRouterBox";
            this.NombreRouterBox.ReadOnly = true;
            this.NombreRouterBox.Size = new System.Drawing.Size(84, 30);
            this.NombreRouterBox.TabIndex = 4;
            this.NombreRouterBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(-104, -87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selectionner le nombre de machines";
            // 
            // PanelBonjour
            // 
            this.PanelBonjour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBonjour.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PanelBonjour.Controls.Add(this.bunifuFlatButton1);
            this.PanelBonjour.Controls.Add(this.label1);
            this.PanelBonjour.Location = new System.Drawing.Point(509, 12);
            this.PanelBonjour.Name = "PanelBonjour";
            this.PanelBonjour.Size = new System.Drawing.Size(23, 22);
            this.PanelBonjour.TabIndex = 7;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Commencer";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-262, -82);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Commencer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Corbel", 13F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Megrim", 99.74998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-319, -57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 144);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulator";
            // 
            // espaceRouter
            // 
            this.espaceRouter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.espaceRouter.Controls.Add(this.algoInfoTitre);
            this.espaceRouter.Controls.Add(this.algoInfo);
            this.espaceRouter.Controls.Add(this.label3);
            this.espaceRouter.Controls.Add(this.algoComboBox);
            this.espaceRouter.Controls.Add(this.algoDestinantion);
            this.espaceRouter.Controls.Add(this.BoutonDessinOptimal);
            this.espaceRouter.Controls.Add(this.algoSource);
            this.espaceRouter.Location = new System.Drawing.Point(0, 40);
            this.espaceRouter.Name = "espaceRouter";
            this.espaceRouter.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.espaceRouter.Size = new System.Drawing.Size(1351, 733);
            this.espaceRouter.TabIndex = 10;
            // 
            // algoInfoTitre
            // 
            this.algoInfoTitre.AutoSize = true;
            this.algoInfoTitre.Font = new System.Drawing.Font("Cookie", 30F);
            this.algoInfoTitre.Location = new System.Drawing.Point(1234, 111);
            this.algoInfoTitre.Name = "algoInfoTitre";
            this.algoInfoTitre.Size = new System.Drawing.Size(91, 45);
            this.algoInfoTitre.TabIndex = 13;
            this.algoInfoTitre.Text = "label5";
            // 
            // algoInfo
            // 
            this.algoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.algoInfo.Location = new System.Drawing.Point(1239, 138);
            this.algoInfo.Name = "algoInfo";
            this.algoInfo.Size = new System.Drawing.Size(100, 23);
            this.algoInfo.TabIndex = 12;
            this.algoInfo.Text = "label5";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choisir l\'algorithme";
            // 
            // algoComboBox
            // 
            this.algoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.algoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.algoComboBox.FormattingEnabled = true;
            this.algoComboBox.Items.AddRange(new object[] {
            "Etat de liens",
            "Vecteur de distances",
            "Inondation (Type LSA)",
            "Inondation (Type Relais)",
            "Aleatoire",
            "Hot Potato"});
            this.algoComboBox.Location = new System.Drawing.Point(12, 603);
            this.algoComboBox.Name = "algoComboBox";
            this.algoComboBox.Size = new System.Drawing.Size(210, 24);
            this.algoComboBox.TabIndex = 10;
            // 
            // algoDestinantion
            // 
            this.algoDestinantion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.algoDestinantion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.algoDestinantion.Location = new System.Drawing.Point(130, 681);
            this.algoDestinantion.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.algoDestinantion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.algoDestinantion.Name = "algoDestinantion";
            this.algoDestinantion.ReadOnly = true;
            this.algoDestinantion.Size = new System.Drawing.Size(37, 26);
            this.algoDestinantion.TabIndex = 9;
            this.algoDestinantion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // algoSource
            // 
            this.algoSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.algoSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.algoSource.Location = new System.Drawing.Point(67, 681);
            this.algoSource.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.algoSource.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.algoSource.Name = "algoSource";
            this.algoSource.ReadOnly = true;
            this.algoSource.Size = new System.Drawing.Size(37, 26);
            this.algoSource.TabIndex = 8;
            this.algoSource.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Barre;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.Barre;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuHScrollBar1
            // 
            this.bunifuHScrollBar1.AllowCursorChanges = true;
            this.bunifuHScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuHScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuHScrollBar1.AllowMouseDownEffects = true;
            this.bunifuHScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuHScrollBar1.AllowScrollingAnimations = true;
            this.bunifuHScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuHScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuHScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuHScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHScrollBar1.BackgroundImage")));
            this.bunifuHScrollBar1.BorderRadius = 1;
            this.bunifuHScrollBar1.BorderThickness = 1;
            this.bunifuHScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuHScrollBar1.LargeChange = 10;
            this.bunifuHScrollBar1.Location = new System.Drawing.Point(12, -8);
            this.bunifuHScrollBar1.Maximum = 100;
            this.bunifuHScrollBar1.Minimum = 0;
            this.bunifuHScrollBar1.MinimumThumbLength = 18;
            this.bunifuHScrollBar1.Name = "bunifuHScrollBar1";
            this.bunifuHScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHScrollBar1.ScrollBarBorderColor = System.Drawing.Color.Thistle;
            this.bunifuHScrollBar1.ScrollBarColor = System.Drawing.Color.Thistle;
            this.bunifuHScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuHScrollBar1.Size = new System.Drawing.Size(173, 10);
            this.bunifuHScrollBar1.SmallChange = 1;
            this.bunifuHScrollBar1.TabIndex = 6;
            this.bunifuHScrollBar1.ThumbColor = System.Drawing.Color.MediumOrchid;
            this.bunifuHScrollBar1.ThumbLength = 18;
            this.bunifuHScrollBar1.ThumbMargin = 1;
            this.bunifuHScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuHScrollBar.ThumbStyles.Inset;
            this.bunifuHScrollBar1.Value = 0;
            // 
            // boutonReduction
            // 
            this.boutonReduction.ActiveImage = null;
            this.boutonReduction.AllowAnimations = true;
            this.boutonReduction.AllowZooming = true;
            this.boutonReduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonReduction.BackColor = System.Drawing.Color.Transparent;
            this.boutonReduction.ErrorImage = ((System.Drawing.Image)(resources.GetObject("boutonReduction.ErrorImage")));
            this.boutonReduction.FadeWhenInactive = false;
            this.boutonReduction.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.boutonReduction.Image = global::ProjetInterne.Properties.Resources.SoftwareTools15;
            this.boutonReduction.ImageActive = null;
            this.boutonReduction.ImageLocation = null;
            this.boutonReduction.ImageMargin = 3;
            this.boutonReduction.ImageSize = new System.Drawing.Size(20, 22);
            this.boutonReduction.ImageZoomSize = new System.Drawing.Size(23, 25);
            this.boutonReduction.InitialImage = ((System.Drawing.Image)(resources.GetObject("boutonReduction.InitialImage")));
            this.boutonReduction.Location = new System.Drawing.Point(1273, 9);
            this.boutonReduction.Name = "boutonReduction";
            this.boutonReduction.Rotation = 0;
            this.boutonReduction.ShowActiveImage = true;
            this.boutonReduction.ShowCursorChanges = true;
            this.boutonReduction.ShowImageBorders = false;
            this.boutonReduction.ShowSizeMarkers = false;
            this.boutonReduction.Size = new System.Drawing.Size(23, 25);
            this.boutonReduction.TabIndex = 14;
            this.boutonReduction.ToolTipText = "";
            this.boutonReduction.WaitOnLoad = false;
            this.boutonReduction.Zoom = 3;
            this.boutonReduction.ZoomSpeed = 10;
            this.boutonReduction.Click += new System.EventHandler(this.boutonReduction_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveImage = null;
            this.CloseButton.AllowAnimations = true;
            this.CloseButton.AllowZooming = true;
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.ErrorImage")));
            this.CloseButton.FadeWhenInactive = false;
            this.CloseButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.CloseButton.Image = global::ProjetInterne.Properties.Resources.SoftwareTools13;
            this.CloseButton.ImageActive = null;
            this.CloseButton.ImageLocation = null;
            this.CloseButton.ImageMargin = 3;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 22);
            this.CloseButton.ImageZoomSize = new System.Drawing.Size(23, 25);
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(1316, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0;
            this.CloseButton.ShowActiveImage = true;
            this.CloseButton.ShowCursorChanges = true;
            this.CloseButton.ShowImageBorders = false;
            this.CloseButton.ShowSizeMarkers = false;
            this.CloseButton.Size = new System.Drawing.Size(23, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.ToolTipText = "";
            this.CloseButton.WaitOnLoad = false;
            this.CloseButton.Zoom = 3;
            this.CloseButton.ZoomSpeed = 10;
            this.CloseButton.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // BoutonDessinOptimal
            // 
            this.BoutonDessinOptimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BoutonDessinOptimal.BackColor = System.Drawing.Color.Transparent;
            this.BoutonDessinOptimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoutonDessinOptimal.BackgroundImage")));
            this.BoutonDessinOptimal.ButtonText = "Executer L\'algorithme";
            this.BoutonDessinOptimal.ButtonTextMarginLeft = 0;
            this.BoutonDessinOptimal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.BoutonDessinOptimal.DisabledFillColor = System.Drawing.Color.Gray;
            this.BoutonDessinOptimal.DisabledForecolor = System.Drawing.Color.White;
            this.BoutonDessinOptimal.ForeColor = System.Drawing.Color.White;
            this.BoutonDessinOptimal.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BoutonDessinOptimal.IconPadding = 10;
            this.BoutonDessinOptimal.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BoutonDessinOptimal.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BoutonDessinOptimal.IdleBorderRadius = 1;
            this.BoutonDessinOptimal.IdleBorderThickness = 0;
            this.BoutonDessinOptimal.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BoutonDessinOptimal.IdleIconLeftImage = null;
            this.BoutonDessinOptimal.IdleIconRightImage = null;
            this.BoutonDessinOptimal.Location = new System.Drawing.Point(12, 630);
            this.BoutonDessinOptimal.Name = "BoutonDessinOptimal";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.BoutonDessinOptimal.onHoverState = stateProperties4;
            this.BoutonDessinOptimal.Size = new System.Drawing.Size(210, 45);
            this.BoutonDessinOptimal.TabIndex = 7;
            this.BoutonDessinOptimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoutonDessinOptimal.Click += new System.EventHandler(this.BoutonDessinOptimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1351, 773);
            this.Controls.Add(this.bunifuHScrollBar1);
            this.Controls.Add(this.Barre);
            this.Controls.Add(this.espaceRouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Barre.ResumeLayout(false);
            this.ChoixLiaisonPanel.ResumeLayout(false);
            this.ChoixLiaisonPanel.PerformLayout();
            this.NombreRouterPanel.ResumeLayout(false);
            this.NombreRouterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombreRouterBox)).EndInit();
            this.PanelBonjour.ResumeLayout(false);
            this.PanelBonjour.PerformLayout();
            this.espaceRouter.ResumeLayout(false);
            this.espaceRouter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.algoDestinantion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.algoSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Barre;
        private Bunifu.UI.WinForms.BunifuImageButton CloseButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuHScrollBar bunifuHScrollBar1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BoutonDessinOptimal;
        private System.Windows.Forms.NumericUpDown algoSource;
        private System.Windows.Forms.NumericUpDown algoDestinantion;
        private System.Windows.Forms.Panel espaceRouter;
        private System.Windows.Forms.Panel PanelBonjour;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel NombreRouterPanel;
        private Bunifu.Framework.UI.BunifuFlatButton BoutonValidNbRouter;
        private System.Windows.Forms.NumericUpDown NombreRouterBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ChoixLiaisonPanel;
        private Bunifu.Framework.UI.BunifuFlatButton BoutonValidLiaison;
        private System.Windows.Forms.FlowLayoutPanel LiaisonMainFlow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox algoComboBox;
        private Bunifu.Framework.UI.BunifuFlatButton BoutonRetourMenu;
        private Bunifu.Framework.UI.BunifuFlatButton BoutonRetour;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Label algoInfo;
        private System.Windows.Forms.Label algoInfoTitre;
        private Bunifu.UI.WinForms.BunifuImageButton boutonReduction;
    }
}

