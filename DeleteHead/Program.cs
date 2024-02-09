using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteHead
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode DeleteHead(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            head = head.next;
            return head;
        }
    }
}
