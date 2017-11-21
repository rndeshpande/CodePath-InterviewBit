public int kthsmallest(List<int> A, int B)
{
    return kthsmallest(A, B, 0, A.Count - 1);
}

private int kthsmallest(List<int> A, int k, int left, int right)
{
    // If B is smaller than number of elements in array
    if (k > 0 && k <= right - left + 1)
    {
        int pos = partition(A, left, right);

        if (pos - left == k - 1)
            return A[pos];
        if (pos - left > k - 1)
            return kthsmallest(A, k, left, pos - 1);

        return kthsmallest(A, k - pos + left - 1, pos + 1, right);
    }

    return -1;
}

private int partition(List<int> A, int left, int right)
{
    var x = A[right];
    var i = left;

    for (int j = left; j <= right - 1; j++)
    {
        if (A[j] <= x)
        {
            swap(A, i, j);
            i++;
        }
    }
    swap(A, i, right);
    return i;
}

public void swap(List<int> A, int m, int n)
{
    var temp = A[m];
    A[m] = A[n];
    A[n] = temp;
}