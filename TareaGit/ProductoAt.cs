using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class ProductoAt
    {
            public string Nombre { get; set; }

            public double Precio { get; set; }
            
            public int cantidad { get; set; }
            
            public string categoria { get; set; }

            public ProductoAt(string nombreproducto, double precio , int cantidad , string categoria)
            {
                this.Nombre = nombreproducto;
                this.Precio = precio;
                this.cantidad = cantidad;
                this.categoria = categoria;
        }

        }
    }
  
