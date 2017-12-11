public List<int> inorderTraversal(TreeNode A) {
    var result = new List<int>();

    var stack = new Stack<TreeNode>();

    var curr = A;

    while (curr != null)
    {
        stack.Push(curr);
        curr = curr.left;
    }

    while (stack.Count > 0)
    {
        curr = stack.Pop();
        result.Add(curr.val);

        if (curr.right != null)
        {
            curr = curr.right;
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
        }
    }

    return result;
}