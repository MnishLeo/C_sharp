using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic.ExceptionHandling
{
    internal class Exception2
    {
        public static void run(string[] args)
        {
            try
            {
                StreamReader streamReader = new StreamReader("nonexistentfile.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O error: {ex.Message}");
            }
            catch (Exception ex) // General catch
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}
