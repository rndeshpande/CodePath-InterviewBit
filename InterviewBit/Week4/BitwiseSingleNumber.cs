public int singleNumber(List<int> A)
{
    var i = 1;
    var result = A[0];
    while (i < A.Count )
    {
        result = result ^ A[i];
        i++;
    }
    return result;
}