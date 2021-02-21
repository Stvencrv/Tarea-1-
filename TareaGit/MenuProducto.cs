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
            Imenu menu; 
            Console.Clear();
            Console.WriteLine("---Menu Producto--- \n1.Agregar Producto \n2.Editar Producto \n3.Eliminar Producto \n4.Listar Producto \n5.Volver atrás");
            int menu2 = Convert.ToInt32(Console.ReadLine());

            switch (menu2)
            {

                case 1:
                    mantenimiento.agregarproducto();
                    imprimirmenu();
                    break;
                case 2:
                    mantenimiento.editproducto();
                    imprimirmenu();
                    break;
                case 3:
                    mantenimiento.eliminarproducto();
                    imprimirmenu();
                    break;
                case 4:
                    mantenimiento.listproducto();
                    imprimirmenu();
                    break;
                case 5:
                    menu = new MenuPrincipal();
                    menu.imprimirmenu();
                    break;
                default:
                    break;
            }
        }
    }
}
