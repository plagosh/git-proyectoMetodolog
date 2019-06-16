using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.Odbc;

namespace newapp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (OdbcConnection db = new OdbcConnection(GetConnectionString()))
            {
                var queryText = QueryText();
                var data = db.Query(queryText).ToList();

                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
            }

            string GetConnectionString(string dbName = "Ergosana.mdb") => $"Driver={{Microsoft Access Driver (*.mdb, *.accdb)}};Dbq=C:\\{dbName}";
            string QueryText(string table = "Doctors") => $"SELECT * FROM {table}";
        }
    }
}