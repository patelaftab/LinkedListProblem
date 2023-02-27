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
