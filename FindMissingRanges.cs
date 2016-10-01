public class Solution {
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
        int start = lower;
        List<string> list = new List<string>();
        string missing;
        foreach(int n in nums)
        {
            if(start<n)
            {
                if(start == n-1)
                    missing = start.ToString();
                else missing = start + "->" + (n-1);
                
                list.Add(missing);
            }
            start = n+1;
        }
        if(upper >= start)
        {
            if(upper == start)
                missing = start.ToString();
            else missing = start + "->" + upper;
            list.Add(missing);
        }
        return list;
    }
}
