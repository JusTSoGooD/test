using System;

namespace TestGit_lesson2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string surname = string.Empty;
            int age = 0;
            int weight = 0;
            int response = 0;
            while (response != -1)
            {
                Console.WriteLine($"Print 0 to enter name.{Environment.NewLine}Print 1 to enter surname.{Environment.NewLine}Print 2 to enter age.{Environment.NewLine}Print -1 to quit terminal. 3 - enter weight");
                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 0:
                        {
                            Console.WriteLine("Enter your name");
                            name = Console.ReadLine();
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Enter your surname");
                            surname = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter your age");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter your weight");
                            weight = int.Parse(Console.ReadLine());
                            break;
                        }
                    case -1:
                        {
                            Console.WriteLine("You exited programm");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Хуйню написал давай по новой");
                            break;
                        }
                }
            }

            Console.WriteLine($"{name} {surname} : {age} years old, {weight} - weight");
            Console.ReadKey();
        }
    }
}

