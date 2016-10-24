public class Solution {
    public IList<string> RemoveInvalidParentheses(string s) {
        IList<string> res = new List<string>();
        int rmL, rmR, open;
        rmL=rmR=open=0;
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<s.Length;i++)
        {
            if(s[i] == '(') rmL++;
            if(s[i] == ')') {
                if(rmL > 0) rmL--;
                else rmR++;
            }
        }
        remove(s, res, 0, rmL, rmR, open, sb);
        
        return res;
    }
    
    public void remove(string s, IList<string> res, int i, int rmL, int rmR, int open, StringBuilder sb)
    {
        if(i == s.Length && open == 0 && rmL == 0 && rmR == 0) {
                res.Add(sb.ToString());
                return;
        }
        if(i==s.Length || open <0 || rmL<0 || rmR < 0) return;
        
        int len = sb.Length;
        int j =0;
        if(s[i] == '(')
        {
            remove(s, res, i+1, rmL-1, rmR, open, sb);
            
            while(i+j < s.Length && s[i+j] == '(') j++;
            remove(s, res, i+j, rmL, rmR, open+j, sb.Append(s, i, j));
        }
        else if(s[i] == ')')
        {
            remove(s, res, i+1, rmL, rmR-1, open, sb);
            
            while(i+j < s.Length && s[i+j] == ')') j++;
            remove(s, res, i+j, rmL, rmR, open-j, sb.Append(s, i, j));
        }
        else
        {
            remove(s, res, i+1, rmL, rmR, open, sb.Append(s[i]));
        }
        sb.Length = len;
        
    }
}
