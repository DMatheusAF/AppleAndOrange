using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int numApples = 0, numOranges = 0;

        foreach (int apple in apples)
        {
            int location = apple + a;
            if (location >= s && location <= t)
            {
                numApples++;
            }
        }

        foreach (int orange in oranges)
        {
            int location = orange + b;
            if (location >= s && location <= t)
            {
                numOranges++;
            }
        }

        Console.WriteLine(numApples);
        Console.WriteLine(numOranges);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int s = 7;

        int t = 11;

        int a = 5;

        int b = 15;

        List<int> apples = new List<int> { -2, 2, 1};

        List<int> oranges = new List<int> { 5, -6 };

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
