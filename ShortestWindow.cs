public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary <char, int> dict = new Dictionary <char, int>();
        int value = 0;
        for(int i=0; i< t.Length; i++)
        {
            if(dict.TryGetValue(t[i], out value))
                dict[t[i]]++;
            else
                dict[t[i]]=1;
        }
        
        int left = 0; int count = 0;
        int size = int.MaxValue;
        int cur = 0;
        int minLeft = -1;
        
        for(int i=0; i<s.Length; i++)
        {
            //Move right till we have a valid solution
            if(dict.TryGetValue(s[i], out value))
            {
                //value = 0 if character has been hit all the times it is needed.
                if(value > 0) {
                    count++;
                }
                dict[s[i]]--;
            }
            
            //Valid solution found
            while(count == t.Length)
            {
                cur = i - left + 1;
                if(cur <= size)
                {
                    size = cur;
                    minLeft = left;
                }
                
                //Remove s[left] till we have a invalid string again
                if(dict.TryGetValue(s[left], out value))
                {
                    if(dict[s[left]]++ == 0)
                        count--;
                }
                //try to find next left pointer
                left++;
            }
        }
        if(minLeft == -1)
            return "";
        return s.Substring(minLeft, size);
    }
}
