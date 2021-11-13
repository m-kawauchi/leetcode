using System.Collections.Generic;
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
    public IList<int> PreorderTraversal(TreeNode root) {
        var ans = new List<int>();
        AddValue(root, ans);
        return ans;
    }
    static void AddValue(TreeNode root, IList<int> ans) {
        ans.Add(root.val);
        AddValue(root.left);
        AddValue(root.right);
        return;
    }
}