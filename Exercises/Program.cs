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
       
        public void Run()
        {
            
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.Write("Practice makes perfect! \n");
                Console.WriteLine("1.Ex A");
                Console.WriteLine("2.Ex B");
                Console.WriteLine("3.Ex C");
                Console.WriteLine("4.Ex D&E");
                Console.WriteLine("5.Ex F");

                Console.WriteLine("\n 0. Exit\n");
                Console.Write("Write exercise number: ");



                int input = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (input)
                {
                    case 0:
                        running = false;
                        break;

                    case 1:
                        
                        Console.WriteLine("Write first number: ");
                        int firstNumber1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Write second number: ");
                        int secondNumber1 = int.Parse(Console.ReadLine());

                        Console.Write("\nBigger number is: ");
                        int result1 = tools.BiggerTwoInt(firstNumber1, secondNumber1);
                        Console.WriteLine(result1);

                        Console.WriteLine("\nPress any key to get back to menu :) \n");
                        Console.ReadKey(true);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Write first number: ");
                        int firstNumber2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Write second number: ");
                        int secondNumber2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Write third number: ");
                        int thirdNumber2 = int.Parse(Console.ReadLine());

                        Console.Write("\nBigger number is: ");
                        int result2 = tools.BiggerThreeInt(firstNumber2, secondNumber2, thirdNumber2);
                        Console.WriteLine(result2);

                        Console.WriteLine("\nPress any key to get back to menu :) \n");
                        Console.ReadKey(true);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Write first letter: ");
                        char firstChar = char.Parse(Console.ReadLine());
                        Console.WriteLine("Write second letter: ");
                        char secondChar = char.Parse(Console.ReadLine());

                        Console.Write("\nBigger letter is: ");
                        char result3 = tools.BiggerTwoChar(firstChar, secondChar);
                        Console.WriteLine(result3);

                        Console.WriteLine("\nPress any key to get back to menu :) \n");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
