using System;
using System.Collections.Generic;
using System.Text;

namespace SystemInscription
{
    class MenuPrincipal
    {
        public void ImprimirMenu()
        {
            try
            {
                Console.Clear();
                MenuMaterias menuMaterias = new MenuMaterias();
                MenuEstudiantes menuEstudiantes = new MenuEstudiantes();
                ServiceInscripcion serviceInscripcion = new ServiceInscripcion();
                Console.WriteLine("1 - Mantenimiento de materias \n" +
                    "2 - Mantenimiento de Estudiantes \n" +
                    "3 - Inscripcion\n" +
                    "4 - Salir");
                Console.Write("> ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case (int)OpcionesMenuPrincipal.MANT_MATERIAS:
                        menuMaterias.ImprimirMenu();
                        Console.ReadKey();
                        break;
                    case (int)OpcionesMenuPrincipal.MANT_ESTUDIANTES:
                        menuEstudiantes.ImprimirMenu();
                        Console.ReadKey();
                        break;
                    case (int)OpcionesMenuPrincipal.INSCRIPCION:
                        serviceInscripcion.Inscribir();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case (int)OpcionesMenuPrincipal.SALIR:
                        Console.WriteLine("Gracias por usar el sistema.");
                        Console.ReadKey();
                        Environment.Exit(0);
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
