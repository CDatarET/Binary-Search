public class Solution {
    public int helper(int[] nums, int target, int low, int high){
        if(low > high) return(-1);
        if(target == nums[(low + high) / 2]) return((low + high) / 2);
        else if(target < nums[(low + high) / 2]) return(helper(nums, target, low, (low + high) / 2 - 1));
        else return(helper(nums, target, (low + high) / 2 + 1, high));
    }

    public int Search(int[] nums, int target) {
        return(helper(nums, target, 0, nums.Length - 1));
    }
}
