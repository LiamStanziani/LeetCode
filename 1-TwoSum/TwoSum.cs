public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numsMap = new Dictionary<int, int>();
        int numLength = nums.Length;

        for (int i = 0; i < numLength; i++) 
        {
            int complement = target - nums[i];
            if (numsMap.ContainsKey(complement)) 
            {
                return new int[] {numsMap[complement], i};
            }
            numsMap[nums[i]] = i;
        }

        return new int[0];
    }
}