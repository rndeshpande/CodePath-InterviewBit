public int longestConsecutive(List<int> A)
{
    var itemMap = new Dictionary<int, int>();
    var max = 1;

    foreach (var item in A)
    {
        if (!itemMap.ContainsKey(item))
        {
            itemMap.Add(item, 1);
        }
    }

    foreach (var item in A)
    {
        var prev = item - 1;
        var next = item + 1;
        var count = 1;

        while (itemMap.ContainsKey(prev))
        {
            count++;
            itemMap.Remove(prev);
            prev--;
        }
        while (itemMap.ContainsKey(next))
        {
            count++;
            itemMap.Remove(next);
            next++;
        }

        max = Math.Max(count, max);
    }

    return max;
}