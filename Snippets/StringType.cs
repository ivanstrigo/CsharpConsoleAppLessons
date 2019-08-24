using System;

class CodeSamples {

    internal static void Nullable()
    {

        int? i = null;

        int val = i ?? 0;

        Console.WriteLine("i is {0}", val);
        
    }
}