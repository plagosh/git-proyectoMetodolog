using System;
using System.IO;
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
            string RutaBat = @"C:\Users\Mauricio\Desktop\Repositorios\git-proyectoMetodolog\docbat\ftpconeccion.bat";
            string RutaArchivo = @"C:\Users\Mauricio\Desktop\Repositorios\git-proyectoMetodolog\docbat\respaldo-ftp.txt";
            string opciones = "Elija Opción a realizar:\n1.-Mostras tabla predeterminada de Access.\n2.-Generar archivo txt.\n3.-Generar coneccion a FTP.\n4.-Ejecutar todo.\n0.-Salir\n";
            string GetConnectionString(string dbName = "Ergosana.mdb") => $"Driver={{Microsoft Access Driver (*.mdb, *.accdb)}};Dbq=C:\\{dbName}";
            string QueryText(string table = "Doctors") => $"SELECT * FROM {table}";
            using (OdbcConnection db = new OdbcConnection(GetConnectionString()))
            {
                using (StreamWriter archivo = new StreamWriter(RutaArchivo))
                {
                    var queryText = QueryText();
                    var data = db.Query(queryText).ToList();
                    while (stop != 0)
                    {

                        string eleccion;
                        Console.Write(opciones);
                        eleccion = Console.ReadLine();
                        int opcion = Convert.ToInt32(eleccion);
                        if (opcion == 1)
                        {
                            Console.Write("Conectando a Access ...\n");
                            foreach (var item in data)
                            {
                                Console.WriteLine(item);

                            }
                        }
                        else if (opcion == 2)
                        {

                            {
                                foreach (var item in data)
                                {
                                    archivo.WriteLine(item);

                                }
                                Console.WriteLine("Archivo txt generado correctamente...");
                            }
                        }
                        else if (opcion == 3)
                        {
                            //Cambiar ruta segun destino de archivo.
                            System.Diagnostics.Process.Start(RutaBat);
                            stop = 0;
                            Console.Write("> Ejecutando .bat < ...\n");
                        }
                        else if (opcion == 4)
                        {
                            Console.Write("Conectando a Access ...\n");
                            foreach (var item in data)
                            {
                                Console.WriteLine(item);
                                archivo.WriteLine(item);
                            }
                            Console.WriteLine("Archivo txt generado correctamente...");
                            System.Diagnostics.Process.Start(RutaBat);
                            Console.Write("> Ejecutando .bat < ...\n");
                            stop = 0;
                        }

                        else
                        {
                            stop = 0;
                        }
                    }
                }
            }   
        }
    }
}