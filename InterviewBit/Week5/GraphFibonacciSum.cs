class Solution {
    public int fibsum(int A) {
        List<int> fib = GetFibs(A);
        int fi = fib.Count - 1;
        int result = 0;
        while (A > 0) {
            if (fib[fi] <= A) {
                A -= fib[fi];
                fi--;
                result++;
            } else {
                fi--;
            }
        }
        return result;
    }

    public List<int> GetFibs(int a) {
        List<int> result = new List<int>();
        int cur = 0;
        int next = 1;
        while (next <= a) {
            int tmp = cur + next;
            result.Add(tmp);
            cur = next;
            next = tmp;
        }
        return result;
    }
}
