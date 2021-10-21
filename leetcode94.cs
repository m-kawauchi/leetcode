/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> Ans = new List<int>();
    public IList<int> InorderTraversal(TreeNode root)
    {

        Helper(root);
        return Ans; 
    }
    

    public void Helper(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        helper(root.left);
        Ans.Add(root.val);
        helper(root.right);
    } 
}