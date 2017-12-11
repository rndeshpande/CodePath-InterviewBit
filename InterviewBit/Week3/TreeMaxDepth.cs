public int maxDepth(TreeNode A) {
	if (A == null)
	{
		return 0;
	}

	return 1 + Math.Max(maxDepth(A.left), maxDepth(A.right));
}