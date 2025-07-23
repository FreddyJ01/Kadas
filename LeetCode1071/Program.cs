namespace LeetCode1071;

class Program
{
    static void Main(string[] args)
    {


    }

    // 1071. Greatest Common Divisor of Strings - 01:35:58

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