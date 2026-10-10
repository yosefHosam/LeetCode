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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int length = 0;
        ListNode curr = head;
        
        while (curr != null)
        {
            length++;
            curr = curr.next;
        }
        
        if (length == n)
            return head.next;

        int stepsToMove = length - n - 1;
        ListNode beforeTarget = head;

        while (stepsToMove > 0)
        {
            beforeTarget = beforeTarget.next;
            stepsToMove--;
        }
        beforeTarget.next = beforeTarget.next.next;
        
        return head;
    }
}