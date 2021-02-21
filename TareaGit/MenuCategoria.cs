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
            int menu1 = Convert.ToInt32(Console.ReadLine());

            switch (menu1)
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