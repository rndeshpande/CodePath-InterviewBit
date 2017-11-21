public List<List<int>> permute(List<int> A)
{
    return permute(A, new Dictionary<string, int>(), string.Empty);
}
public List<List<int>> permute(List<int> A, IDictionary<string, int> memo, string keyPrefix)
{
    var length = A.Count;
    var result = new List<List<int>>();

    if (length == 1)
    {
        var key = keyPrefix + A[0];
        if (!memo.ContainsKey(key))
        {
            var list = new List<int>();
            list.Add(A[0]);
            result.Add(list);
            memo.Add(key, 1);
        }
        return result;
    }

    for (var i = 0; i < length; i++)
    {
        var firstElem = A[i];
        var lists = new List<List<int>>();
        var newList = new List<int>(A);
        newList.RemoveAt(i);
        lists.AddRange(permute(newList, memo, keyPrefix + firstElem));

        foreach (var list in lists)
        {
            list.Insert(0, firstElem);
        }

        result.AddRange(lists);
    }

    return result;
}