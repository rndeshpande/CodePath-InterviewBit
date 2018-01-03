public List<string> letterCombinations(string A)
{
    var map = new Dictionary<char, List<string>>();
    map.Add('0', new List<string> { "0" });
    map.Add('1', new List<string> { "1" });
    map.Add('2', new List<string> { "a", "b", "c" });
    map.Add('3', new List<string> { "d", "e", "f" });
    map.Add('4', new List<string> { "g", "h", "i" });
    map.Add('5', new List<string> { "j", "k", "l" });
    map.Add('6', new List<string> { "m", "n", "o" });
    map.Add('7', new List<string> { "p", "q", "r", "s" });
    map.Add('8', new List<string> { "t", "u", "v" });
    map.Add('9', new List<string> { "w", "x", "y", "z" });
    return letterCombinations(A, 0, map);
}

private List<string> letterCombinations(string A, int start, Dictionary<char, List<string>> map)
{
    var result = new List<string>();

    // Base case
    if (String.IsNullOrEmpty(A))
    {
        return result;
    }
    var length = A.Length - start;
    if (length == 0)
    {
        return result;
    }

    if (length == 1)
    {
        var items = map[A[start]];

        foreach (var item in items)
        {
            result.Add(item);
        }
        return result;
    }

    var combinations = letterCombinations(A, start + 1, map);
    var chars = map[A[start]];

    foreach (var c in chars)
    {
        foreach (var item in combinations)
        {
            result.Add(c + item);
        }
    }

    return result;
}