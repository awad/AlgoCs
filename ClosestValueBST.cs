/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int ClosestValue(TreeNode root, double target) {
        int current = root.val;
        double diff = Math.Abs(current - target);
        if(target < root.val && root.left!=null)
        {
            int cLeft = ClosestValue(root.left, target);
            double diffLeft = Math.Abs(cLeft - target);
            if(diffLeft < diff)
            {
                diff = diffLeft;
                current = cLeft;
            }
        }
        else if(root.right != null)
            {
                int cRight = ClosestValue(root.right, target);
                double diffRight = Math.Abs(cRight - target);
                if(diffRight < diff)
                {
                    diff = diffRight;
                    current = cRight;
                }
            }
        
        return current;
    }
}
