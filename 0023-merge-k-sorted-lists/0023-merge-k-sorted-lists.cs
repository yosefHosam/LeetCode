/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();

        foreach (var list in lists)
        {
            if (list != null)
                minHeap.Enqueue(list, list.val);
        }

        ListNode dummyHead = new ListNode(0);
        ListNode curr = dummyHead;

        while (minHeap.Count > 0)
        {
            ListNode minNode = minHeap.Dequeue();
            curr.next = minNode;
            curr = curr.next;

            if (minNode.next != null)
                minHeap.Enqueue(minNode.next, minNode.next.val);
        }

        return dummyHead.next;
    }
}