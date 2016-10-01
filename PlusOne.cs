public class Solution {
    public int[] PlusOne(int[] digits) {
        int [] res = new int[digits.Length+1];
        int carry =1;
        
        for(int i=digits.Length-1; i>=0; i--)
        {
            if(digits[i]+carry > 9)
            {
                carry = 1;
                digits[i] = (digits[i] + carry) % 10;
             }
             else 
             {
                 digits[i] = digits[i] + carry;
                 carry =0;
             }
        }
        if(carry == 1)
        {
            res[0] = 1;
            for(int i=0;i<digits.Length;i++)
            {
                res[i+1] = digits[i];
            }
            return res;
        }
        return digits;
    }
}
