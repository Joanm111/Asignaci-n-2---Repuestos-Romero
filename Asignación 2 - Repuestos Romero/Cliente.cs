using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_2___Repuestos_Romero
{
    internal class Cliente
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Productos> ProductosList = new List<Productos>();


    }
}
