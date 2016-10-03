public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s.ToCharArray())
        {
            if(c == '(' || c == '[' || c == '{')
                stack.Push(c);
            else
            {
                if(stack.Count == 0)
                    return false;
                    
                char top = stack.Pop();
                switch(c)
                {
                    case ')':
                        if(top != '(')  
                            return false;
                        break;
                    case ']': 
                        if(top != '[') 
                            return false;
                        break;
                    case '}': 
                        if(top != '{') 
                            return false;
                        break;
                }
            }
        }
        if(stack.Count == 0)
          return true;
         
        return false;
    }
}
