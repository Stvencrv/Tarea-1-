using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class MantProduc
    {


        MantCat mantcat2 = new MantCat();
        public void agregarproducto()
        {

            Console.WriteLine("Escriba el nombre del producto: ");
            string nombreproducto = Console.ReadLine();

            Console.WriteLine("introduce el precio del producto: ");
            Double precioproducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introduce la cantidad ");
            int cantproducto = Convert.ToInt32(Console.ReadLine());



            if (Repositorio.Instancia.Litasdecategorias.Count != 0)
            {

                mantcat2.listarcategorias();

                Console.WriteLine("Selecciona la categoria a agregar el producto");
                int an = Convert.ToInt32(Console.ReadLine());

                string categoriproduct = Repositorio.Instancia.Litasdecategorias[an - 1].Nombre;

                ProductoAt Nuevoproducto = new ProductoAt(nombreproducto, precioproducto, cantproducto, categoriproduct);
                Repositorio.Instancia.Listarproductos.Add(Nuevoproducto);


                Console.WriteLine("La categoria se ha agregado correctamente");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("La categoria se ha agregado correctamente");
                Console.ReadKey();

            }



        }

        public void editproducto()
        {

            int editproducto;
            listproducto();
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

        public void eliminarproducto()
        {
           listproducto();
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

        public void listproducto()
        {
            for (int i = 0; i < Repositorio.Instancia.Listarproductos.Count; i++)
            {
                ProductoAt prodcutointerada = Repositorio.Instancia.Listarproductos[i];
                Console.WriteLine((i + 1 + " - " + prodcutointerada.Nombre + " " + prodcutointerada.Precio));
            }
        }

    }
}
