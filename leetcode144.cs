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
        return AddValue(root, new List<int>());
    }
    public List<int> AddValue(TreeNode root, List<int> ans) {
        if (root == null)
        {
            return ans;
        }
        ans.Add(root.val);
        ans = AddValue(root.left, ans);
        ans = AddValue(root.right, ans);
        return ans;
    }
}