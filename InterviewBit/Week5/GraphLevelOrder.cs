/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
class Solution {
    public List<List<int>> levelOrder(TreeNode a) {
        var levels = new List<List<int>>();
        Collect(a, 0, levels);

        return levels;
    }

    private void Collect(TreeNode a, int level, List<List<int>> levels) {
        if (a == null)
            return;

        if (level >= levels.Count)
            levels.Add(new List<int>());

        levels[level].Add(a.val);

        Collect(a.left, level + 1, levels);
        Collect(a.right, level + 1, levels);
    }
}
