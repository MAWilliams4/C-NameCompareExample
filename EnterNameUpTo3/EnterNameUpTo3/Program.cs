using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 This program asks the user to enter a name. If the name matches a given desired name, 
 then a welcome message is displayed and upon a new keystroke, the program closes. 
 If the name does not match, the use is prompted again to enter a name. On the third 
 time a wrong name is entered, the program will close.
 */

namespace EnterNameUpTo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            string desiredName = "Melissa Williams";  

            for(int i = 1; i < 4; i ++)
            {
                if ( Console.ReadLine() == desiredName )
                {
                    Console.WriteLine("\nWelcome, " + desiredName + ".");
                    Console.WriteLine("See you later!");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine("\nThree strikes and you're out.");
                }
                else
                {
                    Console.WriteLine("\nThat's not the name I was looking for! Try again.");
                    Console.Write("Please Enter Your Name: ");
                }
                
            }
                Console.ReadKey();
        }
    }
}
