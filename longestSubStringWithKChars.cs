public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        if(k == 0) return 0;
        
        int count = 0;
        char [] sArr = s.ToCharArray();
        int start = 0;
        int size = 0;
        int maxSize = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();;
        int left =0;
        for(int i=0; i < s.Length; i++)
        {
            int value;
            if(dict.TryGetValue(sArr[i], out value))
            {
                dict[sArr[i]] += 1;
                
            }
            else
            {
                value = 1;
                count ++;
                dict.Add(sArr[i], value);
            }
            
           // Console.WriteLine(sArr[i] + " " + dict[sArr[i]]);
            while(count > k)
            {
                int val;
               
                if(dict.TryGetValue(sArr[left], out val))
                {  
                  //  Console.WriteLine(sArr[left] + " " + left + " " + i + " " + val);
                    if(--val == 0) 
                    {
                        dict.Remove(sArr[left]);
                        count --;
                    }
                    else
                    {
                        dict[sArr[left]] = val;
                    }
                    
                    left++;
                }
            }
            maxSize = Math.Max(maxSize, i - left + 1);
        }
        return maxSize;
    }
}
