public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {

            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sortedKey = new string(chars);

            if (!anagramGroups.ContainsKey(sortedKey))
                anagramGroups[sortedKey] = new List<string>();

            anagramGroups[sortedKey].Add(str);
        }

        return new List<IList<string>>(anagramGroups.Values);
    }
}