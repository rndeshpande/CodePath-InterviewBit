public int findMinXor(List<int> A)
{
	var min = int.MaxValue;
	A.Sort();

	var i = 0;
	while (i < A.Count - 1)
	{
		min = Math.Min(min, GetXor(A[i], A[i + 1]));
		i++;
	}

	return min;
}

private int GetXor(int A, int B)
{
	return A ^ B;
}