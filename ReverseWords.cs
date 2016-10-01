public class Solution {
    public string ReverseWords(string s) {
        s=s.Trim();
        if(s.Length == 0) return "";
        
        //Reverse string
        String rev = reverse(s);
        int start =0;
        StringBuilder result = new StringBuilder();
        for(int i=0;i<rev.Length; i++)
        {
            if(rev[i] == ' ' && rev[i-1]!=' ')
            {
                 for(int j=i; j>start; j--)      
                    result.Append(rev[j-1]);
                
                result.Append(" ");
                start = i+1;
            }
            if(rev[i] == ' ' && rev[i-1] ==' ')
            {
                start++;
            }
        }
       
        for(int j=rev.Length-1; j>=start; j--)      
            result.Append(rev[j]);
                
        return result.ToString();
    }
    
    public String reverse(string s)
    {
        StringBuilder res = new StringBuilder();
        for(int i=s.Length;i > 0; i--)
            res.Append(s[i-1]);
        return res.ToString();
    }
}
