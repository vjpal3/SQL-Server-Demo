using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SqlDBDemo
{
    public class FileAccess
    {
        
        public static List<Person> ReadFileData(string fullpath)
        {
            var people = new List<Person>();
            string[] lines = File.ReadAllLines(fullpath);
            foreach (var line in lines)
            {
                var names = line.Split('\t');
                people.Add(new Person { FirstName = names[0], LastName = names[1] });
            }

            //foreach(var person in people)
            //{
            //    Console.WriteLine(person.FirstName + " " + person.LastName);
            //}

            return people;

        }
    }
}
