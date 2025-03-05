// solution in other language
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> dictS = new Dictionary<char, int>();
        Dictionary<char, int> dictT = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(dictS.ContainsKey(s[i]))
            {
                dictS[s[i]] += 1;
            } else {
                dictS[s[i]] = 1;
            }

            if(dictT.ContainsKey(t[i]))
            {
                dictT[t[i]] += 1;
            } else {
                dictT[t[i]] = 1;
            }
        }

        foreach(KeyValuePair<char, int> entry in dictS)
        {
            if(!dictT.ContainsKey(entry.Key) || dictT[entry.Key] != entry.Value)
            {
                return false;
            }
        }
        return true;
    }
}

// c# solution
public class Solution2 {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] count = new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }
        foreach(int num in count)
        {
            if(num != 0)
            {
                return false;
            }
        }

        return true;
    }
}