using System;
using System.Collections.Generic;

class DistanceCalculator
{
    public static double TwoPointDistance(params int[] args)
    {
        if (args.Length % 2 != 0)
        {
            throw new ArgumentException("args", "Please provide an even set of parameters");
        }
        List<int> pValues = new List<int>();
        List<int> qValues = new List<int>();

        for (int i = 0; i < args.Length; i++)
        {
            if (i%2 == 0)
            {
                pValues.Add(args[i]);
            }
            else
            {
                qValues.Add(args[i]);
            }
        }

        var preSquareValues = 0.0d;

        for (int i = 0; i < qValues.Count; i++)
        {
            preSquareValues += Math.Pow(pValues[i] - qValues[i], 2);
        }
        Console.WriteLine(preSquareValues);
        return Math.Sqrt(preSquareValues);
    }
    
}

class Tester
{
    static void Main(string[] args)
    {
        Console.WriteLine(DistanceCalculator.TwoPointDistance(1, 2, 3, 4, 5, 6, 7, 8));  
    }
}