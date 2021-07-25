namespace DijkstraPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            var dijkstra = new Dijkstra();
            dijkstra.DoDijkstra(_getTestGraph(), 0);
        }

        private static int[,] _getTestGraph()
        {
            return new int[,]
            {
                { 0, 0, 1, 2, 0, 0, 0 },
                { 0, 0, 2, 0, 0, 3, 0 },
                { 1, 2, 0, 1, 3, 0, 0 },
                { 2, 0, 1, 0, 0, 0, 1 },
                { 0, 0, 3, 0, 0, 2, 0 },
                { 0, 3, 0, 0, 2, 0, 1 },
                { 0, 0, 0, 1, 0, 1, 0 }
            };
        }

    }
}
