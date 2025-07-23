namespace LeetCode268;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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
