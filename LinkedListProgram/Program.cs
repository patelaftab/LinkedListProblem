using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter An Option\n" +
                    "Choose 1: For Creating Simple LinkedList\n" +
                    "Choose 2:For Adding First Element\n" +
                    "Choose 3:For Creating Linkedist By Append\n" +
                    "Choose 4:To Insert Between Nodes\n" +
                    "Choose 5:To Delete First Element\n" +
                    "Choose 6:To Delete Last Element\n" +
                    "Choose 7: To Search Element\n" +
                    "Choose 8: To Check The Counts\n" +
                    "Choose 9: TO Perform Stack Push Operation\n" +
                    "Choose 10: To Perform Pop operation \n"+
                    "Choose 11:To perform Enqueue operation in Queue\n"+
                    "Choose 12:To Stop Running Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        break;
                    case 2:
                        linkedList.AddFirst(70);
                        linkedList.AddFirst(30);
                        linkedList.AddFirst(56);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Append(56);
                        linkedList.Append(30);
                        linkedList.Append(70);
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.AddFirst(56);
                        linkedList.Add(70);
                        linkedList.InsertBetween(56, 30, 70);
                        linkedList.Display();
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirst();
                        linkedList.Display();
                        break;
                    case 6:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLast();
                        linkedList.Display();
                        break;
                    case 7:
                        linkedList.SearchElement(56);
                        linkedList.SearchElement(30);
                        linkedList.SearchElement(70);
                        linkedList.SearchElement(30);
                        linkedList.Display();
                        break;
                    case 8:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Add(30);
                        linkedList.Size();
                        break;
                    case 9:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Display();
                        break;
                    case 10:
                        stack.Pop();
                        stack.Display();
                        break;
                    case 11:
                        queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        queue.Display();
                        break;
                    case 12:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
