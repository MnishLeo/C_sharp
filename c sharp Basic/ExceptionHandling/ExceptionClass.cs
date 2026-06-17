using System;

namespace c_sharp_Basic.ExceptionHandling
{
    internal class Program
    {
        static void run(string[] args)
        {
            try
            {
                int number = int.Parse("not a number");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid format!");
            }
            catch (Exception ex) // General catch
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Always runs");
            }
        }
    }
}