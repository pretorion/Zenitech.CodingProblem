using System;
using System.Collections;

namespace Zenitech.CodingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new DropOutStack(5);
            Console.WriteLine("CODING PROBLEM Calculiator");
            Console.WriteLine("Useage:");
            Console.WriteLine(" P key - Push");
            Console.WriteLine(" O key - Pop");
            Console.WriteLine(" A key - Add");
            Console.WriteLine(" S key - Sub");
            Console.WriteLine(" X key - Exit");
            while (true)
            {
                char KeyChar = Char.ToLower(Console.ReadKey(true).KeyChar);
                switch (KeyChar)
                {
                    case 'p':
                        Console.WriteLine("Push");
                        string inputString = Console.ReadLine();
                        if (Int32.TryParse(inputString, out int numValue))
                        {
                            if (KeyChar == 'p')
                            {
                                if(stack.Push((ushort)numValue) == null)
                                {
                                    Console.WriteLine("Stack full");
                                }
                            }
                        }
                        break;
                    case 'o':
                        Console.WriteLine("Pop value: {0}", stack.Pop());
                        break;
                    case 'a':
                        Console.WriteLine("Add");
                        stack.Add();
                        break;
                    case 's':
                        Console.WriteLine("Sub");
                        stack.Sub();
                        break;
                    case 'x':
                        return;
                    default:
                        break;
                }
                Console.WriteLine("Stack ( {0} )", stack.Print());
            }
        }
    }
}
