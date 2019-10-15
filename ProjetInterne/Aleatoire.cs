using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInterne
{
    static class Aleatoire
    {
        /***************************************
                        ATTRIBUTS
        ***************************************/
        public static List<int> cheminAleatoire = new List<int>();

        static Random Alea = new Random();

        static int nbAlea;

        static Lien NextLien;

        static int RouterSuivantID;




        /***************************************
                        METHODES
        ***************************************/
        public static void le_chemin_aleatoire(int source, int destination)
        {
            cheminAleatoire.Add(source);
            if (source != destination)
            {
                int b = 0;
                int c = 0;
                foreach(Lien lien in Machine.get_LesLiens())
                {
                    if(lien.get_extrem1() == Machine.get_LesRouter()[source].get_RouterID() || lien.get_extrem2() == Machine.get_LesRouter()[source].get_RouterID())
                    {
                        b++;
                    }

                }
                nbAlea = Alea.Next(b);

                foreach(Lien lien in Machine.get_LesLiens())
                {
                    if (lien.get_extrem1() == Machine.get_LesRouter()[source].get_RouterID() || lien.get_extrem2() == Machine.get_LesRouter()[source].get_RouterID())
                    {
                        if(c == nbAlea)
                        {
                            NextLien = lien;
                            c++;
                        }
                        else
                        {
                            c++;
                        }
                    }
                }
                if(NextLien.get_extrem1() == Machine.get_LesRouter()[source].get_RouterID())
                {
                    RouterSuivantID = NextLien.get_int_extrem2();
                }
                else
                {
                    RouterSuivantID = NextLien.get_int_extrem1();
                }
                if (RouterSuivantID != destination)
                {
                    le_chemin_aleatoire(RouterSuivantID, destination);
                }
                else
                {
                    cheminAleatoire.Add(RouterSuivantID);
                }
            }
            else
            {
                //
            }

        }
    }
}
