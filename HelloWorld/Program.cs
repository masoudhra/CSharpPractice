using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Please insert your age ");
             string input =  Console.ReadLine();
             int age = Convert.ToInt32(input);

             if(age < 18)
             {
                 Console.WriteLine("you are not allowed to continue!");
             }
             else
             {
                 Console.WriteLine("Wellcome to capadocia!");
             }
             Console.ReadKey();*/

            Console.WriteLine("Please enter your number");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if(number %2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            Console.ReadKey();
          


            

        }
    }
}
