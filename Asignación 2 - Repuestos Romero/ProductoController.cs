using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignación_2___Repuestos_Romero
{
    internal class ProductoController:Cliente
    {

        
       

        public void addProducto(Productos productos)
        {
            if (productos != null)
            {
                ProductosList.Add(productos);
            }

        }

        public string showList()
        {
            
            var CantidadTotal = 0;
            var CargoTotal = 0;
            Console.WriteLine("Nombre" + "  precio  " + " cantidad " + " cargo  ");
            foreach (Productos productos in ProductosList)

            {
               
                Console.WriteLine($"{productos.Name}   {productos.precio}         {productos.cantidad}        {productos.cargo}");
                 CantidadTotal = CantidadTotal + productos.cantidad;
                CargoTotal = CargoTotal + productos.cargo;
            }
            Console.WriteLine("total"+"              "+CantidadTotal+ "        "+  CargoTotal);

            return "";
           


        }
    }
}
