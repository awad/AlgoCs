public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if(string.IsNullOrEmpty(digits)) return new List<string>();
        IList<string> combo = new List<string>();
        LetterCombinations("", digits, 0, combo);
        return combo;
    }
    public void LetterCombinations(string s, string digits, int start, IList<string> res) {
        if(start == digits.Length) {
            res.Add(s);
            return;
        }
        string dig = GetDigits(digits[start]);
        
        for(int j=0; j<dig.Length; j++)
        {
            LetterCombinations(s+dig[j], digits, start + 1, res);
        }
    }
    public string GetDigits(char c)
    {
        switch(c)
        {
            case '2': return "abc";
            case '3': return "def";
            case '4': return "ghi";
            case '5': return "jkl";
            case '6': return "mno";
            case '7': return "pqrs";
            case '8': return "tuv";
            case '9': return "wxyz";
            default : return null;
        }
    }
}
