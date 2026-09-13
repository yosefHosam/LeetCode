public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int maxf = 0;
        int longest = 0;
        int[] arr = new int[26];

        for (int right = 0; right < s.Length; right++)
        {
            arr[s[right] - 'A']++;
            maxf = Math.Max(maxf, arr[s[right] - 'A']);

            while ((right - left + 1) - maxf > k)
            {
                arr[s[left] - 'A']--;
                left++;
            }

            longest = Math.Max(longest, right - left + 1);
        }

        return longest;
    }
}