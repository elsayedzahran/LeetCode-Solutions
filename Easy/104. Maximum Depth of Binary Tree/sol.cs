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
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;

        var stack = new Stack<KeyValuePair<int,TreeNode>>();        
        var res = 0;

        stack.Push(new KeyValuePair<int,TreeNode>(0, root));

        while(stack.Count != 0)
        {
            var (depth, currentNode) = stack.Pop();
            depth++;

            if(currentNode.left != null) {
                stack.Push(new KeyValuePair<int,TreeNode>(depth, currentNode.left));
            }

            if(currentNode.right != null) {
                stack.Push(new KeyValuePair<int,TreeNode>(depth, currentNode.right));
            }

            res=Math.Max(res, depth);
        }
        return res;
    }
}
