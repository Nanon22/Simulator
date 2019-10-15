using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetInterne
{
    class Ordinateur
    {
        /***************************************
                        ATTRIBUTS
        ***************************************/
        private String OrdinateurID = "Ordinateur" + Machine.compter_ordinateur() + 1;

        private Lien ComputerLink;

        private Bunifu.UI.WinForms.BunifuPictureBox FaceOrdinateur = new Bunifu.UI.WinForms.BunifuPictureBox();

        private static int largeur = 104;

        private static int longueur = 97;



        /***************************************
                        CONSTRUCTEUR
        ***************************************/
        public Ordinateur()
        {
            FaceOrdinateur.SizeMode = PictureBoxSizeMode.Zoom;
            FaceOrdinateur.Size = new System.Drawing.Size(largeur, longueur);
            FaceOrdinateur.ImageLocation = "C:/Users/azizc/Pictures/SoftwareTools2.png";
            Machine.ajouter_ordinateur(this);
            
        }



        /***************************************
                        METHODES
        ***************************************/
        public Lien get_ComputerLink()
        {
            return ComputerLink;
        }

        public void set_ComputerLink(Lien A)
        {
            ComputerLink = A;
        }

        public Bunifu.UI.WinForms.BunifuPictureBox get_FaceOrdinateur()
        {
            return FaceOrdinateur;
        }
    }
}
