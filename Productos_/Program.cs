using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;

namespace Productos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Productos productos = new Productos();
            Console.WriteLine("¿El producto está en la sección de utensilios? ");
            Console.WriteLine("Sí es así ingrese ¨true¨ sí no ¨false¨");
            productos.seccion = Boolean.Parse(Console.ReadLine());

            if (productos.seccion == true)
            {
                Console.WriteLine("El producto es de la sección de utensilios");
                Console.WriteLine("¿Cuantos utensilio desea comprar?");
                int cantidadU = int.Parse(Console.ReadLine());
                Utensilio[] utensilio = new Utensilio[cantidadU];

                for (int i = 0; i < cantidadU; i++)
                {
                    Console.WriteLine($"Ingrese el nombre del utensilio {i + 1}:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"Ingrese el precio del utensilio {i + 1}:");
                    double precio = double.Parse(Console.ReadLine());
                    utensilio[i] = new Utensilio(nombre, precio);
                }

                Console.WriteLine("Listado de utensilios ingresados:");
                foreach (var utensilios in utensilio)
                {
                    Console.WriteLine($"Nombre: {utensilios.NombreU}, Precio: {utensilios.PrecioU}");
                }
            }
            else
            {
                Console.WriteLine("El producto es de la sección de Papeles");
                Console.WriteLine("¿Cuantos Papeles desea comprar?");
                int cantidadP = int.Parse(Console.ReadLine());
                Papeles[] papeles = new Papeles[cantidadP];

                for (int i = 0; i < cantidadP; i++)
                {
                    Console.WriteLine($"Ingrese el nombre del utensilio {i + 1}:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"Ingrese el precio del utensilio {i + 1}:");
                    double precio = double.Parse(Console.ReadLine());
                    papeles[i] = new Papeles(nombre, precio);
                }

                Console.WriteLine("Listado de Papeles ingresados:");
                foreach (var papel in papeles)
                {
                    Console.WriteLine($"Nombre: {papel.NombreP}, Precio: {papel.PrecioP}");
                }
            }
            Console.ReadKey();
        }
    }
}
