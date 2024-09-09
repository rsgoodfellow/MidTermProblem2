using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProblem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalBill = 0; //declares and initializes variable
            double surcharge = 50; //declares and initializes variable
            double first100 = 0; //declares and initializes variable
            double second200 = 0; //declares and initializes variable
            double third300 = 0; //declares and initializes variable
            double remainder = 0; //declares and initializes variable
            int units500 = 0; //declares and initializes variable
            int units300 = 0; //declares and initializes variable
            int units200 = 0; //declares and initializes variable
            int units100 = 0; //declares and initializes variable
            Console.Write("Please enter the number of units: "); //displays text asking for user input
            int units = Convert.ToInt32(Console.ReadLine()); //converts user input into a variable

            if (units > 500) //if statement to determine if units is greater than 500
            {
                units500 = units - 500; //calculates the number of units
                remainder = units500 * 1.5; //calculates cost per unit

            }
            else if (units > 300) //if statement to determine if units is greater than 300
            {
                    units300 = units - units500 - 300; //calculates the number of units
                    third300 = units300 * 1.2; //calculates cost per unit
                    if (units > 200) //if statement to determine if units is greater than 200
                    {
                        units200 = units - units500 - units300 - 100;  //calculates the number of units
                        second200 = units200 * 0.75; //calculates cost per unit
                        if (units > 0) //if statement to determine if units is greater than 0
                            {
                                units100 = units - units500 - units300 - units200 ;  //calculates the number of units
                                first100 = units100 * 0.5; //calculates cost per unit
                             }
                        }
                    }

                

            
                

            totalBill = surcharge + first100 + second200 + third300 + remainder;

            Console.WriteLine("the total bill is: " +  totalBill);

            Console.Read();

        }
    }
}
