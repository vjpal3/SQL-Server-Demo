﻿using System;
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

            //List<Person> people = FileAccess.ReadFileData(@"e:\Vrishali\people.txt");
            new DataAccess().InsertPerson();
        }
    }
}
