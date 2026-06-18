using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic.ExceptionHandling
{
    internal class ExceptionAbuse
    
    {
        public static void run()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int numerator;
                bool isNumeratorValid = int.TryParse(Console.ReadLine(), out numerator);
                if (isNumeratorValid)
                {
                    Console.WriteLine("Enter a denominator:");
                    int denominator;
                    bool isDenominatorValid = int.TryParse(Console.ReadLine(), out denominator);
                    if (isDenominatorValid && denominator != 0)
                    {
                        int Result = numerator / denominator;
                        Console.WriteLine($"Result: {Result}");
                    }
                    else
                    {
                        if (denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero.");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valid number between {0} && {1}", int.MinValue, int.MaxValue);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Numerator should be a valid number between {0} && {1}", int.MinValue, int.MaxValue);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            
        }
            }


}
