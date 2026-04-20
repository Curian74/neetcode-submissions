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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;

        // 1. Find middle
        var slow = head;
        var fast = head;

        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2. Reverse second half
        var second = slow.next;
        slow.next = null;

        ListNode prev = null;
        while (second != null) {
            var next = second.next;
            second.next = prev;
            prev = second;
            second = next;
        }

        var l1 = head;
        var l2 = prev;

        // 3. Merge 2 list
        while (l2 != null) {
            var n1 = l1.next;
            var n2 = l2.next;

            l1.next = l2;
            l2.next = n1;

            l1 = n1;
            l2 = n2;
        }
    }
}
