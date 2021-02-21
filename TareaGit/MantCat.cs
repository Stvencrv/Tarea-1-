using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class MantCat
    {

        public void agregarcategoria()
        {
            Console.WriteLine("Escribe el nombre de la categoria");
            string nombrecategoria = Console.ReadLine();

            categoria nuevacategoria = new categoria(nombrecategoria);

            repositorio.Instancia.Listadecategorias.Add(nuevacategoria);

            Console.WriteLine("Se ha agregado la categoria");
            Console.ReadKey();


        }

        public void editarcategoria()
        {

            int editcatego;
            listarcategorias();
            Console.WriteLine("Selecione el producto a editar: ");
            editcatego = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar la nueva categoria: ");
            string nuevacategoria = Console.ReadLine();

            repositorio.Instancia.Litasdecategorias[editcatego - 1].Nombre = nuevacategoria;

            Console.WriteLine("La categoria ha logrado editarse....");
            Console.ReadKey();


        }

        public void eliminarcategoria()
        {
            listarcategorias();
            Console.WriteLine("Selecione la categoria que desea eliminar: ");
            int elimcategoria = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Si estas seguro que desea eliminar esa categoria. S/N?...");
            string opcion = Console.ReadLine();

            if (opcion == "S" || opcion == "s")
            {
                repositorio.Instancia.Litasdecategorias.RemoveAt(elimcategoria - 1);

                Console.WriteLine("La categoria se ha eliminado correctamente....");
                Console.ReadKey();

            }

        }



        public void listarcategorias()
        {
            for (int i = 0; i < repositorio.Instancia.Litasdecategorias.Count; i++)
            {
                categoria categoriainterada = repositorio.Instancia.Litasdecategorias[i];
                Console.WriteLine((i + 1 + " - " + categoriainterada.Nombre));
            }




        }
    }
}
