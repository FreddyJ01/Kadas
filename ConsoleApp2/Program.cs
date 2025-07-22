namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {


    }
    // 1768. Merge Strings Alternatively - 00:07:10
    public static string MergeAlternately(string word1, string word2)
    {
        string result = "";

        for (int i = 0; i < word1.Length || i < word2.Length; i++)
        {

            if (i < word1.Length)
            {
                result += word1[i];
            }

            if (i < word2.Length)
            {
                result += word2[i];
            }

        }

        return result;
    }

    // 1431. Kids With the Greatest Number of Candies - 00:27:07
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
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

    // 268. Missing Number - 00:32:08
    public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int missingNum;

        for (int i = 0; i <= n; i++) {
            if (!nums.Contains(i)) {
                return i;
            }
        }

    return -1;
    }
}

    // 1071. Greatest Common Divisor of Strings - 01:35:58
public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (!((str1 + str2).Equals((str2 + str1))))
        {
            return "";
        }

        int a = str1.Length;
        int b = str2.Length;

        // int a = 6;
        // int b = 4;

        while (b > 0)
        {
            int var = b; // var = 2
            b = a % b; // b = 0
            a = var; // a = 2
        }

        return str1.Substring(0, a);
    }

}