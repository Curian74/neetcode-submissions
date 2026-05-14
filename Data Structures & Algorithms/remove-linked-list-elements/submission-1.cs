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
    public ListNode RemoveElements(ListNode head, int val) {
        var cur = head;
        var dummy = new ListNode();
        var res = dummy;
        while (cur != null) {
            if (cur.val != val) {
                dummy.next = cur;
                dummy = dummy.next;
            }
            else {
                dummy.next = null;
            }
            cur = cur.next;
        }
        return res.next;
    }
}