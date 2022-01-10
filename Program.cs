using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Estrutura_If___
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //here we are setting a point in the code which we wish to comeback
            

            Console.WriteLine("Type in your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Type in your first grade: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Type in your second grade: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Type in your third grade: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Type in your fourth grade: ");
            double n4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            //here we are recording the values typed by the user in each variable

            double mf = (n1 * 0.2) + (n2 * 0.2) + (n3 * 0.3) + (n4 * 0.3);
            //here we are calculating the weighted average of each grade


            Console.WriteLine("");
            //we use a blank console.WriteLine to skip a line
            Console.WriteLine("Your final grade is: " + mf);
            Console.WriteLine("");

            if (mf >= 6)
            
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The student " + name + " was aproved!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //here we are declaring that IF the final grade is EQUAL or BIGGER than six (6) the student was aproved
            else if (mf <= 5 && mf >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The student " + name + " needs to do a retake test!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            ////here we are declaring that IF the final grade is EQUAL or SMALLER than five (5) AND (&&) EQUAL or BIGGER than three (3) the student needs to do a retake test
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The student " + name + " was not aproved!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //here we declared that IF the final grade does not meet any of the other criterias the student is not aproved

            Console.ReadKey();
            Console.Clear();
            goto start;
            //here we go back to the point we set before and execute everything up to that point (Line 14)
            //this makes the code reset
        }
    }
}
