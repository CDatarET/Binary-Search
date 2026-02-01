class Solution:
    def helper(self, nums, target, low, high):
        if low > high:
            return -1

        if target == nums[(low + high) // 2]:
            return (low + high) // 2
        elif target < nums[(low + high) // 2]:
            return self.helper(nums, target, low, (low + high) // 2 - 1)
        else:
            return self.helper(nums, target, (low + high) // 2 + 1, high)

    def search(self, nums, target):
        return self.helper(nums, target, 0, len(nums) - 1)
