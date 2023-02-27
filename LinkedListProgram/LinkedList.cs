using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                this.head = newNode;
            }
            else
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} New node Added :", newNode.data);
        }
        public void Append(int data)
        {
            Add(data);
        }
        public void InsertBetween(int insertFirst,int data,int insertLast)
        {
            Node newNode = new Node(data);
            Node temp = head;
            if(temp==null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            else
            {
                    if(temp.data==insertFirst&&temp.next.data==insertLast)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        Console.WriteLine("{0} IS Inserted Between :",newNode.data);
                    }
                    temp = temp.next;
            }
        }
        public void RemoveFirst()
        {
            if(head==null)
            {
                Console.WriteLine(  "Linkedlist Is Empty");
            }
            this.head=this.head.next;
            Console.WriteLine("First Element Is Removed");
        }
        public void RemoveLast()
        {
            if(head==null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            if(head.next==null)
            {
                head = null;
            }
            else
            {
                Node lastNode = this.head;
                while(lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = null;
                Console.WriteLine("The Last Element IS removed");
            }
        }

        public void SearchElement(int data)
        {
            bool flag = false;
            if (head != null)
            {
                int count = 0;
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        flag = true;
                        count++;
                    }
                    temp = temp.next;
                }
                if (flag)
                {
                    Console.WriteLine("Value {0} Is Present {0} Times", count);
                }
            }
        }
        public void Size()
        {
            Node temp = head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linked List IS enpty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("The Item is Prenst {0} Times", count);
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
