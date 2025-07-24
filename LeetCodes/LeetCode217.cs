namespace ConsoleApp1;
    // 217. Contains Duplicate - 00:55:25
public class Solution
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 1, 4 };
        System.Console.WriteLine(ContainsDuplicate(nums));
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }
        return false;
    }

}

// Work in progress solution:
// public class Solution {
//     public bool ContainsDuplicate(int[] nums)
//     {
//         // nums = [1,2,3,1]
//         int currentIteration = 0; // currentIteration = 1
//         int i = 0; // i = 0
        
//         for (i = 0; i < nums.Length; i++) // i = 0, Iterates 4 times.
//         {
//             if (currentIteration == i) // 0 == 0
//             {
//                 break;
//             }
//             else if (nums[currentIteration] == nums[i])
//             {
//                 return true;
//             }
//             else
//             {
                
//             }
//         }
//         currentIteration++;
//         if (currentIteration < nums.Length - 1)
//         {
//             i = 0;
//         }

//         return false;
//     }
// }