public class Solution {
    string [] Less20 = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "twenty" };
    string [] Tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
    string [] Thousands = {"", "Thousand", "Million", "Billion" };
    
    public string NumberToWords(int num) {
        if(num == 0)
            return "Zero";
        int i=0;
        string res = "";
        while(num > 0)
        {
            if(num % 1000 != 0)
                res =  helper(num%1000) + Thousands[i] + " " + res;
            num = num/1000;
            i++;
        }
        return res.Trim();
    }
    
    public string helper(int n)
    {   
        if(n == 0) return "";
        if(n < 20) return Less20[n]+ " ";
        if(n < 100) return Tens[n/10] +  " " + helper(n % 10);
        else return Less20[n/100] + " Hundred " + helper(n % 100);
    }
}
