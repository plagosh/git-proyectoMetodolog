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
            int stop = 1;
            while (stop != 0)
            {
                string eleccion;
                Console.Write("Elija Opción a realizar:\n1.-Mostras tabla predeterminada de Access\n2.-Ejecutar Script FTP.\n0.-Salir\n");
                eleccion = Console.ReadLine();
                int opcion = Convert.ToInt32(eleccion);
                if(opcion == 0)
                {
                    Console.Write("Programa Terminado");
                    System.Environment.Exit(1);               
                }
                else if (opcion == 1)
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
                else if (opcion == 2)
                {
                    //Cambiar ruta segun destino de archivo.
                    System.Diagnostics.Process.Start(@"C:\Users\Mauricio\Desktop\Repositorios\git-proyectoMetodolog\docbat\ftpconeccion.bat");
                    Console.Write("> Ejecutando .bat < ...\n");
                    Console.ReadLine();
                }
            }
        }
    }
}