private ListNode deleteDuplicates(ListNode A)
{
    if (A == null || A.next == null)
    {
        return A;
    }

    var currNode = A;

    while (currNode != null)
    {
        if (currNode.next == null)
        {
            break;
        }
        if (currNode.val == currNode.next.val)
        {
            currNode.next = currNode.next.next != null ? currNode.next.next : null;
        }
        else
        {
            currNode = currNode.next;
        }
    }
    return A;
}