using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    static List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anaGroup = new Dictionary<string, List<string>>();

        foreach(string str in strs)
        {
            int[] charCount = new int[26];

            foreach(char c in str)
            {
                charCount[c - 'a']++;
            }

            StringBuilder keyBuilder = new StringBuilder();

            for(int i = 0; i < 26; i++)
            {
                keyBuilder.Append("#");
                keyBuilder.Append(charCount[i]);// "#1#0#10..."
            }

            string key = keyBuilder.ToString();

            if(!anaGroup.ContainsKey(key))
            {
                anaGroup[key] = new List<string>();
            }

            anaGroup[key].Add(str);
        }


        return new List<List<string>>(anaGroup.Values);
    }

    static void Main()
    {
       string[] strs  = ["eat","tea","tan","ate","nat","bat"];
    
        List<List<string>> res =GroupAnagrams(strs);//[["bat"],["nat","tan"],["ate","eat","tea"]]

        foreach(List<string> group in res)
        {
            System.Console.WriteLine(string.Join(", ", group));
        }
    }
}