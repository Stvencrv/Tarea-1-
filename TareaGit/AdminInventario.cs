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




    }
}
