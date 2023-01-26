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
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        if(head is null) return null;
        ListNode res = head, point = head;
        while(point!=null && point.next!=null)
        {
            res = res.next;
            point = point.next.next;
        }
        return res;
    }
}
