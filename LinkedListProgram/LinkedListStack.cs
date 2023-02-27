using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedListStack
    {
        public Node top;
        LinkedList linkedList = new LinkedList();
        public LinkedListStack()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine(data);
            //linkedList.Add(data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("value poped is " + this.top.data);
            this.top = this.top.next;
            //linkedList.RemoveLastNode();
        }

        public void Display()
        {
            Node temp = this.top;
            Console.Write("stack is ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
            //linkedList.Display();
        }
    }
}

