/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int size1 = GetSize(l1);
        int size2 = GetSize(l2);
        
        ListNode big = size1 > size2 ? l1 : l2;
        ListNode small = size1 > size2 ? l2 : l1;
        
        int carry = 0;
        ListNode l3, head;
        l3 = head = null;
        ListNode temp = null;
        while(small != null)
        {
            int val = big.val + small.val + carry;
            carry = 0;
            if(val >= 10)
            {
                carry = val/10; 
                val -= carry * 10;
            }
                
            big = big.next;
            small = small.next;
            
            temp = new ListNode(val);
            if(l3 == null){
                head = l3 = temp;
            } 
            else{
                l3.next = temp;
                 l3 = l3.next;
            }
           
        }
        
        while(big != null || carry > 0)
        {
            int val = 0;
            if(big == null)
            {
                val = carry;
            }
            else
            {
                val = big.val + carry;
                big = big.next;
            }
            
            carry = 0;
            if(val >= 10)
                {
                    carry = val/10; 
                    val -= carry * 10;
                }
            
            temp = new ListNode(val);
            if(l3 == null){
                head = l3 = temp;
            } 
            else{
                l3.next = temp;
                l3 = l3.next;
            }
            
        }
        return head;
    }
     
     public int GetSize(ListNode l)   {
         int size = 0;
         while (l!=null)
         {
             l = l.next;
             size++;
         }
         return size;
    }
}
