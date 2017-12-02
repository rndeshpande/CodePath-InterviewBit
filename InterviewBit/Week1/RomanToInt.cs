public int romanToInt(string A)
{
    var valueMap = new Dictionary<char, int>();
    valueMap.Add('I', 1);
    valueMap.Add('V', 5);
    valueMap.Add('X', 10);
    valueMap.Add('L', 50);
    valueMap.Add('C', 100);
    valueMap.Add('D', 500);
    valueMap.Add('M', 1000);

    var asscMap = new Dictionary<char, char>();
    asscMap.Add('V', 'I');
    asscMap.Add('X', 'I');
    asscMap.Add('L', 'X');
    asscMap.Add('C', 'X');
    asscMap.Add('D', 'C');
    asscMap.Add('M', 'C');

    var result = 0;

    for (var i = 0; i < A.Length; i++)
    {
        if (A[i] == 'I')
        {
            result++;
            continue;
        }

        if (i > 0 && A[i - 1] == asscMap[A[i]])
        {
            result -= 2 * valueMap[A[i - 1]];
        }

        result += valueMap[A[i]];
    }

    return result;
}