using System;

class Solution
{
    static int jumpingOnClouds(int[] c)
    {
        var currentPosition = 0;
        var jumps = 0;
        var numberOfClouds = c.Length - 1;


        for (int i = 0; i < numberOfClouds; i++)
        {
            if (currentPosition + 2 <= numberOfClouds && c[currentPosition + 2] == 0)
            {
                currentPosition += 2;
                jumps++;
            }
            else if (currentPosition + 1 <= numberOfClouds && c[currentPosition + 1] == 0)
            {
                currentPosition += 1;
                jumps++;
            }
        }

        return jumps;

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
        int result = jumpingOnClouds(c);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
