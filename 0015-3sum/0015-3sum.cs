public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        int length = nums.Length;

        // Early exit: Cannot form triplets with fewer than 3 numbers
        if (length < 3) return res;

        Array.Sort(nums);

        // Early return: If largest element is negative, zero sum is impossible
        if (nums[length - 1] < 0) return res;

        for (int i = 0; i < length - 1; i++)
        {
            // Early break: Stops loop if nums[i] > 0 or if nums[0] > 0 on first pass
            if (nums[i] > 0) break;

            // Skip duplicate outer values for 'i' to prevent duplicate triplets
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = length - 1;

            while (left < right)
            {
                int threeSum = nums[i] + nums[left] + nums[right];

                if (threeSum < 0)
                    left++;
                else if (threeSum > 0)
                    right--;
                else
                {
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });

                    left++;
                    right--;

                    // Mandatory: Skip duplicate left values
                    while (left < right && nums[left] == nums[left - 1]) left++;

                    // Optional: Skip duplicate right values to save extra loop steps
                    while (left < right && nums[right] == nums[right + 1]) right--;
                }
            }
        }

        return res;
    }
}