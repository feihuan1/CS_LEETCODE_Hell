using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        List<int>[] count = new List<int>[nums.Length + 1]; // +1 to handle frequency = nums.Length
        for (int i = 0; i < count.Length; i++)
        {
            count[i] = new List<int>(); 
        }

        foreach (KeyValuePair<int, int> pair in dict)
        {
            count[pair.Value].Add(pair.Key);
        }

     
        List<int> output = new List<int>();
        for (int i = count.Length - 1; i >= 0; i--)
        {
            foreach (int num in count[i])
            {
                output.Add(num);
                if (output.Count == k)
                {
                    return output.ToArray();
                }
            }
        }

        return output.ToArray();
    }

    static void Main()
    {
        int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        int[] result = TopKFrequent(nums, k);
        Console.WriteLine("Top " + k + " frequent elements:");
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }

        int[] nums2 = new int[] { 1, 2 };
        int k2 = 2;
        int[] result2 = TopKFrequent(nums2, k2);
        Console.WriteLine("Top " + k2 + " frequent elements:");
        foreach (int num in result2)
        {
            Console.WriteLine(num);
        }
    }
}