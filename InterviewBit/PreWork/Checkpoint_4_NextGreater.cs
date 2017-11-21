public List<int> nextGreater(List<int> A)
{
    var stack = new Stack<int>();
    var result = new List<int>();

    for (var i = A.Count - 1; i >= 0; i--)
    {
        var next = A[i];

        if (stack.Count == 0)
        {
            stack.Push(next);
            result.Add(-1);
            continue;
        }

        if (next < stack.Peek())
        {
            result.Add(stack.Peek());
            stack.Push(next);
        }
        else
        {
            while (stack.Count > 0 && next >= stack.Peek())
            {
                stack.Pop();
            }

            result.Add(stack.Count > 0 ? stack.Peek() : -1);
            stack.Push(next);
        }

    }
    result.Reverse();
    return result;
}