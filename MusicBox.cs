
namespace Projekt1
{
    public static class MusicBox 
    {
        // Notes
        static int[] C = new int[] { 131, 262, 523};
        static int[] D = new int[] { 147, 294, 587};
        static int[] E = new int[] { 165, 330, 659};
        static int[] F = new int[] { 175, 349, 698};
        static int[] G = new int[] { 196, 392, 784};
        static int[] A = new int[] { 220, 440, 880};
        static int[] B = new int[] { 247, 494, 988};
        static int[] Diss = new int[] { 155, 311, 622};

        
        public static void Blues()
        {   
            int whole = 500;
            int half = whole / 2;        
            int quarter = whole / 4;

            Console.Beep(C[2], half);
            Console.Beep(Diss[2], whole);
            Console.Beep(F[2], half);
            Console.Beep(G[2], whole);

            Console.Beep(C[2], half);
            Console.Beep(Diss[2], whole);
            Console.Beep(F[2], half);

            Console.Beep(C[2], whole);
            Console.Beep(C[2], whole);
        }

        public static void Pirates()
        {   
            int whole = 800;
            int half = whole / 2;        
            int quarter = whole / 4;

            Console.Beep(A[1], quarter);
            Console.Beep(C[2], quarter);
            Console.Beep(D[2], whole);

            Console.Beep(D[2], quarter);
            Console.Beep(E[2], quarter);
            Console.Beep(F[2], whole);

            Console.Beep(F[2], quarter);
            Console.Beep(G[2], quarter);
            Console.Beep(E[2], half);
            Console.Beep(E[2], half);

            Console.Beep(D[2], quarter);
            Console.Beep(C[2], quarter);
            Console.Beep(D[2], whole);
        }
    }
}
