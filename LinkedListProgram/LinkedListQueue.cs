using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedListQueue
    {
        
        public Node tail;
        public Node head;

        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (tail == null)
                tail = head = node;
            else
            {
                node.next = tail;
                tail = node;
            }
            Console.WriteLine(data + "is Added to Queue");
        }
        public void Dequeue()
        {
            if (tail != null)
            {
                if (tail.next == null)
                    tail = null;
                else
                {
                    Node temp = tail;
                    while (temp.next.next != null)
                        temp = temp.next;
                    temp.next = null;
                    head = temp;
                }
            }
        }

        public void Display()
        {
            Node temp = tail;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
