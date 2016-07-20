using System;
using System.Collections.Generic;

public class Solution {
    public static int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        int value;
        for(int i=0; i<nums.Length; i++)
        {
            if(map.TryGetValue(nums[i], out value))
            {
                return new int[] {value, i};
            }
            
            else if(!map.TryGetValue(target-nums[i], out value))
                map.Add(target-nums[i], i);
        }
        return null;
    }

	
	public static void Main(String [] args)
	{
		int [] arr = TwoSum(new int[] {2, 3, 7, 9}, 10);
		Console.WriteLine(arr[0] + " " + arr[1]);
	}
}
