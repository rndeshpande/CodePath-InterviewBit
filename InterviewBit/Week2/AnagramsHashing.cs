public List<List<int>> anagrams(List<string> A)
{

    var result = new List<List<int>>();
    var map = new Dictionary<string, List<int>>();
    for (var i = 0; i < A.Count; i++)
    {
        var valueArr = A[i].ToCharArray();
        Array.Sort(valueArr);
        var key = new String(valueArr);

        if (map.ContainsKey(key))
        {
            map[key].Add(i + 1);
        }
        else
        {
            map.Add(key, new List<int>() { i + 1 });
        }
    }

    foreach (var item in map)
    {
        result.Add(item.Value);
    }

    return result;
}