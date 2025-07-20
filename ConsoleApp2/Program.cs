namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine(MergeAlternately("abc", "123"));



        


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

}
