using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInterne
{
    class Lien
    {
        /***************************************
                        ATTRIBUTS
        ***************************************/
        private String extrem1;

        private String extrem2;

        private int intExtrem1;

        private int intExtrem2;

        private double cout;



        /***************************************
                        CONSTRUCTEURS
        ***************************************/
        public Lien()
        {

        }

        public Lien(String ex1, String ex2, int intex1, int intex2, double a)
        {
            extrem1 = ex1;
            extrem2 = ex2;
            intExtrem1 = intex1;
            intExtrem2 = intex2;
            cout = a;
            Machine.ajouter_lien(this);
        }



        /***************************************
                        METHODES
        ***************************************/
        public String get_extrem1()
        {
            return extrem1;
        }

        public void set_extrem1(String a)
        {
            extrem1 = a;
        }

        public String get_extrem2()
        {
            return extrem2;
        }

        public void set_extrem2(String a)
        {
            extrem2 = a;
        }

        public double get_cout()
        {
            return cout;
        }

        public void set_cout(int a)
        {
            cout = a;
        }

        public int get_int_extrem1()
        {
            return intExtrem1;
        }

        public void set_int_extrem1(int a)
        {
            intExtrem1 = a;
        }

        public int get_int_extrem2()
        {
            return intExtrem2;
        }

        public void set_int_extrem2(int a)
        {
            intExtrem2 = a;
        }
    }
}
