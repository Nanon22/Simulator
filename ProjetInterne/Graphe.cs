using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInterne
{
    class Graphe
    {
        /***************************************
                        ATTRIBUTS
        ***************************************/
        public readonly int Max_Vertices = 30;

        int n = 0;

        int e;

        int[,] adj;

        Vertex[] ListeVertex;

        int[] path;

        public static List<int> MeilleurRoute;

        public List<int>[] PathStock;

        private readonly int Temporary = 1;

        private readonly int Permanent = 2;

        private readonly int Nil = -1;

        private readonly int Infinity = 99999;



        /***************************************
                        CONSTRUCTEUR
        ***************************************/
        public Graphe()
        {
            adj = new int[Max_Vertices, Max_Vertices];
            ListeVertex = new Vertex[Max_Vertices];
        }



        /***************************************
                        METHODES
        ***************************************/
        public void TrouverChemin(int s, int v)
        {
            int k = v;
            int i, u;
            path = new int[n];
            PathStock[k] = new List<int>();
            int sd = 0;
            int count = 0;
            while (v != s)
            {
                count++;
                path[count] = v;
                u = ListeVertex[v].precedent;
                sd += adj[u, v];
                v = u;
            }
            count++;
            path[count] = s;
            for (i = count; i >= 1; i--)
            {
                //MeilleurRoute.Add(path[i]);
                PathStock[k].Add(path[i]);
                //increment++;
            }
        }

        public int GetIndex(String s)
        {
            for (int i = 0; i < n; i++)
            {
                if (s.Equals(ListeVertex[i].name))
                    return i;
            }
            throw new InvalidOperationException("Invalid Vertex");
        }

        public int MyPlace(String A)
        {
            switch (A)
            {
                case "Zero": return 0;
                case "Un":
                    return 1;
                case "Deux":
                    return 2;
                case "Trois":
                    return 3;
                case "Quatre":
                    return 4;
                case "Cinq":
                    return 5;
                case "Six":
                    return 6;
                case "Sept":
                    return 7;
                case "Huit":
                    return 8;
                case "Neuf":
                    return 9;
                case "Dix":
                    return 10;
                default: return -1;
            }
        }

        public String MyIndex(decimal A)
        {
            switch (A)
            {
                case 0: return "Zero";
                case 1:
                    return "Un";
                case 2:
                    return "Deux";
                case 3:
                    return "Trois";
                case 4:
                    return "Quatre";
                case 5:
                    return "Cinq";
                case 6:
                    return "Six";
                case 7:
                    return "Sept";
                case 8:
                    return "Huit";
                case 9:
                    return "Neuf";
                case 10:
                    return "Dix";
                default: return "Nothing";
            }
        }

        public void InsertEdge(String A, String B, int c)
        {
            adj[MyPlace(A), MyPlace(B)] = c;
        }

        public void InsertEdge2(String A, String B, int c)
        {
            adj[Convert.ToInt32(A), Convert.ToInt32(B)] = c;
        }

        private void Dijkstra(int s)
        {
            int v, c;
            for (v = 0; v < n; v++)
            {
                ListeVertex[v].etat = Temporary;
                ListeVertex[v].pathLength = Infinity;
                ListeVertex[v].precedent = Nil;
            }
            ListeVertex[s].pathLength = 0;

            while (true)
            {
                c = TempVertexMinPL();

                if (c == Nil)
                    return;

                ListeVertex[c].etat = Permanent;

                for (v = 0; v < n; v++)
                {
                    if (IsAdjacent(c, v) && ListeVertex[v].etat == Temporary)
                    {
                        if (ListeVertex[c].pathLength + adj[c, v] < ListeVertex[v].pathLength)
                        {
                            ListeVertex[v].precedent = c;
                            ListeVertex[v].pathLength = ListeVertex[c].pathLength + adj[c, v];
                        }
                    }
                }

            }
        }

        private Boolean IsAdjacent(int A, int B)
        {
            return Convert.ToBoolean(adj[A, B]);
        }

        private int TempVertexMinPL()
        {
            int min = Infinity;
            int x = Nil;
            for (int v = 0; v < n; v++)
            {
                if (ListeVertex[v].etat == Temporary && ListeVertex[v].pathLength < min)
                {
                    min = ListeVertex[v].pathLength;
                    x = v;
                }
            }
            return x;
        }

        public void InsertVertex(String A)
        {
            Vertex B = new Vertex(A);
            ListeVertex[Vertex.a] = B;
            Vertex.a++;
            n++;
            PathStock = new List<int>[n];
        }

        public void TrouverLesChemins(String source)
        {
            int s = GetIndex(source);
            Dijkstra(s);

            for (int v = 0; v < n; v++)
            {
                if (ListeVertex[v].pathLength == Infinity)
                {

                }
                else
                {
                    TrouverChemin(s, v);
                }
            }
        }
    }
}
