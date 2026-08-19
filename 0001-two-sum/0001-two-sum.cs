public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (map.ContainsKey(complement)) {
                int complementIndex = map[complement];
                return [i, complementIndex];
            }

            map[nums[i]] = i;
        }

        return [];
    }
}