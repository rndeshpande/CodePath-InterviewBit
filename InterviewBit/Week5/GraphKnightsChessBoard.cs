class Solution {
    public int knight(int N, int M, int x1, int y1, int x2, int y2) {
        Func<int, int, bool> valid = (x, y) => x >= 0 && x < N && y >= 0 && y < M;
        if (!valid(--x1, --y1) || !valid(--x2, --y2)) return -1;
        if (x1 == x2 && y1 == y2) return 0;
        int[][] diffs = {
            new int[] { -2, -1}, new int[] { -2, 1}, new int[] { -1, -2}, new int[] { -1, 2},
            new int[] {1, -2}, new int[] {1, 2}, new int[] {2, -1}, new int[] {2, 1}
        };
        var enqueued = new bool[N][];
        for (int i = 0; i < enqueued.Length; i++) {
            enqueued[i] = new bool[M];
        }
        var queueX = new Queue<int>();
        var queueY = new Queue<int>();

        queueX.Enqueue(x1);
        queueY.Enqueue(y1);
        enqueued[x1][y1] = true;
        int step = 0;
        while (queueX.Count != 0) {
            // print(enqueued);
            int count = queueX.Count;
            step++;
            while (count-- > 0) {
                var x = queueX.Dequeue();
                var y = queueY.Dequeue();
                foreach (var diff in diffs) {
                    int x3 = x + diff[0];
                    int y3 = y + diff[1];
                    if (valid(x3, y3) && !enqueued[x3][y3]) {
                        if (x2 == x3 && y2 == y3) {
                            return step;
                        }
                        queueX.Enqueue(x3);
                        queueY.Enqueue(y3);
                        enqueued[x3][y3] = true;
                    }
                }
            }
        }
        return -1;
    }

    private void print(bool[][] board) {
        foreach (var row in board) {
            foreach (var cell in row) {
                Console.Write(cell ? 'X' : 'O');
            }
            Console.WriteLine();
        }
    }
}
