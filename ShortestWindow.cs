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
        
        int left = -1; int count = 0;
        int size = int.MaxValue;
        int cur = 0;
        
        int minLeft;
        minLeft = -1;
        for(int i=0; i<s.Length; i++)
        {
            if(dict.TryGetValue(s[i], out value))
            {
                if(left == -1) 
                {
                    left = i;
                }
                if(value > 0) {
                    count++;
                }
                dict[s[i]]--;
            }
            
            bool flag;
            while(count == t.Length)
            {
                cur = i - left + 1;
                if(cur <= size)
                {
                    size = cur;
                    minLeft = left;
                }
                if(dict.TryGetValue(s[left], out value))
                {
                    if(dict[s[left]]++ == 0)
                        count--;
                }
                left++;
            }
        }
        if(minLeft == -1)
            return "";
        return s.Substring(minLeft, size);
    }
}
