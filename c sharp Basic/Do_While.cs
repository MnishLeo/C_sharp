using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic;

class Do_While
{
   static void Run()
    {
        string userChoice = string.Empty;
        do
        {
            Console.WriteLine("Please Enter your target");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTarget)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
            Console.WriteLine(); 

            do
            {
                Console.WriteLine("Do You Want to Continue - Yes or No?");
                userChoice = Console.ReadLine().ToUpper();
                if (userChoice != "YES" && userChoice != "NO")
                {
                    Console.WriteLine("Invalid Choice. Please say Yes or No");
                }
            } while (userChoice != "YES" && userChoice != "NO");

        } while (userChoice == "YES"); 
    }
}