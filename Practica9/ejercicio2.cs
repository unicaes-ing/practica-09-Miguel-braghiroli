using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class Ejercicio2
    {
        public struct Alumnos
        {
            public string Carnet;
            public string Nombre;
            public string Carrera;
            private double CUM;
            public void setCUM(double cum)
            {
                if (cum >= 0)
                {
                    if (cum <= 10)
                    {
                        this.CUM = cum;
                    }
                }
            }
            public double getCUM()
            {
                return CUM;
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Alumnos> DatAlum = new Dictionary<string, Alumnos>();
            int Opcion;
            Console.WriteLine("===========MENU===========");
            Console.WriteLine("1)Agregar Alumno");
            Console.WriteLine("2)Mostrar Alumnos");
            Console.WriteLine("3)Eliminar Alumno");
            Console.WriteLine("4)Buscar Alumno");
            Console.WriteLine("6)Vaciar Diccionario");
            Console.WriteLine("7)Salir");
            Console.WriteLine("==========================");
            Opcion = Convert.ToInt32(Console.ReadLine());
            int Cant;
            switch (Opcion)
            {
                //Agregar 
                case 1:
                    Console.Clear();
                    Console.Write("Escriba la cantidad de alumnos que desea ingresar:");
                    Cant = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = 0; i < Cant; i++)
                    {
                        Alumnos A = new Alumnos();
                        Console.WriteLine("Alumno N°{0}", i + 1);
                        do
                        {
                            Console.Write("Escriba el carnet del alumno: ");
                            A.Carnet = Console.ReadLine();
                            if (DatAlum.ContainsKey(A.Carnet))
                            {
                                Console.WriteLine("El Carnet: {0} ya existe.", A.Carnet);
                            }
                        } while (DatAlum.ContainsKey(A.Carnet));
                        Console.Write("Favor ingrese el nombre del alumno: ");
                        A.Nombre = Console.ReadLine();
                        Console.Write("Favor ingrese la carrera que cursa el alumno: ");
                        A.Carrera = Console.ReadLine();
                        Console.WriteLine("Favor ingresar el CUM del alumno: ");
                        A.setCUM(Convert.ToDouble(Console.ReadLine()));
                        DatAlum.Add(A.Carnet, A);
                    }
                    break;
                //Mostrar 
                case 2:
                    Console.Clear();
                    foreach (KeyValuePair<string, Alumnos> Datos in DatAlum)
                    {
                        Console.WriteLine(Datos);
                    }
                    break;
                //Eliminar 
                case 3:
                    Console.Clear();
                    string e;
                    Console.WriteLine("Favor ingrese el numero de carnet del alumno que desea eliminar de la lista");
                    e = Console.ReadLine();
                    DatAlum.Remove(e);
                    foreach (KeyValuePair<string, Alumnos> Datos in DatAlum)
                    {
                        Console.WriteLine(Datos);
                    }
                    break;
                //Buscar
                case 4:
                    Console.Clear();
                    string o;
                    Console.WriteLine("¿Que alumno desea bucar?");
                    o = Console.ReadLine();
                    do
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("El alumno se encuentro con exito en la lista.");
                    } while ((DatAlum.ContainsKey(o)));
                    break;
                //Vaciar
                case 5:
                    Console.Clear();
                    DatAlum.Clear();
                    break;
                //Salir
                case 6:
                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir");
                    break;
            }
        }
    }
}
