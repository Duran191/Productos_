using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Productos
    {
        public string Nombre { get; set; }
        public bool seccion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }


        public virtual void Imprimir()
        {
            Console.WriteLine($"Nombre{Nombre}");
            Console.WriteLine($"Precio{Precio}");
            Console.WriteLine($"Cantidad{Cantidad}");
        }
    }
    public class Papeles : Productos
    {
        public string Tipo { get; set; }
        public string Color { get; set; }
        public string NombreP { get; set; }
        public double PrecioP { get; set; }
        public Papeles(string nombreP, double precioP)
        {
            NombreP = nombreP;
            PrecioP = precioP;
        }
        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Tipo de Papel: {Tipo}");
            Console.WriteLine($"Color del Papel: {Color}");
        }


    }
    class Utensilio : Productos
    {
        public string Material { get; set; }

        public string NombreU { get; set; }
        public double PrecioU { get; set; }

        public Utensilio(string nombreU, double precioU)
        {
            NombreU = nombreU;
            PrecioU = precioU;
        }
        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Material: {Material}");
        }


    }
}
