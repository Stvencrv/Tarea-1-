using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class ProductoAt
    {
        public class producto
        {

            public string Nombre { get; set; }

            public double Precio { get; set; }

            public producto(string nombreproducto, double precio)
            {
                this.Nombre = nombreproducto;
                this.Precio = precio;

            }

        }
}
