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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res=new List<IList<int>>();
        var q = new Queue<TreeNode>();
        if (root!=null) q.Enqueue(root);
        while(q.Count>0)
        {
            var childCount=q.Count;
            var child=new List<int>();
            for(int i=0;i<childCount;i++)
            {
                var first=q.Dequeue();
                child.Add(first.val);
                if (first.left != null) q.Enqueue(first.left);
                if (first.right != null) q.Enqueue(first.right);
            }
            res.Add(child);
        }
        return res;
    }
}
