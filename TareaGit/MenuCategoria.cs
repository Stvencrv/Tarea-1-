using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    class MenuCategoria
    {
        private MantCat mantenimiento { get; set; }


        public MenuCategoria()
        {
            mantenimiento = new MantCat();
        }

        public void imprimirmenu()
        {
            Imenu menu;
            Console.Clear();
            Console.WriteLine("---Menu Categoria--- \n1.Agregar categorias \n2.Editar Categoria \n3.Eliminar Categoria \n4.Listar categorias \n5.Volver atrás");
            int menus = Convert.ToInt32(Console.ReadLine());

            switch (menus)
            {
                case 1:
                    mantenimiento.agregarcategoria();
                    imprimirmenu();
                    break;
                case 2:
                    mantenimiento.editarcategoria();
                    imprimirmenu();
                    break;
                case 3:
                    mantenimiento.eliminarcategoria();
                    imprimirmenu();
                    break;
                case 4:
                    mantenimiento.listarcategorias();
                    imprimirmenu();
                    break;
                case 5:
                    menu =new MenuPrincipal();
                    menu.imprimirmenu();
                    break;
                default:
                    Console.WriteLine("Ingrese Una Opcion Valida");
                    break;
            }
        }
    }
}