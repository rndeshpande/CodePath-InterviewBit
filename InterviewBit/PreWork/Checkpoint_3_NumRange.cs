public int numRange(List<int> A, int B, int C)
{
    var start = 0;
    var result = 0;

    while (start < A.Count)
    {
        var sum = A[start];

        if (sum > C)
        {
            start++;
            continue;
        }

        if (InRange(sum, B, C))
        {
            result++;
        }

        var end = start + 1;
        while (end < A.Count)
        {
            sum += A[end];
            if (InRange(sum, B, C))
            {
                result++;
            }
            if (sum > C)
            {
                break;
            }
            end++;
        }
        start++;

    }
    return result;
}

private bool InRange(int value, int start, int end)
{
    return value >= start && value <= end;
}