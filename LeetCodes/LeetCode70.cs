namespace ConsoleApp1;
// 70. Climbing Stairs - 00:45:27
public class Solution
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(ClimbStairs(6));
    }

    public static int ClimbStairs(int n)
    {
        int singleStep = 1;
        int doubleStep = 1;
        int temp = 0;

        for (int i = 0; i < n; i++)
        {
            temp = singleStep;
            singleStep = singleStep + doubleStep;
            doubleStep = temp;
        }
        return doubleStep;
    }
}
