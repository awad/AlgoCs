using System.Collections.Generic; 

public class Solution {
    public int LengthLongestPath(string input) {
        String[] split = input.Split('\n');
        
        Stack<int> stack = new Stack<int>();
        stack.Push(0);
        int maxLen = 0;
        foreach(String s in split)
        {
            int curLevel = s.LastIndexOf("\t") + 1;
            //Console.WriteLine(curLevel);
            while(curLevel + 1 < stack.Count)
            {
               // Console.WriteLine(stack.Count);
                stack.Pop();
            }
            
            int len = stack.Peek() + s.Length - curLevel + 1;
            //Console.WriteLine(len);
            stack.Push(len);
            
            // check if it is file
            if(s.Contains(".")) maxLen = Math.Max(maxLen, len-1); 
        }
        return maxLen;
        
    }
}
