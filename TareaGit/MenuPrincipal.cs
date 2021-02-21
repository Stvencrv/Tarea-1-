using System;
using System.Collections.Generic;
using System.Text;

namespace TareaGit
{
    public class MenuPrincipal
    {

        public void impMenu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1-Mantenimiento de materias\n2-Mantenimiento de estudiantes\n3-Inscripcion\n4-Salir");
                Console.Write("Seleccion una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Seleccion una opcion: ");
                        impMenu();
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Gracias por utilizar nuestro sistema");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida");
                        Console.ReadKey();
                        impMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe seleccionar una opcion valida");
                Console.ReadKey();
                impMenu();
            }


















        }


        }




    }
}
