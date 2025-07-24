namespace ConsoleApp1;
// 268. Missing Number - 00:32:08
public class Solution
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 3, 2, 4 };
        System.Console.WriteLine(MissingNumber(nums));
    }

    public static int MissingNumber(int[] nums) {
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
