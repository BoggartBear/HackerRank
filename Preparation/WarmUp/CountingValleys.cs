using System;

class Solution
{    
    static int countingValleys(int n, string s)
    {
        int currentAltitude = 0;
        int valleyCount = 0;

        var steps = s.ToCharArray();

        foreach (var step in steps)
        {
            if (step == 'U')
            {
                currentAltitude++;

                if (currentAltitude == 0)
                {
                    valleyCount++;
                }
            }

            if (step == 'D')
            {
                currentAltitude--;
            }
        }

        return valleyCount;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
