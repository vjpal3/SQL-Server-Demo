using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace SqlDBDemo
{
    public class DataAccess
    {
        public void InsertPerson()
        {
            List<Person> people = FileAccess.ReadFileData(@"e:\Vrishali\people.txt");
            

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionStrVal("SampleDB")))
            {
                connection.Execute("dbo.uspPeople_InsertPerson @FirstName, @LastName", people);
            }
        }

        public List<Person> GetAllPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionStrVal("SampleDB")))
            {
                return connection.Query<Person>("dbo.uspPeople_GetAll").ToList();
            }

        }

        public List<Person> GetAllPeopleByLastName(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionStrVal("SampleDB")))
            {
                return connection.Query<Person>("dbo.uspPeople_GetAllByLastName @LastName", new { LastName = lastName }).ToList();
               

            }

        }

    }
}
