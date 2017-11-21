public static List<List<int>> prettyPrint(int A)
{
    var size = 2 * A - 1;
    var result = new int[size, size];
    var i = 0;
    var curr = A;
    var j = 0;

    while (i < size && j < size)
    {
        fillArray(result, i, size - i, i, size - i, curr - i);
        i++;
        j++;
    }

    return ConvertToList(result, size);
}

private static void fillArray(int[,] arr, int rowStart, int rowEnd, int colStart, int colEnd, int value)
{
    var i = rowStart;
    //Fill vertical row
    while (i < rowEnd)
    {
        arr[i, colStart] = value;
        arr[i, colEnd - 1] = value;
        i++;
    }

    i = colStart;
    while (i < colEnd)
    {
        arr[rowStart, i] = value;
        arr[rowEnd - 1, i] = value;
        i++;
    }
}

private static List<List<int>> ConvertToList(int[,] arr, int size)
{
    var result = new List<List<int>>();

    for (var m = 0; m < size; m++)
    {
        var temp = new List<int>();
        for (var n = 0; n < size; n++)
        {
            temp.Add(arr[m, n]);
        }
        result.Add(temp);
    }
    return result;
}