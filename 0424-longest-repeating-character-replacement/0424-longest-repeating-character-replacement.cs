public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        int maxf = 0;
        int longest = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (map.ContainsKey(s[right]))
                map[s[right]]++;
            else
                map[s[right]] = 1;

            maxf = Math.Max(maxf, map[s[right]]);

            while (right - left + 1 - maxf > k)
            {
                map[s[left]]--;
                left++;
            }

            longest = Math.Max(longest, right - left + 1);
        }

        return longest;
    }
}