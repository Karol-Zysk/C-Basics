using System;
using ClassLibrary1;
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
            Person Somebody3 = new Person("Kaja", "Zyśk", new DateTime(2020, 05, 18));
            Person Somebody4 = new Person("Ania", "Zyśk", new DateTime(1996, 05, 18));


            Somebody.SetDateOfBirth(new DateTime(1990, 05, 18));
            DateTime dob = Somebody.GetDateOfBirth();
            Somebody.SayHi();
            Somebody2.SayHi();
            Somebody3.SayHi();
            Somebody4.SayHi();
            Console.WriteLine(Person.Count);

            
            ExcelFile excel = new ExcelFile();

            excel.FileName = "wydatki";
            excel.GenerateReport();


        }

    }
}