using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        int[] sequence = { 123, -45, 67, 8, 9, 10, 23, -1, 4, 5, 0 };


        List<int> result = ProcessSequence(sequence);

        Console.WriteLine(string.Join(", ", result));
    }

    public static List<int> ProcessSequence(int[] sequence)
    {

        List<int> lastDigits = new List<int>();
        HashSet<int> seenDigits = new HashSet<int>();


        foreach (int num in sequence)
        {
 
            if (num > 0)
            {

                int lastDigit = num % 10;


                if (!seenDigits.Contains(lastDigit))
                {

                    lastDigits.Add(lastDigit);
                    seenDigits.Add(lastDigit);
                }
            }
        }


        return lastDigits;
    }
}