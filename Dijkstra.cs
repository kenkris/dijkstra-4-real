using System;

namespace dijkstra_4_real
{
    class Dijkstra : IDijkstra
    {

        public void DoDijkstra(int[,] graph, int source)
        {
            var verticesCount = graph.GetLength(0);
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            // Distance of self loop is zero
            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                // Update the distance between neighbouring vertex and source vertex
                int u = _findMinDistance(distance, shortestPathTreeSet);
                shortestPathTreeSet[u] = true;

                // Update all the neighbouring vertex distances
                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            for (int i = 0; i < distance.Length; i++)
            {
                Console.WriteLine($"Distance from {source} to {i} is {distance[i]}");
            }
        }



        // Finding the minimum distance
        private static int _findMinDistance(int[] distance, bool[] visitedVertex)
        {
            int minDistance = int.MaxValue;
            int minDistanceVertex = -1;
            for (int i = 0; i < distance.Length; i++)
            {
                if (!visitedVertex[i] && distance[i] < minDistance)
                {
                    minDistance = distance[i];
                    minDistanceVertex = i;
                }
            }
            return minDistanceVertex;
        }
    }
}