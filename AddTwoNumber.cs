using System;

namespace LeetCode2
{
    public class ListNode
    {
        public int val;
        public ListNode next = null;

        // constructor
        public ListNode (int x) { val = x; }

        public void AddToLast(int val)
        {
            if (next == null) next = new ListNode(val);
            else next.AddToLast(val);
        }

        public void Print()
        {
            Console.Write(val + " -> ");
            if (next != null) next.Print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            l1.AddToLast(4);
            l1.AddToLast(3);

            ListNode l2 = new ListNode(5);
            l2.AddToLast(6);
            l2.AddToLast(4);

            ListNode answer = AddTwoNumbers(l1, l2);
            answer.Print();
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode helperNode = new ListNode(0);
            ListNode resultNode = helperNode;
            ListNode tempNode = null;

            bool firstNode = true;
            int carryOver = 0, div = 0, total = 0;
            int l1Val = 0, l2Val = 0;

            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    l1Val = l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2Val = l2.val;
                    l2 = l2.next;
                }

                total = l1Val + l2Val + carryOver;
                div = total / 10;
                total %= 10;

                if (firstNode) // replace first node value (0)
                {
                    helperNode.val = total;
                    tempNode = new ListNode(1) { };
                    firstNode = false;
                }
                else 
                {
                    tempNode = new ListNode(total);
                    helperNode.next = tempNode;
                    helperNode = helperNode.next;
                }

                carryOver = div;

                if (carryOver > 0 && l1 == null && l2 == null) // this is not adding up
                {

                    tempNode = new ListNode(carryOver);
                    helperNode.next = tempNode;
                    helperNode = helperNode.next;
                }

                l1Val = 0; l2Val = 0; // reset
            }
            return resultNode;
        }
    }
}
