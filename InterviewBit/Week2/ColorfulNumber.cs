public int colorful(int A)
{
    var productMap = new Dictionary<int, int>();

    var strA = A.ToString();
    for (var i = 0; i < strA.Length; i++)
    {
        for (var j = i; j < strA.Length; j++)
        {
            var subString = strA.Substring(i, strA.Length - j);
            var product = GetProduct(subString);
            if (productMap.ContainsKey(product))
            {
                return 0;
            }
            productMap.Add(product, 1);
        }

    }

    return 1;
}

private int GetProduct(string value)
{
    var product = 1;

    foreach (var item in value)
    {
        product *= int.Parse(item.ToString());
    }
    return product;
}