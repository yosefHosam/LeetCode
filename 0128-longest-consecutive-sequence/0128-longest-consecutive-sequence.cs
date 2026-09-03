public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNumber = num;
                int currentStreak = 1;

                while (set.Contains(++currentNumber))
                {
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}
