using System;
using System.Collections.Generic;

class Solution
{
    static int sockMerchant(int n, int[] ar)
    {
        var colours = new List<int>();
        int pairs = 0;

        for (int i = 0; i < n; i++)
        {
            if (!colours.Contains(ar[i]))
            {
                colours.Add(ar[i]);

            }
            else
            {
                colours.Remove(ar[i]);
                pairs++;
            }
        }

        return pairs;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
