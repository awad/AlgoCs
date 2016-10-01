/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public class IntervalComparer: IComparer<Interval>
    {
        public int Compare(Interval x, Interval y)
        {
            if (x.start > y.start)
            {
                return 1;
            }
            else return -1;
        }
    }

    public IList<Interval> Merge(IList<Interval> intervals) {
        if(intervals == null || intervals.Count <=1)
            return intervals;
        //Sort intervals by start
        intervals = intervals.OrderBy(interval => interval.start).ToList();
        //intervals.Sort(new IntervalComparer());
        
        List<Interval> ret = new List<Interval>();
        //Look at end , if end > start -> merge. else new interval
        Interval current = new Interval();
        current.start = intervals[0].start;
        current.end = intervals[0].end;
        for(int i=1; i<intervals.Count; i++)
        {   
            Interval temp = intervals[i];
            if(current.end >= temp.start)
            {
                current.end = Math.Max(temp.end, current.end);
            }
            else
            {
                ret.Add(current);
                current = temp;
            }
        }
        
        ret.Add(current);
        return ret;
    }
}
