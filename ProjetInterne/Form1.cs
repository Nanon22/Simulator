using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace ProjetInterne
{
    public partial class Form1 : Form
    {
        /***************************************
                        ATTRIBUTS
        ***************************************/
        Graphics Dessin;

        Graphe G = new Graphe();

        List<int> noeudsAtteint = new List<int>();

        List<Bunifu.Framework.UI.BunifuCustomLabel> listeLabel = new List<Bunifu.Framework.UI.BunifuCustomLabel>();

        static String bellmanTitre = "Routage à vecteur de distances";
        static String bellmanInfo = "Le routage à vecteur de distances s’appuie sur l’algorithme de Bellman-Ford encore "
                                    + "appelé algorithme de Bellman-Ford-Moore, c’est un algorithme qui calcule des plus courts "
                                    + "chemins depuis un sommet source donné dans un graphe orienté pondéré. ";

        static String dijkstraTitre = "Routage à état de liens";
        static String dijkstraInfo = "Le routage à état de lien est pris en charge par l’algorithme de Dijkstra, Il sert à "
                                    + "résoudre le problème du plus court chemin.Il calcule des plus courts chemins à partir d’une "
                                    + "source dans un graphe orienté pondéré par des réels positifs.On peut aussi l’utiliser pour "
                                    + "calculer un plus court chemin entre un sommet de départ et un sommet d’arrivée. ";

        static String inondationTitre = "Routage d'inondation";
        static String inondationInfo = "Un algorithme d’inondation est un algorithme permettant de distribuer du matériel à"
                                        + "chaque partie d’un graphique, dans le domaine du routage il est appelé Flooding qui n’est rien "
                                        + "d’autre que sa traduction en anglais.Flooding est un simple algorithme de routage de réseau "
                                        + "informatique dans lequel chaque paquet entrant est envoyé par chaque lien sortant sauf "
                                        + "celui par lequel il est arrivé.Il est souvent utilisé afin d’obtenir une cartographie complète du "
                                        + "réseau vu que par son mode de fonctionnement toutes les routes du réseau seront exploitées. "
                                        + "Il existe plusieurs variantes d’algorithmes d’inondation.La plupart fonctionnent à peu près "
                                        +"comme suit : \n "
                                        +"1. Chaque noeud agit à la fois comme émetteur et récepteur. \n"
                                        +"2. Chaque noeud tente de transférer chaque message à chacun de ses voisins, à "
                                        +"l’exception du noeud source. ";

        static String aleatoireTitre = "Routage Aleatoire";
        static String aleatoireInfo = "Un algorithme de routage aléatoire est un algorithme qui choisira une route aléatoire "
                                        + "parmi les liaisons directes du noeud pour l’envoi du paquet.L’opération se répètera ainsi de "
                                        + "noeud en noeud jusqu’à atteindre le noeud souhaité.";

        static String hotTitre = "Routage Hot Potato";
        static String hotInfo = "L’algorithme de routage Hot-Potato peut être qualifié entre griffes d’algorithme de "
                                + "débarra, dans la mesure où chaque routeur se débarrasse du paquet en sa possession le plus "
                                + "rapidement possible en l’envoyant sur une de ses liaisons directes à savoir celle qui à la "
                                + "valuation la plus légère.L’inconvénient est que, parce que le paquet est renvoyé(comme une "
                                + "patate chaude), il finit parfois par être plus éloigné de sa destination, car il doit continuer à "
                                + "avancer.";

        public static int NombreDeRouter;

        public static int Step = 0;

        public List<Bunifu.Framework.UI.BunifuCheckbox> CheckBoxList = new List<Bunifu.Framework.UI.BunifuCheckbox>();



        /***************************************
                        CONSTRUCTEUR
        ***************************************/
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            Dessin = espaceRouter.CreateGraphics();

            espaceRouter.Parent = this;

            PanelBonjour.Parent = this;

            BoutonRetourMenu.Parent = Barre;

            BoutonRetour.Parent = Barre;

            algoInfoTitre.Hide();

            algoInfo.Hide();

            ChoixLiaisonPanel.Parent = this;

            NombreRouterPanel.Parent = this;

            Panel_Bonjour_Affichage();

        }




        /**********************************************
                        METHODES D'INTERFACE
        ***********************************************/
        private void Dessiner_Lien(Bunifu.UI.WinForms.BunifuPictureBox A, Bunifu.UI.WinForms.BunifuPictureBox B)
        {
            Pen MonStylo = new Pen(Color.Red, 4);
            Point PositionRouter1 = new Point(A.Location.X + (A.Size.Width/2), A.Location.Y + (A.Size.Height / 2));
            Point PositionRouter2 = new Point(B.Location.X + (B.Size.Width / 2), B.Location.Y + (B.Size.Height / 2));

            Dessin.DrawLine(MonStylo, PositionRouter1, PositionRouter2);
        }

        private void creation_lien_router(Router A)
        {
            foreach (Router B in Machine.get_LesRouter())
            {
                if(A.get_RouterID() != B.get_RouterID())
                {
                    foreach(Lien lien in A.get_ConnecxionsRouter())
                    {
                        if((lien.get_extrem1() == A.get_RouterID() && lien.get_extrem2() == B.get_RouterID()))
                        {
                            Dessiner_Lien(A.get_FaceRouter(), B.get_FaceRouter());
                            Bunifu.Framework.UI.BunifuCustomLabel RouterLinkLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
                            RouterLinkLabel.Tag = "oneTime";
                            RouterLinkLabel.Text = "" + lien.get_cout() + "";
                            RouterLinkLabel.BackColor = Color.Transparent;
                            RouterLinkLabel.AutoSize = false;
                            RouterLinkLabel.Width = 22;
                            RouterLinkLabel.Height = 15;
                            RouterLinkLabel.BringToFront();
                            RouterLinkLabel.Location = new Point((A.get_FaceRouter().Location.X + (A.get_FaceRouter().Size.Width / 2) + B.get_FaceRouter().Location.X + (B.get_FaceRouter().Size.Width / 2)) / 2 -5, (A.get_FaceRouter().Location.Y + (A.get_FaceRouter().Size.Height / 2) + B.get_FaceRouter().Location.Y + (B.get_FaceRouter().Size.Height / 2)) / 2 - 6);
                            listeLabel.Add(RouterLinkLabel);
                            espaceRouter.Controls.Add(RouterLinkLabel);
                        }
                    }
                }
            }
        }

        private void afficher_machine(Router A)
        {
            espaceRouter.Controls.Add(A.get_FaceRouter());
            Machine.listeInterfaces.Add(A.get_FaceRouter());
            A.get_FaceRouter().Load();
            Bunifu.Framework.UI.BunifuCustomLabel RouterName = new Bunifu.Framework.UI.BunifuCustomLabel();
            RouterName.Tag = "oneTime";
            RouterName.BackColor = Color.Transparent;
            RouterName.Text = A.get_RouterID();
            RouterName.AutoSize = false;
            RouterName.Width = 60;
            RouterName.Height = 15;
            RouterName.Location = new Point(A.get_FaceRouter().Location.X + (A.get_FaceRouter().Size.Width / 2) - 25, A.get_FaceRouter().Location.Y + A.get_FaceRouter().Size.Height);
            listeLabel.Add(RouterName);
            espaceRouter.Controls.Add(RouterName);
        }

        private void Dessiner_Lien_Optimal(Bunifu.UI.WinForms.BunifuPictureBox A, Bunifu.UI.WinForms.BunifuPictureBox B)
        {
            Pen MonStylo = new Pen(Color.Yellow, 4);
            Point PositionRouter1 = new Point(A.Location.X + (A.Size.Width / 2), A.Location.Y + (A.Size.Height / 2));
            Point PositionRouter2 = new Point(B.Location.X + (B.Size.Width / 2), B.Location.Y + (B.Size.Height / 2));

            Dessin.DrawLine(MonStylo, PositionRouter1, PositionRouter2);
        }

        public void Panel_Router_Affichage()
        {
            PanelBonjour.Hide();
            ChoixLiaisonPanel.Hide();
            NombreRouterPanel.Hide();
            espaceRouter.Size = new Size(1351, 734);
            espaceRouter.Location = new Point(0, 38);
            espaceRouter.Show();
            espaceRouter.Dock = DockStyle.Fill;
            Dessin = espaceRouter.CreateGraphics();
        }

        public void Panel_NbRouter_Affichage()
        {
            PanelBonjour.Hide();
            ChoixLiaisonPanel.Hide();
            espaceRouter.Hide();
            BoutonRetourMenu.Hide();
            BoutonRetour.Hide();
            NombreRouterPanel.Size = new Size(1351, 734);
            NombreRouterPanel.Location = new Point(0, 38);
            NombreRouterPanel.Show();
            NombreRouterPanel.Dock = DockStyle.Fill;
        }

        public void Panel_ChoixLiaison_Affichage()
        {
            PanelBonjour.Hide();
            ChoixLiaisonPanel.Hide();
            NombreRouterPanel.Hide();
            ChoixLiaisonPanel.Size = new Size(1351, 734);
            ChoixLiaisonPanel.Location = new Point(0, 38);
            ChoixLiaisonPanel.Show();
            ChoixLiaisonPanel.Dock = DockStyle.Fill;
        }

        public void Panel_Bonjour_Affichage()
        {
            espaceRouter.Hide();
            ChoixLiaisonPanel.Hide();
            NombreRouterPanel.Hide();
            BoutonRetourMenu.Hide();
            BoutonRetour.Hide();
            PanelBonjour.Size = new Size(1351, 734);
            PanelBonjour.Location = new Point(0, 38);
            PanelBonjour.Show();
            PanelBonjour.Dock = DockStyle.Fill;
        }

        private void BoutonValidNbRouter_Click(object sender, EventArgs e)
        {
            NombreDeRouter = Convert.ToInt32(NombreRouterBox.Value);
            algoSource.Maximum = NombreDeRouter;
            algoDestinantion.Maximum = NombreDeRouter;
            Panel_ChoixLiaison_Affichage();
            BoutonRetour.Location = new Point(12, 0);
            BoutonRetour.Visible = true;
            BoutonRetourMenu.Hide();
            Panel_Liaison_Content();

        }

        private void Panel_Liaison_Content()
        {
            int i = 0;
            int stat;
            while (i < NombreDeRouter)
            {
                stat = 1;
                //215,100
                TableLayoutPanel MyTable = new TableLayoutPanel();
                MyTable.Size = new Size(1025, 100);
                MyTable.ColumnCount = 2;
                MyTable.RowCount = 1;
                MyTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                MyTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
                MyTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
                MyTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                Bunifu.UI.WinForms.BunifuPictureBox MyPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
                MyPicture.Size = new Size(50, 50);
                MyPicture.Image = Properties.Resources.SoftwareTools7;

                Label MyLabel = new Label();
                MyLabel.Text = "Router" + (i + 1);

                FlowLayoutPanel MyFlowPanel1 = new FlowLayoutPanel();
                MyFlowPanel1.FlowDirection = FlowDirection.TopDown;
                MyFlowPanel1.AutoScroll = true;
                MyFlowPanel1.WrapContents = false;
                MyFlowPanel1.Controls.Add(MyPicture);
                MyFlowPanel1.Controls.Add(MyLabel);
                MyTable.Controls.Add(MyFlowPanel1, 0, 0);

                FlowLayoutPanel MyFlowPanel2 = new FlowLayoutPanel();
                MyFlowPanel2.FlowDirection = FlowDirection.LeftToRight;
                MyFlowPanel2.AutoSize = true;
                MyFlowPanel2.AutoScroll = false;
                MyFlowPanel2.WrapContents = true;


                while (stat <= NombreDeRouter)
                {
                    if ((i + 1) == stat)
                    {
                        stat++;
                    }
                    else
                    {
                        Bunifu.Framework.UI.BunifuCheckbox MyCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
                        MyCheckbox.Checked = false;
                        MyCheckbox.Name = "" + stat;
                        MyCheckbox.Tag = "" + i;
                        MyCheckbox.OnChange += MyCheckbox_OnChange;
                        Label MyLabel2 = new Label();
                        MyLabel2.Text = "Router" + stat;

                        MyFlowPanel2.Controls.Add(MyCheckbox);
                        MyFlowPanel2.Controls.Add(MyLabel2);
                        //CheckBoxList.Add(MyCheckbox);
                        stat++;
                    }

                }
                MyTable.Controls.Add(MyFlowPanel2, 1, 0);
                LiaisonMainFlow.Controls.Add(MyTable);
                i++;
            }
        }

        private void MyCheckbox_OnChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuCheckbox Checkbox = sender as Bunifu.Framework.UI.BunifuCheckbox;
            if (Checkbox.Checked)
            {
                CheckBoxList.Add(Checkbox);
            }
            else
            {
                CheckBoxList.Remove(Checkbox);
            }
            //throw new NotImplementedException();
        }

        private void Creation_Des_Router()
        {
            int i = 0;
            while (i < NombreDeRouter)
            {
                Router NouveauRouter = new Router();
                G.InsertVertex(G.MyIndex(i));
                i++;
            }
        }

        private void Etablir_Liaisons_Entre_Router()
        {
            Random rand = new Random();
            foreach (Bunifu.Framework.UI.BunifuCheckbox Check in CheckBoxList)
            {
                int rnd = rand.Next(1, 21);
                int lienExistant = 0;
                if (Check.Checked)
                {
                    foreach (Lien link in Machine.get_LesLiens())
                    {
                        if ((link.get_int_extrem1() == Convert.ToInt32(Check.Tag) && link.get_int_extrem2() == (Convert.ToInt32(Check.Name) - 1)) || (link.get_int_extrem1() == (Convert.ToInt32(Check.Name) - 1) && link.get_int_extrem2() == Convert.ToInt32(Check.Tag)))
                        {
                            lienExistant = 1;
                            //break;
                        }
                        else
                        {
                            //lienExistant = 0;
                        }
                    }
                    if (lienExistant == 0)
                    {
                        Machine.get_LesRouter()[Convert.ToInt32(Check.Tag)].ajouter_lien(Machine.get_LesRouter()[Convert.ToInt32(Check.Name) - 1], rnd);
                        G.InsertEdge(G.MyIndex(Convert.ToInt32(Check.Tag)), G.MyIndex(Convert.ToInt32(Check.Name) - 1), rnd);
                        G.InsertEdge(G.MyIndex(Convert.ToInt32(Check.Name) - 1), G.MyIndex(Convert.ToInt32(Check.Tag)), rnd);
                    }
                    else
                    {
                        //rien
                    }
                }
            }
        }

        private void Dessiner_Le_Graphe()
        {
            foreach (Router A in Machine.get_LesRouter())
            {
                afficher_machine(A);
                creation_lien_router(A);
            }
        }

        private int meilleur_noeud(Router A)
        {
            int leMeilleur = 0;
            double leGrand = 100;
            foreach (Lien lien in Machine.get_LesLiens())
            {
                if (A.get_RouterNumID() == lien.get_int_extrem1() && !noeudsAtteint.Contains(lien.get_int_extrem2()))
                {
                    if (lien.get_cout() < leGrand)
                    {
                        leGrand = lien.get_cout();
                        leMeilleur = lien.get_int_extrem2();
                    }
                }
            }
            if (leGrand == 100)
            {
                return -1;
            }
            else
            {
                return leMeilleur;
            }
        }

        private void supprimer_les_router()
        {
            for (int i = 0; i < Machine.get_LesRouter().Count; i++)
            {
                Machine.get_LesRouter()[i] = null;
            }
            Machine.set_LesRouter(new List<Router>());
            Machine.set_LesLiens(new List<Lien>());
            Machine.index = 0;
            Vertex.a = 0;
        }

        private void algo_info_modif(String info, String titre)
        {
            algoInfo.Size = new Size(300, 700);
            algoInfo.Location = new Point(1500, 138);
            algoInfo.Text = info;
            algoInfo.Show();
            algoInfoTitre.Location = new Point(1500, 61);
            algoInfoTitre.Text = titre;
            algoInfoTitre.Show();
        }




        /***********************************************************************
                            METHODES D'ALGORITHMES DE ROUTAGES
        ************************************************************************/

        private void inondation_LSA(Router A)
        {
            foreach (Router B in Machine.get_LesRouter())
            {
                if (A.get_RouterID() != B.get_RouterID())
                {
                    foreach (Lien lien in A.get_ConnecxionsRouter())
                    {
                        if ((lien.get_extrem1() == A.get_RouterID() && lien.get_extrem2() == B.get_RouterID()))
                        {
                            Dessiner_Lien_Optimal(A.get_FaceRouter(), B.get_FaceRouter());

                        }
                    }
                }
            }
        }

        private void hot_potato(Router A, Router B)
        {
            noeudsAtteint.Add(A.get_RouterNumID());
            if (meilleur_noeud(A) == -1)
            {

            }
            else
            {
                Dessiner_Lien_Optimal(A.get_FaceRouter(), Machine.get_LesRouter()[meilleur_noeud(A)].get_FaceRouter());
                if (meilleur_noeud(A) == B.get_RouterNumID())
                {
                    noeudsAtteint.Add(B.get_RouterNumID());
                }
                else
                {
                    hot_potato(Machine.get_LesRouter()[meilleur_noeud(A)], B);
                }
            }
        }

        private void inondation_Relais(Router A)
        {
            noeudsAtteint.Add(A.get_RouterNumID());

            foreach (Router B in Machine.get_LesRouter())
            {
                foreach (Lien l in Machine.get_LesLiens())
                {
                    if ((l.get_int_extrem1() == A.get_RouterNumID() && l.get_int_extrem2() == B.get_RouterNumID()) || (l.get_int_extrem1() == B.get_RouterNumID() && l.get_int_extrem2() == A.get_RouterNumID()))
                    {
                        if (noeudsAtteint.Contains(B.get_RouterNumID()))
                        {

                        }
                        else
                        {
                            Dessiner_Lien_Optimal(A.get_FaceRouter(), B.get_FaceRouter());
                            inondation_Relais(B);
                        }
                    }
                }
            }
        }



        private void Executer_Dijkstra(String Source, int Destination)
        {
            if (G.GetIndex(Source) == Destination)
            {
                //nothing
            }
            else
            {
                int s = G.GetIndex(Source);
                G.TrouverLesChemins(Source);
                int i = 0;
                int j;
                //Dessiner_Lien_Optimal(Machine.get_LesRouter()[Graphe.PathStock[Destination][i]].get_FaceRouter(), Machine.get_LesRouter()[Graphe.PathStock[Destination][i + 1]].get_FaceRouter());
                if(G.PathStock[Destination] == null)
                {

                }
                else
                {
                    while (i < G.PathStock[Destination].Count - 1)
                    {
                        Dessiner_Lien_Optimal(Machine.get_LesRouter()[G.PathStock[Destination][i]].get_FaceRouter(), Machine.get_LesRouter()[G.PathStock[Destination][i + 1]].get_FaceRouter());

                        i++;
                    }
                }
            }


        }

        private void Executer_Aleatoire(int Source, int Destination)
        {
            if (Source == Destination)
            {
                //nothing
            }
            else
            {
                G.TrouverLesChemins(G.MyIndex(Source));
                if(G.PathStock[Destination] == null)
                {

                }
                else
                {
                    Aleatoire.cheminAleatoire.Clear();
                    Aleatoire.le_chemin_aleatoire(Source, Destination);
                    int i = 0;

                    while (i < Aleatoire.cheminAleatoire.Count - 1)
                    {
                        Dessiner_Lien_Optimal(Machine.get_LesRouter()[Aleatoire.cheminAleatoire[i]].get_FaceRouter(), Machine.get_LesRouter()[Aleatoire.cheminAleatoire[i + 1]].get_FaceRouter());

                        i++;
                    }
                }
            }

        }

        private void Executer_inondation_LSA()
        {
            foreach (Router A in Machine.get_LesRouter())
            {
                inondation_LSA(A);
            }
        }

        private void Executer_inondation_Relais(Router A)
        {
            noeudsAtteint.Clear();
            inondation_Relais(A);
        }

        private void Executer_hot_potato(Router A, Router B)
        {
            if (A.get_RouterNumID() == B.get_RouterNumID())
            {
                //nothing
            }
            else
            {
                noeudsAtteint.Clear();
                hot_potato(A, B);
            }
        }





        /***************************************
                        CLICK METHODS
        ***************************************/

        private void BoutonRetour_Click(object sender, EventArgs e)
        {
            Panel_NbRouter_Affichage();
            foreach (Control item in ChoixLiaisonPanel.Controls.OfType<Control>())
            {
                LiaisonMainFlow.Controls.Clear();
                CheckBoxList.Clear();
                BoutonRetour.Hide();
            }
        }

        private void BoutonRetourMenu_Click(object sender, EventArgs e)
        {
            Panel_NbRouter_Affichage();
            LiaisonMainFlow.Controls.Clear();
            CheckBoxList.Clear();
            espaceRouter.Refresh();
            supprimer_les_router();
            foreach (Control item in espaceRouter.Controls)
            {
                if ((String)item.Tag == "oneTime")
                {
                    espaceRouter.Controls.Remove(item);
                    item.Dispose();
                }
            }
            /*foreach (Control item in espaceRouter.Controls.OfType<Bunifu.Framework.UI.BunifuCustomLabel>())
            {
                if ((String)item.Tag == "oneTime")
                {
                    espaceRouter.Controls.Remove(item);
                    item.Dispose();
                }
            }*/
            for(int i = 0; i < listeLabel.Count; i++)
            {
                espaceRouter.Controls.Remove(listeLabel[i]);
            }
            for (int i = 0; i < Machine.listeInterfaces.Count; i++)
            {
                espaceRouter.Controls.Remove(Machine.listeInterfaces[i]);
            }
            Machine.listeInterfaces.Clear();
            algo_info_modif("","");
            G = new Graphe();
        }

        private void boutonReduction_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BoutonValidLiaison_Click(object sender, EventArgs e)
        {
            Panel_Router_Affichage();
            Creation_Des_Router();
            Etablir_Liaisons_Entre_Router();
            Dessiner_Le_Graphe();
            BoutonRetourMenu.Location = new Point(12, 0);
            BoutonRetourMenu.Show();
            BoutonRetour.Hide();
        }

        private void BoutonDessinOptimal_Click(object sender, EventArgs e)
        {
            espaceRouter.Refresh();
            foreach (Router A in Machine.get_LesRouter())
            {
                creation_lien_router(A);
            }

            switch (algoComboBox.SelectedIndex)
            {
                case 0:
                    Executer_Dijkstra(G.MyIndex(algoSource.Value - 1), Convert.ToInt32(algoDestinantion.Value) - 1);
                    algo_info_modif(dijkstraInfo, dijkstraTitre);
                    break;
                case 1:
                    Executer_Dijkstra(G.MyIndex(algoSource.Value - 1), Convert.ToInt32(algoDestinantion.Value) - 1);
                    algo_info_modif(bellmanInfo, bellmanTitre);
                    break;
                case 2:
                    Executer_inondation_LSA();
                    algo_info_modif(inondationInfo, inondationTitre);
                    break;
                case 3:
                    Executer_inondation_Relais(Machine.get_LesRouter()[Convert.ToInt32(algoSource.Value) - 1]);
                    algo_info_modif(inondationInfo, inondationTitre);
                    break;
                case 4:
                    Executer_Aleatoire(Convert.ToInt32(algoSource.Value) - 1, Convert.ToInt32(algoDestinantion.Value) - 1);
                    algo_info_modif(aleatoireInfo, aleatoireTitre);
                    break;
                case 5:
                    Executer_hot_potato(Machine.get_LesRouter()[Convert.ToInt32(algoSource.Value) - 1], Machine.get_LesRouter()[Convert.ToInt32(algoDestinantion.Value) - 1]);
                    algo_info_modif(hotInfo, hotTitre);
                    break;
                default:
                    break;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Panel_NbRouter_Affichage();
        }
    }
}
