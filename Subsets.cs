public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> sets = new List<IList<int>>();
        Subsets(nums, 0, new List<int>(), sets);
        return sets;
    }
    public void Subsets(int []nums, int index, List<int> list, IList<IList<int>> sets)
    {
        if(nums.Length == index) {
            sets.Add(list);
            return;
        }
        Subsets(nums, index+1, list, sets);
        List<int> newList = new List<int> (list);
        newList.Add(nums[index]);
        Subsets(nums, index+1, newList, sets);
    }
}
