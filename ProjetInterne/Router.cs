using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetInterne
{
    class Router
    {
        /***************************************
                        ATTRIBUTS
        ***************************************/
        private String RouterID = "Router" + (Machine.compter_router() + 1);

        private int RouterNumID = Machine.compter_router();

        private Bunifu.UI.WinForms.BunifuPictureBox FaceRouter;

        private static int largeur = 70;

        private static int longueur = 70;

        private List<Lien> ConnexionsRouter = new List<Lien>();



        /***************************************
                        CONSTRUCTEUR
        ***************************************/
        public Router()
        {
            FaceRouter = new Bunifu.UI.WinForms.BunifuPictureBox();

            FaceRouter.SizeMode = PictureBoxSizeMode.Zoom;

            FaceRouter.Tag = "oneTime";

            FaceRouter.Location = Machine.LesPoints[Machine.index];

            Machine.index++;

            FaceRouter.Size = new System.Drawing.Size(largeur, longueur);

            FaceRouter.ImageLocation = "C:/Users/azizc/Pictures/SoftwareTools7.png";

            Machine.ajouter_router(this);
        }



        /***************************************
                        METHODES
        ***************************************/
        public List<Lien> get_ConnecxionsRouter()
        {
            return ConnexionsRouter;
        }

        public void add_ConnexionsRouter(Lien A)
        {
            ConnexionsRouter.Add(A);
        }

        public Bunifu.UI.WinForms.BunifuPictureBox get_FaceRouter()
        {
            return FaceRouter;
        }

        public String get_RouterID()
        {
            return RouterID;
        }

        public int get_RouterNumID()
        {
            return RouterNumID;
        }

        public void ajouter_lien(Router A, double cout)
        {
            Lien lien = new Lien(RouterID, A.RouterID, RouterNumID, A.RouterNumID, cout);
            Lien lien2 = new Lien(A.RouterID, RouterID, A.RouterNumID, RouterNumID, cout);
            ConnexionsRouter.Add(lien);
            ConnexionsRouter.Add(lien2);
        }
    }
}
