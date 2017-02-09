using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        Tools tools = new Tools();
        private bool running = true;
        public void Run()
        {
            while(running)
            {
                Console.WriteLine("1.Ex A");
                Console.WriteLine("2.Ex B");
                Console.WriteLine("3.Ex C");
                Console.WriteLine("4.Ex D&E");
                Console.WriteLine("5.Ex F");

                Console.WriteLine("\n 0. Exit");

            }

            int input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 0: running = false;
                    break;

                case 1:

                    Console.WriteLine("Write first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());

                    int result = tools.BiggerTwoInt(firstNumber, secondNumber);
                    Console.WriteLine(result);
                    break;

                case 2:
                    Console.WriteLine("Write first number");
                    int first = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write second number");
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write third number");
                    int third = int.Parse(Console.ReadLine());

                    int result1 = tools.BiggerThreeInt(first, second, third);
                    Console.WriteLine(result1);
                    break;
            }
        }
    }
}
