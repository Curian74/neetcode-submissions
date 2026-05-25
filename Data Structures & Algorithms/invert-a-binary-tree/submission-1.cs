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
    public TreeNode InvertTree(TreeNode root) {
        BFS(root);
        return root;
    }

    public void BFS(TreeNode root) {
        if (root == null) return;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0) {
            var cur = q.Dequeue();
            var t = cur.left;
            cur.left = cur.right;
            cur.right = t;

            if (cur.left != null) {
                q.Enqueue(cur.left);
            }

            if (cur.right != null) {
                q.Enqueue(cur.right);
            }
        }
    }
}
