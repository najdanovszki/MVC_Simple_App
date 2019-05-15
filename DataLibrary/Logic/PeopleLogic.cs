using DataLibrary.DataAccess;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class PeopleLogic
    {
        public static int CreatePaople(string firstName, string lastName, DateTime birthDate)
        {
            PeopleModel data = new PeopleModel
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };

            string sql = @"INSERT INTO People (FirstName, LastName, BirthDate)
                                        VALUES (@FirstName, @LastName, @BirthDate)";

            return SQLDataAccess.SaveData(sql, data);
        }
    }
}
