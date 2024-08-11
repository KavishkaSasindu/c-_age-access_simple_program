using System;

namespace MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Console.Write("Enter your name :");
            // string name = Console.ReadLine();

            // Console.Write("Enter your age :");
            // int age = Convert.ToInt32(Console.ReadLine()); 

            // if(age>=18)
            // {
            //     Console.WriteLine("You can access the adminboard");
            // }
            // else{
            //     Console.WriteLine("No you can not access the admin board");
            // }

            // Console.Write("Enter your day number :");
            // int dayNumber = Convert.ToInt32(Console.ReadLine());    

            // switch(dayNumber)
            // {
            //     case 1:
            //         Console.WriteLine("Monday");
            //         break;
            //     case 2:
            //         Console.WriteLine("Tuesday");
            //         break ;
            //     default:
            //         Console.WriteLine("Enter valid number");
            //         break;
            // }

            Console.Write("Hello There enter your name :");
            string name = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Enter How many times do you need to say 'i love you ?");
            int looper = Convert.ToInt32(Console.ReadLine());


            if (looper == 0)
            {
                Console.WriteLine("Hell no didn't you love your partner?");
            }
            else
            {
                for (int i = 1; i <= looper; i++)
                {
                    Console.WriteLine("I love you {0}", name);
                }
            }




        }
    }
}