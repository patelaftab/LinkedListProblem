using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Values Are Inserted",node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp == null) 
            {
                Console.WriteLine("Liked List Is Empty");
            }
            Console.WriteLine("Linked list IS :");
            while (temp != null)
            {
                Console.WriteLine(temp.data+"");
                temp = temp.next;
            }
        }
    }
}
