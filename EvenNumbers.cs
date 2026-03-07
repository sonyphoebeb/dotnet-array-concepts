using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetArrays
{
    public class EvenNumbers
    {
        public void DisplayEvenNumbers()
        {
            Console.WriteLine("Enter start number:");
            int startNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end number:");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even numbers between " + startNumber + " and " + endNumber + " are: ");

            for (int i= startNumber; i<= endNumber; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
