using System;

namespace MyApp
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name :");
            string name = Console.ReadLine();

            Console.Write("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine()); 

            if(age>=18)
            {
                Console.WriteLine("You can access the adminboard");
            }
            else{
                Console.WriteLine("No you can not access the admin board");
            }

            Console.Write("Enter your day number :");
            int dayNumber = Convert.ToInt32(Console.ReadLine());    

            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break ;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
        }
    }
}