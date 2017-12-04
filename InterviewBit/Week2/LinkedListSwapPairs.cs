private ListNode swapPairs(ListNode A)
{
    if (A == null || A.next == null)
    {
        return A;
    }

    var prev = A;
    var curr = A.next;

    A = curr != null ? curr : A;

    while (true)
    {
        ListNode next = curr.next;
        curr.next = prev;

        if (next == null || next.next == null)
        {
            prev.next = next;
            break;
        }

        prev.next = next.next;

        prev = next;
        curr = prev.next;
    }

    return A;
}