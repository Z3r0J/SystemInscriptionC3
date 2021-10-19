using System;
using System.Collections.Generic;
using System.Text;

namespace SystemInscription
{
    class MenuEstudiantes
    {
        public void ImprimirMenu()
        {
            try
            {
                Console.Clear();
                ServiceEstudiantes serviceEstudiantes = new ServiceEstudiantes();
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                Console.WriteLine("1 - Agregar Estudiantes \n" +
                    "2 - Editar Estudiantes \n" +
                    "3 - Borrar Estudiantes\n" +
                    "4 - Listar Estudiantes\n" +
                    "5 - Volver Atras");
                Console.Write("> ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case (int)OpcionesMantenimientos.AGREGAR:
                        serviceEstudiantes.AgregarEstudiantes();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case (int)OpcionesMantenimientos.EDITAR:
                        serviceEstudiantes.Edit();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case (int)OpcionesMantenimientos.LISTAR:
                        serviceEstudiantes.ListConMaterias();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case (int)OpcionesMantenimientos.BORRAR:
                        serviceEstudiantes.Delete();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case (int)OpcionesMantenimientos.ATRAS:
                        menuPrincipal.ImprimirMenu();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Debe colocar una opción valida");
                Console.ReadKey();
                ImprimirMenu();
            }
        }
    }
}
