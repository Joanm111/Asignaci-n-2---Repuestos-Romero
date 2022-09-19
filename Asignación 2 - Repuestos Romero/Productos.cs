using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_2___Repuestos_Romero
{
    internal class Productos
    {

        public Productos(string name, int precio, int cantidad, int cargo)
        {
           this.Name = name;
            this.precio = precio;
            this.cantidad = cantidad;
            this.cargo = cargo;
        }

        public string Name { get; set; }

        public int precio { get; set; }

        public int cantidad { get; set; }

        public int cargo { get; set; }

    }
}
