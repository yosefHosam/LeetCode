public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (var s in strs) {
            int[] count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(s);
        }

        return map.Values.ToList<IList<string>>();
    }
}