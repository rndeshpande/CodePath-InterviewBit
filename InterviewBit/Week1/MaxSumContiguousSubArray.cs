public int maxSubArray(List<int> A)
{
    var max = int.MinValue;
    var localMax = 0;

    foreach (var item in A)
    {
        localMax += item;

        max = Math.Max(localMax, max);
        localMax = localMax < 0 ? 0 : localMax;
    }

    return max;
}