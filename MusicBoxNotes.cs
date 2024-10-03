using System;

namespace Projekt1;

// Base contianer for storing musical notes
public class MusicBoxNotes
{   
    // Timings
    public int Whole {get; protected set;}
    public int Half {get; protected set;}
    public int Quarter {get; protected set;}

    // Notes
    public static readonly int[] C = new int[] { 131, 262, 523};
    public static readonly int[] D = new int[] { 147, 294, 587};
    public static readonly int[] E = new int[] { 165, 330, 659};
    public static readonly int[] F = new int[] { 175, 349, 698};
    public static readonly int[] G = new int[] { 196, 392, 784};
    public static readonly int[] A = new int[] { 220, 440, 880};
    public static readonly int[] B = new int[] { 247, 494, 988};
    public static readonly int[] Diss = new int[] { 155, 311, 622};

    // Octaves
    public const int oct1 = 0;
    public const int oct2 = 1;
    public const int oct3 = 2;
    public const int oct4 = 3;
}
