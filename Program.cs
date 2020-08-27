using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_PE3
{
    class Program
    {
        //The main function, taking 4 numbers from the user and displays the product
        static void Main(string[] args)
        {
            //The First number, taken as a string and changed into an integer
            Console.WriteLine("What is the first number?");
            string var1 = Console.ReadLine();
            int num1 = Convert.ToInt32(var1);

            //The Second number, taken as a string and changed into an integer
            Console.WriteLine("What is the second number?");
            string var2 = Console.ReadLine();
            int num2 = Convert.ToInt32(var2);

            //The Third number, taken as a string and changed into an integer
            Console.WriteLine("What is the third number?");
            string var3 = Console.ReadLine();
            int num3 = Convert.ToInt32(var3);

            //The Fourth number, taken as a string and changed into an integer
            Console.WriteLine("What is the fourth number?");
            string var4 = Console.ReadLine();
            //int num4 = Convert.ToInt32(var4);

            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
           

        }
    }
}
