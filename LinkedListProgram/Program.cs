﻿using System;
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
                    "Choose 10:To Stop Running Program");
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

                    case 10:
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
