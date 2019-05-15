using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        public static string GetConnectionString(string connectionName = "MVCDb")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection con = new SqlConnection(GetConnectionString()))
            {
                return con.Execute(sql, data);
            }
        }
    }
}
