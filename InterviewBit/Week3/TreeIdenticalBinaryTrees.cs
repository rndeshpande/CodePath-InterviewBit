public int isSameTree(TreeNode A, TreeNode B)
{
	if (A == null && B == null)
	{
		return 1;
	}

	var valA = A != null ? A.val : int.MinValue;
	var valB = B != null ? B.val : int.MinValue;

	if (valA != valB)
	{
		return 0;
	}

	var leftSame = isSameTree(A.left, B.left) == 1;
	var rightSame = isSameTree(A.right, B.right) == 1;

	return leftSame && rightSame ? 1 : 0;

}