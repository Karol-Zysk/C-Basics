using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProject
{
    internal class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;
        public static int Count = 0;

        public string ContactNumber { get; set; }

        public Person(string firstName, string lastName) {
            Count++;
            FirstName = firstName;
            LastName = lastName;

        }
        public Person(string firstName, string lastName, DateTime dateOfBirth) : this(firstName, lastName) 
        {
            
            SetDateOfBirth(dateOfBirth);

        }

        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid dob");
            }
            else
            {
                dateOfBirth = date;
            }
        }
        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi  ()
        {
            
            Console.WriteLine($"My name is {FirstName}, my latname is {LastName} and dob is {dateOfBirth} and Count = {Count}");
        }
        
    }
}
