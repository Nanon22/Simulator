using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInterne
{
    static class Dijkstra
    {

        public static Router[] MeilleurRoute;

        private static int Distance_Minimum(int[] distance, bool[] PlusCourtChemin, int TailleVecteur)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < TailleVecteur; ++v)
            {
                if (PlusCourtChemin[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
        private static void Affichage(int[] distance, int TailleVecteur)
        {
            Console.WriteLine("Distance De La Source");
            for (int i = 0; i < TailleVecteur; ++i)
            {
                Console.WriteLine(i + "\t" + distance[i]);
            }
        }

        public static void Algorithme_De_Dijkstra(int[,] graph, int source, int destination, int TailleVecteur)
        {
            int[] distance = new int[TailleVecteur];


            bool[] PlusCourtChemin = new bool[TailleVecteur];

            int b = 0;

            MeilleurRoute = new Router[TailleVecteur];


           
            for (int i = 0; i < TailleVecteur; ++i)
            {
                distance[i] = int.MaxValue;
                PlusCourtChemin[i] = false;
            }


            distance[source] = 0;


            MeilleurRoute[0] = Machine.get_LesRouter()[source];

            int save = 0;
            int CheminSuivi = 0;
            int u;
            u = Distance_Minimum(distance, PlusCourtChemin, TailleVecteur);
            PlusCourtChemin[u] = true;
            while (u != destination)
            {
                b++;

                
                for (int v = 0; v < TailleVecteur; ++v)
                {
                    if (!PlusCourtChemin[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graph[u,v];
                        MeilleurRoute[b] = Machine.get_LesRouter()[Distance_Minimum(distance, PlusCourtChemin, TailleVecteur)];
                        save = v;
                    }
                }
                u = Distance_Minimum(distance, PlusCourtChemin, TailleVecteur);
                PlusCourtChemin[u] = true;
                CheminSuivi += graph[u, save];
            }
            save = CheminSuivi;
            CheminSuivi = 0;
            b = 0;
            for (int i = 0; i < TailleVecteur; ++i)
            {
                PlusCourtChemin[i] = false;
                PlusCourtChemin[source] = true;
                if (Distance_Minimum(distance, PlusCourtChemin, TailleVecteur) == i)
                {
                    PlusCourtChemin[i] = true;
                }
                else
                {
                    distance[i] = int.MaxValue;
                    PlusCourtChemin[i] = false;
                }
                
            }
            if (distance[destination] != save)
            {
                save = 0;
                u = Distance_Minimum(distance, PlusCourtChemin, TailleVecteur);
                PlusCourtChemin[u] = true;
                while (CheminSuivi > distance[destination])
                {
                    b++;


                    for (int v = 0; v < TailleVecteur; ++v)
                    {
                        if (!PlusCourtChemin[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        {
                            MeilleurRoute[b] = Machine.get_LesRouter()[Distance_Minimum(distance, PlusCourtChemin, TailleVecteur)];
                            save = v;
                        }
                    }
                    u = Distance_Minimum(distance, PlusCourtChemin, TailleVecteur);
                    PlusCourtChemin[u] = true;
                    CheminSuivi += graph[u, save];
                }
            }
            //Affichage(distance, TailleVecteur);
        }
    }
}
