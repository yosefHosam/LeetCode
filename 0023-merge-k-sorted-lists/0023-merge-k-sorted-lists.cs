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
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

        while (true)
        {
            int minIndex = -1;
            int minVal = int.MaxValue;

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null && lists[i].val < minVal)
                {
                    minVal = lists[i].val;
                    minIndex = i;
                }
            }

            if (minIndex == -1)
                break;

            lists[minIndex] = lists[minIndex].next;

            curr.next = new ListNode(minVal);
            curr = curr.next;
        }

        return dummy.next;
    }
}