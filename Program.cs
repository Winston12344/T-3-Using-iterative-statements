// C# Program that converts CAD to US currency
using System;
class CAD_US
{
  
// Main steps
 public static void Main()
{

        //int variable for increament value for CAD in table
        int inc_value;

        // input inc_value between the range of 5 and 25
        while (true)
        {
            // input
            Console.Write("Enter value between 5 and 25 :");
            inc_value = Convert.ToInt32(Console.ReadLine());

        }

        // variable for CAD an USD

        double CAD = 0, USD;
        
        //heading labels for the table
        Console.WriteLine
        Console.WriteLine("------------");

            //do while loop
            do
            {
                // calculate USD into CAD
                // Formula for the calculation, multiply increament value of CAD by 0.786205 to obtain USD amount
                USD = CAD * 0.786205;
                //print
                Console.WriteLine(CAD + "     " + USD);

                // increament CAD by inc_value
                CAD += inc_value;
            }
            while (CAD <= 200);
        }
    }
} 
