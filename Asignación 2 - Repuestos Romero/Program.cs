using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Asignación_2___Repuestos_Romero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.ID = 001;
            cliente.Name = "";
         
            Console.WriteLine("Nombre del cliente");
            cliente.Name = Console.ReadLine();

            Console.Clear();

           ProductoController Obj = new ProductoController();
            int opcion = 0;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("** menu principal **" +
                    "\n 1. Agregar Producto" +
                    "\n 2. Mostrar la lista " +
                    "\n 3. Salir" 
                    );

                var data = Console.ReadLine();
                if (data != null)
                {
                    opcion = int.Parse(data);
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Escriba el nombre del producto: ");
                        var inputNombre = Console.ReadLine();
                        Console.WriteLine("PRECIO: ");
                        var inputPrecio = Console.ReadLine();
                        Console.WriteLine("Cantidad: ");
                        var inputCantidad = Console.ReadLine();
                        var cargo = Int32.Parse(inputCantidad)* Int32.Parse(inputPrecio);
                        Console.Clear();

                        if (inputNombre != null && inputPrecio != null && inputCantidad != null && inputCantidad != null)
                        {
                            Obj.addProducto(new Productos(
                                inputNombre.ToString(),
                                int.Parse(inputPrecio),
                                int.Parse(inputCantidad),
                                cargo

                                )) ;
                        }

                        break;

                    case 2:
                        Console.WriteLine("ID: "+cliente.ID + "   Cliente:"+  cliente.Name);
                        Console.WriteLine(Obj.showList());
                        
                        break;


                    case 3:
                        opcion = 3;
                        break;
                    default:
                        Console.WriteLine("elige una opcion del menu");
                        break;
                }

            } while (opcion != 3);








        }
    }
}
