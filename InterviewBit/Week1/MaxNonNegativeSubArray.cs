public List<int> maxset(List<int> A)
{
    var subArrays = new List<List<int>>();

    var start = 0;
    var end = 0;

    var currList = new List<int>();

    // Find all non-negative sub-arrays
    while (end < A.Count)
    {
        if (A[end] < 0)
        {
            if (end == A.Count - 1) // reached the end of the list
            {
                break;
            }
            start = end + 1;
            end = start;
            if (currList.Count > 0)
            {
                subArrays.Add(currList);
            }
            currList = new List<int>();
            continue;
        }
        currList.Add(A[end]);
        end++;
    }
    if (currList.Count > 0)
    {
        subArrays.Add(currList);
    }

    // Find the sub-array with the highest sum
    long maxSum = int.MinValue;
    var maxLength = int.MinValue;
    var minIndex = int.MaxValue;
    var result = new List<int>();

    foreach (var item in subArrays)
    {
        long sum = 0;
        foreach (var elem in item)
        {
            sum += elem;
        }

        if (sum > maxSum)
        {
            maxSum = sum;
            maxLength = item.Count;
            minIndex = item[0];
            result = item;
        }
        else if (sum == maxSum)
        {
            if (item.Count > maxLength)
            {
                result = item;
                maxLength = item.Count;
            }
            else if (item.Count == maxLength)
            {
                if (item[0] < minIndex)
                {
                    minIndex = item[0];
                    result = item;
                }
            }
        }
    }
    return result;
}