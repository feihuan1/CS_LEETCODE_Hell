

public class Program
{
    public static int[] TwoSum(int[] nums, int target)
    {
        // i hate this so much!!!
        Dictionary<int, int> obj = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (obj.ContainsKey(diff))
            {
                return new int[] { obj[diff], i };
            }
            else
            {
                obj[nums[i]] = i;
            }
        }

        return new int[] { -1, -1 };
    }

    static void Main()
    {
        int[] numbers = { 3,2,4 };
        int target = 6;
        int[] result = TwoSum(numbers, target);

        Console.Write(string.Join(", ", result));
    }
}