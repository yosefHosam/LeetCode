public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (charCounts.ContainsKey(s[i]))
                charCounts[s[i]]++;
            else
                charCounts[s[i]] = 1;
            if (charCounts.ContainsKey(t[i]))
                charCounts[t[i]]--;
            else
                charCounts[t[i]] = -1;
        }

        if (charCounts.Values.Any(count => count != 0))
            return false;

        return true;
    }
}