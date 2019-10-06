using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            new DataAccess().InsertPerson();

            List<Person> people = new DataAccess().GetAllPeople();
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}
