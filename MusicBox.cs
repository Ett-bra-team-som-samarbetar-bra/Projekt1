
using Projekt1;

public class MusicBox : MusicBoxNotes
{   
    public void Blues()
    {   
        Console.WriteLine("Now playing: Blues");

        Whole = 500;
        Half = Whole / 2;        

        Console.Beep(C[oct2], Half);
        Console.Beep(Diss[oct2], Whole);
        Console.Beep(F[oct2], Half);
        Console.Beep(G[oct2], Whole);

        Console.Beep(C[oct2], Half);
        Console.Beep(Diss[oct2], Whole);
        Console.Beep(F[oct2], Half);

        Console.Beep(C[oct2], Whole);
        Console.Beep(C[oct2], Whole);
    }

    public void Pirates()
    {   
        Console.WriteLine("Now playing: Pirates");
        
        Whole = 800;
        Half = Whole / 2;        
        Quarter = Whole / 4;

        Console.Beep(A[oct1], Quarter);
        Console.Beep(C[oct2], Quarter);
        Console.Beep(D[oct2], Whole);

        Console.Beep(D[oct2], Quarter);
        Console.Beep(E[oct2], Quarter);
        Console.Beep(F[oct2], Whole);

        Console.Beep(F[oct2], Quarter);
        Console.Beep(G[oct2], Quarter);
        Console.Beep(E[oct2], Half);
        Console.Beep(E[oct2], Half);

        Console.Beep(D[oct2], Quarter);
        Console.Beep(C[oct2], Quarter);
        Console.Beep(D[oct2], Whole);
    }

    public void SweetChildOfMine()
    {
        
        for (int i = 0; i < 2; i++)
        {
            Console.Beep(G[oct2], 250);
            Console.Beep(G[oct3], 250);
            Console.Beep(D[oct3], 250);
            Console.Beep(C[oct3], 250);
            Console.Beep(C[oct4], 250);
            Console.Beep(D[oct3], 250);
            Console.Beep(B[oct3], 250);
            Console.Beep(D[oct3], 250);
        }

        for (int i = 0; i < 2; i++)
        {
            Console.Beep(A[oct2], 250);
            Console.Beep(G[oct3], 250);
            Console.Beep(D[oct3], 250);
            Console.Beep(C[oct3], 250);
            Console.Beep(C[oct4], 250);
            Console.Beep(D[oct3], 250);
            Console.Beep(B[oct3], 250);
            Console.Beep(D[oct3], 250);
        }

        for (int i = 0; i < 2; i++)
        {
            Console.Beep(C[oct3], 250);
            Console.Beep(G[oct3], 250);
            Console.Beep(D[oct3], 250);
            Console.Beep(C[oct3], 250);
            Console.Beep(C[oct4], 250);
            Console.Beep(D[oct3], 250);
            Console.Beep(B[oct3], 250);
            Console.Beep(D[oct3], 250);
        }

        Console.Beep(G[oct2], 250);
        Console.Beep(G[oct3], 250);
        Console.Beep(D[oct3], 250);
        Console.Beep(C[oct3], 250);
        Console.Beep(C[oct4], 250);
        Console.Beep(D[oct3], 250);
        Console.Beep(B[oct3], 250);
        Console.Beep(D[oct3], 250);
    }
}

