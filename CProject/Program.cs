using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProject
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Person Somebody = new Person("Karol", "Zyśk");
            Person Somebody2 = new Person("Paweł", "Zyśk", new DateTime(2000,05,18));

          
            Somebody.SetDateOfBirth(new DateTime(1990, 05, 18));
            DateTime dob = Somebody.GetDateOfBirth();
            Somebody.SayHi();
            Somebody2.SayHi();


        }

    }
}