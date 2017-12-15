public int isBalanced(TreeNode A)
{
	if (A == null)
	{
		return 1;
	}

	var leftHeight = GetHeight(A.left);
	var rightHeight = GetHeight(A.right);

	if (Math.Abs(leftHeight - rightHeight) <= 1
	        && isBalanced(A.left) > 0
	        && isBalanced(A.right) > 0 )
	{
		return 1;
	}
	return 0;
}

public int GetHeight (TreeNode node)
{
	if (node == null)
	{
		return 0;
	}
	return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
}