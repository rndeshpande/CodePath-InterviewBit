public int books(List<int> A,  int B)
{
    return books(A, A.Count, B);
}

public int books(List<int> A, int length, int B)
{
    var sum = 0;

    if (length < B)
    {
        return -1;
    }

    // Total number of pages
    for (var i = 0; i < length; i++)
    {
        sum += A[i];
    }

    var start = 0;
    var end = sum;
    var result = int.MaxValue;

    while (start <= end)
    {
        var mid = (start + end) / 2;

        if (IsPossible(A, length, B, mid))
        {
            result = Math.Min(result, mid);
            end = mid - 1;
        }
        else
        {
            start = mid + 1;
        }
    }

    return result;
}

private Boolean IsPossible(List<int> A, int length, int B, int min)
{
    var studentsReq = 1;
    var currSum = 0;

    for (var i = 0; i < length; i++)
    {
        if (A[i] > min)
        {
            return false;
        }

        if (currSum + A[i] > min)
        {
            studentsReq++;
            currSum = A[i];
            if (studentsReq > B)
            {
                return false;
            }
        }
        else
        {
            currSum += A[i];
        }
    }

    return true;
}