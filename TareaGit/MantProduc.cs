using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class MantProduc
    {

        public void agregarproducto()
        {

            Console.WriteLine("Escriba el nombre del producto: ");
            string nombreproducto = Console.ReadLine();

            Console.WriteLine("introduce el precio del producto: ");
            double precioproducto = Convert.ToInt32(Console.ReadLine());


            ProductoAt nuevoproducto = new ProductoAt(nombreproducto, precioproducto);

            Repositorio.Instancia.Listarproductos.Add(nuevoproducto);

            Console.WriteLine("La categoria se ha agregado correctamente");
            Console.ReadKey();
        }

        public void editproducto()
        {

            int editproducto;
            llistarproducto();
            Console.WriteLine("Selecione el producto a editar: ");
            editproducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba el nuevo producto: ");
            string nuevoproducto = Console.ReadLine();

            Console.WriteLine("Introduce el nuevo precio: ");
            double nuevoprecio = Convert.ToInt32(Console.ReadLine());

            Repositorio.Instancia.Listarproductos[editproducto - 1].Nombre = nuevoproducto;
            Repositorio.Instancia.Listarproductos[editproducto - 1].Precio = nuevoprecio;

            Console.WriteLine("El producto ha logrado editarse correctamente....");
            Console.ReadKey();
        }

        public void deleproducto()
        {
            llistarproducto();
            Console.WriteLine("Selecione el nombre del producto que desea eliminar: ");
            int elimproducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Si estas seguro que desea eliminar esa categoria. S/N?...");
            string opcion = Console.ReadLine();

            if (opcion == "S" || opcion == "s")
            {
                Repositorio.Instancia.Listarproductos.RemoveAt(elimproducto - 1);

                Console.WriteLine("La categoria se ha eliminado correctamente....");
                Console.ReadKey();

            }
        }

        public void llistarproducto()
        {
            for (int i = 0; i < Repositorio.Instancia.Listarproductos.Count; i++)
            {
                ProductoAt prodcutointerada = Repositorio.Instancia.Listarproductos[i];
                Console.WriteLine((i + 1 + " - " + prodcutointerada.Nombre + " " + prodcutointerada.Precio));
            }
        }

    }
}
