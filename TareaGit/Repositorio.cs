using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
   
    
        public class Repositorio
        {

            public static repositorio Instancia { get; } = new repositorio();
            public List<categoria> Litasdecategorias { get; set; } = new List<categoria>();
            public List<ProductoAt> Listarproductos { get; set; } = new List<ProductoAt>();

            private repositorio()
            {


            }
        }
    }

