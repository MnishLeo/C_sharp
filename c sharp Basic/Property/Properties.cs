using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace c_sharp_Basic.Property
{
    public class Student
    {
        private string name;
        private int id;

        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be null or empty");
                return;
            }

            this.name = name;
        }
        public string getName()
        {
            return string.IsNullOrEmpty(this.name) ? "Name not set" : this.name;
        }

        public void setId(int id)
        {
            if (id <= 0)
            {
                Console.WriteLine("Id must be greater than 0");
                return;
            }
            this.id = id;
        }

        public int getId()
        {

            Console.WriteLine("Id is: " + this.id);
            return this.id;
        }
    }

        public class Properties
        {
            public static void run(string[] args)
            {
                Student s = new Student();
                s.setName(null);
                s.setId(1);
                s.getName();    
                s.getId();  
                s.setName("John Doe");  
                s.getName(); 
                s.setId(-5);
                s.getId();  
        }
        }
    }
