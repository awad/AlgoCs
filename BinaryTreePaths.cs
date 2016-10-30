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
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> paths = new List<string>();
        if(root == null) return paths;
        BinaryTreePaths(root, "", paths);
        return paths;
        
    }
    
    public void BinaryTreePaths(TreeNode root, String path, IList<string> paths)
    {
        String newPath;
        if(path == "") newPath = root.val +"";
        else newPath = path +"->" + root.val;
        
        if(root.left == null && root.right == null) {
            paths.Add(newPath);
            return;
        }
        if(root.left != null){
            BinaryTreePaths(root.left, newPath, paths);
        }
        if(root.right != null){
            BinaryTreePaths(root.right, newPath, paths);
        }
        
    }
}
