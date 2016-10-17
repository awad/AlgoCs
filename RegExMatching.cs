public class Solution {
    Dictionary<string, bool> cache;
    bool value;
    public bool IsMatch(string s, string p) {
        cache = new Dictionary<string, bool>();
        return IsMatch(s, 0, p, 0);
    }
    
    public bool IsMatch(string s, int i, string p, int j) {
        string index = i + " " + j;
        if(cache.TryGetValue(index, out value))
        {
            return value; 
        }
        
        cache[index] = false;
        if(i<0 || j<0) return false;
        
        if(i == s.Length && j==p.Length) return true;
        
        
        if(i == s.Length && p[j] == '*') return IsMatch(s, i-1, p, j+1) || IsMatch(s, i, p, j+1);
        if(i == s.Length && j+1<p.Length && p[j+1] == '*') return IsMatch(s, i, p, j+2);
        
        if(i >= s.Length || j>=p.Length) return false;
          
        if(s[i] == p[j] || p[j] == '.')
            return IsMatch(s, i+1, p, j+1);
 
        if(p[j] == '*')
        {
            bool a = false;
            if(p[j-1] == s[i] || p[j-1] == '.')
              a = IsMatch(s, i+1, p, j);
            
              cache[index] = a || IsMatch(s, i, p, j+1) || IsMatch(s, i-1, p, j+1);
              
        }
        
        if(j+1 <p.Length && p[j+1] == '*')
        {
            cache[index] = IsMatch(s, i, p, j+2);
        }
        
        return cache[index];
    }
}
