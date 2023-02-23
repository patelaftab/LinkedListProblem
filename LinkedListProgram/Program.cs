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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter An Option\n" +
                    "CHoose 1: For Creating Simple LinkedList\n"+
                    "Choose 2:To Stop Running");
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
