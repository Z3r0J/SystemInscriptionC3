using System;
using System.Collections.Generic;
using System.Text;

namespace SystemInscription
{
    class MenuMaterias
    {
        public void ImprimirMenu()
        {
            try
            {
                Console.Clear();

                MenuPrincipal menuPrincipal = new MenuPrincipal();
                ServiceMateria serviceMateria = new ServiceMateria();

                Console.WriteLine("1 - Agregar Materias \n" +
                    "2 - Editar Materias \n" +
                    "3 - Borrar Materias\n" +
                    "4 - Listar Materias\n" +
                    "5 - Volver Atras");
                Console.Write("> ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case (int)OpcionesMantenimientos.AGREGAR:
                        serviceMateria.AgregarMaterias();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case (int)OpcionesMantenimientos.EDITAR:
                        serviceMateria.Edit();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case (int)OpcionesMantenimientos.LISTAR:
                        serviceMateria.List();
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                    case (int)OpcionesMantenimientos.BORRAR:
                        serviceMateria.Delete();
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
