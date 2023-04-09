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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {

        ListNode resultHead = new ListNode(0);
        ListNode result = resultHead;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                result.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                result.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            result = result.next;
        }

        if (list1 == null)
            result.next = list2;
        else
            result.next = list1;

        return resultHead.next;
    }
}