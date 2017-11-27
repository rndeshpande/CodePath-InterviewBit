public int coverPoints(List<int> A, List<int> B)
{
	var numOfSteps = 0;

	for (var i = 1; i < A.Count; i++)
	{
		numOfSteps += Math.Max(Math.Abs(A[i] - A[i - 1]), Math.Abs(B[i] - B[i - 1]));
	}
	return numOfSteps;
}