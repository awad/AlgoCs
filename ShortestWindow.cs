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
        
        int minLeft, minRight;
        minLeft = minRight = -1;
        for(int i=0; i<s.Length; i++)
        {
            if(count < t.Length)
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
            }
            bool flag;
            while(count == t.Length && left<s.Length)
            {
                cur = i - left;
                if(cur <= size)
                {
                    size = cur;
                    minLeft = left;
                    minRight = i;
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
        // Console.WriteLine("{0} {1}", minLeft, minRight);
        return s.Substring(minLeft, minRight-minLeft+1);
    }
}
