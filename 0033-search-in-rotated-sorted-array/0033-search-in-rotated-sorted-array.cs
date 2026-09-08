public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            // Calculate mid safely to prevent overflow
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;

            // Check if the right half is sorted
            if (nums[mid] < nums[right])
            {
                // Check if target is inside the sorted right half
                if (target > nums[mid] && target <= nums[right])
                    left = mid + 1;  // Search right
                else
                    right = mid - 1; // Search left
            }
            // Otherwise, the left half is sorted
            else
            {
                // Check if target is inside the sorted left half
                if (target >= nums[left] && target < nums[mid])
                    right = mid - 1; // Search left
                else
                    left = mid + 1;  // Search right
            }
        }

        return -1; // Target not found
    }
}