using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            List<string> Fruta = new List<string>();
            Fruta.Add("1.Fresa");
            Fruta.Add("2.Uva");
            Fruta.Add("3.Kiwi");
            Fruta.Add("4.Naranja");
            Fruta.Add("5.Pera");
            int opcion;
            Console.WriteLine("===========MENU===========");
            Console.WriteLine("1)Agregar a la lista");
            Console.WriteLine("2)Mostrar lista");
            Console.WriteLine("3)Insertar en la lista");
            Console.WriteLine("4)Eliminar de la lista");
            Console.WriteLine("5)Buscar en la lista");
            Console.WriteLine("6)Vaciar lista");
            Console.WriteLine("7)Salir");
            Console.WriteLine("==========================");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                //Agregar 
                case 1:
                    string fruta;
                    Console.Clear();
                    Console.WriteLine("¿Que cantidad de fruta desea?");
                    int cant = Convert.ToInt32(Console.ReadLine());
                    int[] agregar = new int[cant];
                    for (int i = 0; i < agregar.Length; i++)
                    {
                        Console.Write("Fruta: ");
                        fruta = Console.ReadLine();
                        Fruta.Add(fruta);
                    }
                    Console.Clear();
                    foreach (string Fru in Fruta)
                    {
                        Console.WriteLine(Fru);
                    }
                    break;
                //Mostrar
                case 2:
                    Console.Clear();
                    foreach (string Fru in Fruta)
                    {
                        Console.WriteLine(Fru);
                    }
                    break;
                //Insertar
                case 3:
                    Console.Clear();
                    int N1;
                    string NEW;
                    Console.WriteLine("Cual es el numero del indice donde desea agregar su fruta");
                    N1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cual es la nueva fruta que desea agregar");
                    NEW = Console.ReadLine();
                    Fruta.Insert(N1, NEW);
                    Console.Clear();
                    foreach (string Fru in Fruta)
                    {
                        Console.WriteLine(Fru);
                    }
                    break;
                //Eliminar 
                case 4:
                    Console.Clear();
                    int N2;
                    Console.WriteLine("¿Cual es la cantidad de fruta que desea eliminar?");
                    N2 = Convert.ToInt32(Console.ReadLine());
                    Fruta.RemoveAt(N2);
                    Console.Clear();
                    foreach (string Fru in Fruta)
                    {
                        Console.WriteLine(Fru);
                    }
                    break;
                //Buscar 
                case 5:
                    Console.Clear();
                    string bucar;
                    Console.WriteLine("¿Que fruta bucar?");
                    bucar = Console.ReadLine();
                    do
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Se encontro la fruta dentro de la lista.");
                    } while ((Fruta.Contains(bucar)));
                    break;
                //Vaciar 
                case 6:
                    Console.Clear();
                    Fruta.Clear();
                    break;
                //Salir
                case 7:
                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir.");
                    break;
            }
            Console.ReadKey();
        }
    }
}