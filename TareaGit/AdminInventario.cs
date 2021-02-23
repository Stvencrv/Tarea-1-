using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class AdminInventario
    {
        public void VerProductoNombre()
        {
            for (int i =0; i< Repositorio.Instancia.Listarproductos.Count; i++)
            {
                ProductoAt ProductoAlistar = Repositorio.Instancia.Listarproductos[i];
                Console.WriteLine((i+1 + "-" + "Nombre" + ProductoAlistar.Nombre + ", cantidad:" + ProductoAlistar.cantidad));
            }
            Console.ReadKey();


        }

        public void Entradainventario()
        {
            VerProductoNombre();
            Console.WriteLine("Selecciona una opcion:");
            int al = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese una cantidad");
            int cantidadproducto2 = Convert.ToInt32(Console.ReadLine());

            int result = Repositorio.Instancia.Listarproductos[al - 1].cantidad + cantidadproducto2;
            Repositorio.Instancia.Listarproductos[al - 1].cantidad = result;
            Console.WriteLine("Se ha ingrasado la entrada del producto");
            Console.ReadKey();
        }

        public void Salidainventario()
        {
            VerProductoNombre();
            Console.WriteLine("Selecciona una opcion:");
            int al = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese una cantidad");
            int cantidadproducto2 = Convert.ToInt32(Console.ReadLine());

            int result = Repositorio.Instancia.Listarproductos[al - 1].cantidad + cantidadproducto2;
            Repositorio.Instancia.Listarproductos[al - 1].cantidad = result;
            Console.WriteLine("Se ha dado salida al producto");
            Console.ReadKey();

        }
    }
}
