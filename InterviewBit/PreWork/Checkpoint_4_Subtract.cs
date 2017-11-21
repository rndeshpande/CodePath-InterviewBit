public ListNode subtract(ListNode A)
{
    var length = 0;
    var temp = A;

    // Calculate length of the list
    while (temp != null)
    {
        length++;
        temp = temp.next;
    }

    var mid = length % 2 == 0 ? length / 2 : length / 2 + 1 ;


    var firstHalfTail = A;
    var i = 0;
    while (i < mid - 1)
    {
        firstHalfTail = firstHalfTail.next;
        i++;
    }

    // Split list from the middle
    var secondHalfHead = firstHalfTail.next;
    firstHalfTail.next = null;

    secondHalfHead = ReverseList(secondHalfHead);

    // Traverse first and second halves simultaneously
    var secondHalfNode = secondHalfHead;
    var firstHalfNode = A;
    while (secondHalfNode != null)
    {
        firstHalfNode.val = secondHalfNode.val - firstHalfNode.val;
        firstHalfNode = firstHalfNode.next;
        secondHalfNode = secondHalfNode.next;
    }

    secondHalfHead =  ReverseList(secondHalfHead);

    firstHalfTail.next = secondHalfHead;
    return A;
}

private ListNode ReverseList(ListNode head)
{
    ListNode prevNode = null;
    ListNode currNode = head;
    ListNode nextNode = null;

    while (currNode != null)
    {
        nextNode = currNode.next;
        currNode.next = prevNode;
        prevNode = currNode;
        currNode = nextNode;
    }

    return prevNode;
}