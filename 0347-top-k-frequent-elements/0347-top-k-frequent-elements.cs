public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // O(N)
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!frequencyMap.ContainsKey(num))
                frequencyMap[num] = 1;
            else
                frequencyMap[num]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var (key, value) in frequencyMap)
        {
            if (buckets[value] == null)
                buckets[value] = new List<int>();

            buckets[value].Add(key);
        }

        int[] ans = new int[k];
        int index = 0;


        for (int i = buckets.Length - 1; i >= 0 && index < k; i--)
        {
            if (buckets[i] != null)
            {
                foreach (int num in buckets[i])
                {
                    ans[index++] = num;
                    
                    if (index == k) 
                        return ans;
                }
            }
        }

        return ans;
    }
}



