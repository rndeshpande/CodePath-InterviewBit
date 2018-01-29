class Solution {

    /*
        1. Do a DFS,
        2. On seeing an X...start a shape...close the shape on next
    */

    public int black(List<string> A) {
        var rows = A.Count;
        var cols = A[0].ToCharArray().Length;
        var graph = new string[rows, cols];

        // Prepare the graph from the input
        for (var i = 0; i < A.Count; i++)
        {
            var row = A[i].ToCharArray();
            for (var j = 0; j < cols; j++)
            {
                graph[i, j] = row[j].ToString();
            }
        }
        var visited = new int[rows, cols];
        var shapes = 0;

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (visited[i, j] == 0)
                {
                    //visited[i, j] = 1;
                    if (graph[i, j] == "X")
                    {
                        shapes++;
                        dfs(graph, rows, cols, i, j, visited);
                    }
                }
            }
        }

        return shapes;

    }

    public void dfs (string[,] graph, int rows, int cols, int row, int col, int[,] visited)
    {
        if (row < 0 || col < 0 || row >= rows || col >= cols || visited[row, col] == 1)
        {
            return;
        }
        visited[row, col] = 1;

        if (graph[row, col] == "O")
        {
            return;
        }

        dfs(graph, rows, cols, row - 1, col, visited);
        dfs(graph, rows, cols, row + 1, col, visited);
        dfs(graph, rows, cols, row, col - 1, visited);
        dfs(graph, rows, cols, row, col + 1, visited);
    }
}
