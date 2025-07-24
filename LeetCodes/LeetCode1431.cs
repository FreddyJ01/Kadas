namespace ConsoleApp1;
    // 1431. Kids With the Greatest Number of Candies - 00:27:07
public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        bool[] result = new bool[candies.Length];
        int mostCandies = 0;

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > mostCandies)
            {
                mostCandies = candies[i];
            }
            else
            {
                mostCandies = mostCandies;
            }
        }

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= mostCandies)
            {
                result[i] = true;
            }
            else
            {
                result[i] = false;
            }
        }

        return result;
    }
}

