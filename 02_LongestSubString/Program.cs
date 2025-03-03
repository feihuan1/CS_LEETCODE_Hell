

public class Program
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();

        int maxLength = 0;
        int left = 0;

        for(int right = 0; right < s.Length; right++)
        {
            while(set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);

            maxLength = Math.Max(maxLength, right - left + 1);

        }


        return maxLength;
    }

    static void Main()
    {
        System.Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        System.Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
        System.Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
    }
}