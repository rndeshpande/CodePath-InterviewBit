public List<List<int>> permute(List<int> A) {
    var res = new List<List<int>>();

    permuteRec(res, A, 0);

    return res;
}

private void Swap(List<int> a, int i1, int i2)
{
    var t = a[i1];
    a[i1] = a[i2];
    a[i2] = t;
}

private void permuteRec(List<List<int>> res, List<int> a, int start)
{
    if (start == a.Count - 1)
    {
        var list = new List<int>();

        foreach (int ii in a)
            list.Add(ii);

        res.Add(list);
        return;
    }

    for (int i = start; i < a.Count; i++)
    {
        Swap(a, start, i);
        permuteRec(res, a, start + 1);
        Swap(a, start, i);
    }
}