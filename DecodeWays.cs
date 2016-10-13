public class Solution {
    int[] cache;
    public int NumDecodings(string s) {
        if(String.IsNullOrEmpty(s)) return 0;
        cache = new int[s.Length];
        for(int i =0; i<s.Length;i++ ) cache[i] = -1;
        int n = NumDecodings(s, 0);
        //Console.WriteLine(n);
        if(n < 0) 
            return 0;
        return n;
    }
    public int NumDecodings(string s, int index) {
        if(index > s.Length) return 0;
        if(index == s.Length) return 1;
        if(s[index] == '0') 
        {
            return 0;
        }
        if(index == s.Length - 1) return 1;
        if(cache[index] != -1) return cache[index];
        int n = s[index] - '0';
        int nn = s[index + 1] - '0';
        
        if(n == 2 && nn <= 6)
        {
            if(nn > 0)
                cache[index] =  NumDecodings(s, index+1) + NumDecodings(s, index + 2);
            else cache[index] = NumDecodings(s, index + 2);
        }
        else if(n == 1)
        {
            if(nn > 0)
                cache[index] = NumDecodings(s, index+1) + NumDecodings(s, index + 2);
            else cache[index] = NumDecodings(s, index + 2);
        }
        else 
            cache[index] = NumDecodings(s, index+1);
        
        return cache[index];
    }
}
