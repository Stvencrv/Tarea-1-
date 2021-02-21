using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class MenuProducto : Imenu
    {
        private MantProduc mantenimiento { get; set; }

        public MenuProducto()
        {
            mantenimiento = new MantProduc();
        }

        public void imprimirmenu()
        {
            iMenu menu;
            Console.Clear();
            Console.WriteLine("---Menu Producto--- \n1.Agregar Producto \n2.Editar Producto \n3.Eliminar Producto \n4.Listar Producto \n5.Volver atrás");
            int menu2 = Convert.ToInt32(Console.ReadLine());

            switch (menu2)
            {

                case 1:
                    
                    break;
                case 2:
                  
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                 
                    break;
                default:
                    break;
            }
        }
    }
}
