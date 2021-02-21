using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
   
             class Repositorio
        {

            public static Repositorio Instancia { get; } = new Repositorio();
            public List<categoria> Litasdecategorias { get; set; } = new List<categoria>();
            public List<ProductoAt> Listarproductos { get; set; } = new List<ProductoAt>();

            private Repositorio()
            {


            }
        }
    }

