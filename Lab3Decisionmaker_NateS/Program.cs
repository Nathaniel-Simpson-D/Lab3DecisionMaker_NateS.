using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Decisionmaker_NateS
{
    class Program
    {
        static void Main(string[] args)
        {
            //promt for name
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            //Prompt for num
            int userNum = 101;
            while (userNum > 100 || userNum < 1)
            {
                Console.WriteLine("Please enter a number between 1 and 100");
                string userIn = Console.ReadLine();
                try { userNum = int.Parse(userIn); }
                catch { userNum = 101; }

                if (userNum > 100 || userNum < 1)
                { Console.WriteLine($"Please enter a valid number"); }
                else
                { Console.WriteLine($"{userName}, you have chosen {userNum}."); }


            }

            //validate
            //Calc

            if (userNum % 2 != 0 && userNum > 60)
            { Console.WriteLine($"{userNum} Odd"); }
            else if (userNum % 2 == 0 && userNum >= 2 && userNum <= 25)
            { Console.WriteLine("Even and less than 25"); }
            else if (userNum % 2 == 0 && userNum >= 26 && userNum <= 60)
            { Console.WriteLine($"Even."); }
            else if (userNum % 2 == 0 && userNum > 60)
            { Console.WriteLine($"{userNum} Even."); }
            else { Console.WriteLine($"{userNum} Odd."); }
            //Output
            Console.WriteLine($"Have a good day {userName}.");
            Console.WriteLine($"(Press enter to exit)");
            Console.ReadLine();

        }
    }
}
