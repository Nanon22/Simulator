using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInterne
{
    class Vertex
    {
        /***************************************
                        ATTRIBUTS
        ***************************************/
        public String name;

        public int etat;

        public int precedent;

        public int pathLength;

        public static int a = 0;

        /***************************************
                        CONSTRUCTEUR
        ***************************************/
        public Vertex(String name)
        {
            this.name = name;
        }
    }
}
