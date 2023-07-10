using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //allow to continue

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


            //***********************************



            //Even or Odd numbber

            /* Console.WriteLine("Please enter your number");
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
             Console.ReadKey();*/


            // ******************************************



            /* int number = 10;

             for (int i = 0; i <= number; i++) {

                 Console.WriteLine(i);
             }
             Console.ReadKey();  */



            //give your number and write sum of previous even number

            /* Console.WriteLine("Please enter your number and we will give you the sum of previous even numbers");

             int number = Convert.ToInt32(Console.ReadLine());

             int sum = 0;

             for(int i = 2; i < number; i += 2)
             {
                 sum = sum + i;

             }
             Console.WriteLine(sum);
             Console.ReadKey();  */


            // **********************************************




            // Data Structures: Arrayys


            /*string[] days = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
             Or
             string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
             Or
             string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };*/


            //************************************************


            //write week days

            /* string[] days = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

             int count = days.Length;

             for (int i = 0; i < days.Length; i++)
             {
                 Console.WriteLine(days[i]);

             }
             Console.ReadKey();*/


            int[] evenNumber = new int[10];

            for (int i = 0; i < 10; i++)
            {
                evenNumber[i] = i * 2;
            }

            for (int i = evenNumber.Length - 1; i >=0 ; i--)
            {
                Console.WriteLine(evenNumber[i]);
            }
            Console.ReadKey();







        


        }
    }
}
