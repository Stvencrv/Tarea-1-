using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class ProductoAt
    {
            public string Nombre { get; set; }

            public double Precio { get; set; }

            public ProductoAt(string nombreproducto, double precio)
            {
                this.Nombre = nombreproducto;
                this.Precio = precio;

            }

        }
    }
  
