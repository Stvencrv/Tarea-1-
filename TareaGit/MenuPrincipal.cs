using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
     class MenuPrincipal : Imenu
    {

      public void imprimirmenu()
        {



            Console.Clear();
            Console.WriteLine("\n---Menu Principal--- \n1.Mantenimiento de categorias \n2.Mantenimiento de productos \n3.Entrada de inventario \n4.Salida de inventario \n5.Salir ");
            int menuxl = Convert.ToInt32(Console.ReadLine());

            switch(menuxl)
            {

                case 1:
                    MenuCategoria menuxll = new MenuCategoria();
                    menuxll.imprimirmenu();
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
