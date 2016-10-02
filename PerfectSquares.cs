public class Solution {
    Dictionary<int, int> cache = new Dictionary<int, int> ();
    public int NumSquares(int n) {
        if(n == 0) return 0;
        if( n == 1 || n==4 || n==9)
            return 1;
            
        if(n == 2) return 2;
        
        int max = (int) Math.Sqrt(n);
        int current;
        
        
        //Console.WriteLine("N: {0} Max : {1}", n, max);
        if(cache.TryGetValue(n, out current)) return current;
        current = -1;
        
        while(max > 0)
        {
            int newn = n- (max*max);
            int sq = NumSquares(newn);
            if(sq == -1) { max --; continue; }
            if(current == -1 ) 
            {
                current = 1+sq;
            }
            else 
            {
                current=Math.Min(current, 1+sq);
            }
            
            max--;
        }
        cache.Add(n, current);
        return current;
    }
}
