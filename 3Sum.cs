public class Solution {
    public IList<IList<int>> ThreeSum(int[] numbers) {
        List<int> nums = new List<int>(numbers);
        nums.Sort();
        int target =0; int lo, hi;
        HashSet<IList<int>> res = new HashSet<IList<int>>();
        List<int> temp = new List<int>();
        for(int i=0; i<nums.Count; i++)
        {
            if(i>0 && nums[i-1] == nums[i]) continue;
            target = -1 * nums[i];
            //lo=i+1 ensures sorted order and eliminates duplicates
            lo = i+1; hi = nums.Count - 1;
            while(lo<hi)
            {
                if(hi == i) { hi--; continue; }
                //Avoid duplicate entries... if we have already processed nums[lo] or nums[hi] skip duplicates.
                //bounds check is important to ensure we atleast process the combo once...
                if(lo != i+1 && nums[lo] == nums[lo-1]) { lo++; continue;}
                if(hi!= nums.Count-1 && nums[hi] == nums[hi+1]) { hi--; continue;}
                
                if(nums[lo] + nums[hi] == target)
                {
                   // Console.WriteLine("Found {0}, {1}, {2}", nums[i], nums[lo], nums[hi]);
                    temp = new List<int>();
                    temp.Add(nums[i]);
                    temp.Add(nums[lo]);
                    temp.Add(nums[hi]);
                    res.Add(temp);
                    lo++; hi--;
                }
                else if(nums[lo] + nums[hi] < target)
                {
                    lo++;
                }
                else hi--;
            }
        }
        IList<IList<int>> resList = res.ToList();
        return resList;
        
    }
}
