using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjetInterne
{
    static class Machine
    {
        /***************************************
                        ATTRIBUTS
        ***************************************/
        private static List<Router> LesRouter = new List<Router>();

        private static List<Ordinateur> LesOrdinateurs = new List<Ordinateur>();

        private static List<Lien> LesLiens = new List<Lien>();

        public static List<Bunifu.UI.WinForms.BunifuPictureBox> listeInterfaces = new List<Bunifu.UI.WinForms.BunifuPictureBox>();

        public static List<Point> LesPoints = new List<Point> { new Point(67, 279), new Point(67, 464), new Point(273, 129), new Point(273, 568), new Point(573, 56), new Point(577, 606), new Point(844, 56), new Point(844, 606), new Point(1123, 129), new Point(1141, 579), new Point(1255, 279), new Point(1255, 464)};

        public static int index = 0;



        /***************************************
                        METHODES
        ***************************************/
        public static List<Router> get_LesRouter()
        {
            return LesRouter;
        }

        public static List<Ordinateur> get_LesOrdinateurs()
        {
            return LesOrdinateurs;
        }

        public static List<Lien> get_LesLiens()
        {
            return LesLiens;
        }

        public static void ajouter_router(Router A)
        {
            LesRouter.Add(A);
        }

        public static void ajouter_ordinateur(Ordinateur A)
        {
            LesOrdinateurs.Add(A);
        }

        public static void ajouter_lien(Lien A)
        {
            LesLiens.Add(A);
        }

        public static int compter_router()
        {
            int i = 0;
            foreach(Router A in LesRouter)
            {
                i++;
            }

            return i;
        }

        public static int compter_lien()
        {
            int i = 0;
            foreach (Lien A in LesLiens)
            {
                i++;
            }

            return i;
        }

        public static int compter_ordinateur()
        {
            int i = 0;
            foreach (Ordinateur A in LesOrdinateurs)
            {
                i++;
            }

            return i;
        }

        public static void set_LesRouter(List<Router> A)
        {
            LesRouter = A;
        }

        public static void set_LesOrdinateurs(List<Ordinateur> A)
        {
            LesOrdinateurs = A;
        }

        public static void set_LesLiens(List<Lien> A)
        {
            LesLiens = A;
        }
    }
}
