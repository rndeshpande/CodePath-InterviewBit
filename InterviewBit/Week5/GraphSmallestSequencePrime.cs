class Solution {
    public List<int> solve(int A, int B, int C, int D)
    {
        List<int> ans = new List<int>();
        SortedList<int, int> list = new SortedList<int, int>();
        list[A] = A;
        list[B] = B;
        list[C] = C;

        while (ans.Count < D)
        {
            int num = list.ElementAt(0).Key;
            ans.Add(num);
            list.RemoveAt(0);
            list[num * A] = num * A;
            list[num * B] = num * B;
            list[num * C] = num * C;
        }
        return ans;
    }
}
