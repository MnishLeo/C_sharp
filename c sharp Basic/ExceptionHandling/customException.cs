using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_Basic.ExceptionHandling
{
    internal class customException
    { 
        public static void run()
        {
            try { 
            throw new UserAlreadyLoggedInException("User is already logged in.");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public class UserAlreadyLoggedInException : Exception
        {
            public UserAlreadyLoggedInException() : base() { }
            public UserAlreadyLoggedInException(string message) : base(message) { }
            public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException) { }   
        }
    }

}
