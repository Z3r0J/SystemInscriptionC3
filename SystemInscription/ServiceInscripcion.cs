using System;
using System.Collections.Generic;
using System.Text;

namespace SystemInscription
{
    class ServiceInscripcion
    {
        List<Materia> materiaSeleccionada = new List<Materia>();
        public void Inscribir()
        {

            try
            {
                Console.Clear();
                ServiceEstudiantes serviceEstudiantes = new ServiceEstudiantes();
                MenuPrincipal menu = new MenuPrincipal();
                if (!ValidateEstudiantes())
                {
                    Console.WriteLine("No hay estudiante en el sistema.");
                    Console.ReadKey();
                    menu.ImprimirMenu();
                }

                if (!ValidateMaterias())
                {
                    Console.WriteLine("No hay materias en el sistema.");
                    Console.ReadKey();
                    menu.ImprimirMenu();
                }
                serviceEstudiantes.List();

                Console.WriteLine("Seleccione el estudiante que desea inscribir: >");
                int index = Convert.ToInt32(Console.ReadLine());
                ProcesoInscripcion();
                RepositorioDeDatos.Instancia.estudiantes[index - 1].OwnMaterias = materiaSeleccionada;
            }
            catch (Exception)
            {

                Console.WriteLine("Debe colocar una opcion valida");
                Console.ReadKey();
                Inscribir();
            }
        }

        public void ProcesoInscripcion()
        {
            try
            {
                Console.Clear();
                ServiceMateria serviceMateria = new ServiceMateria();
                serviceMateria.List();

                Console.WriteLine("Seleccione la materia que desea inscribir: >");
                int index = Convert.ToInt32(Console.ReadLine());

                Materia materiaseleccionada = RepositorioDeDatos.Instancia.materias[index - 1];
                if (validaterepeat(materiaseleccionada.Name))
                {
                    materiaSeleccionada.Add(materiaseleccionada);
                    Console.WriteLine("Desea agregar otra materia s/n");
                    string response = Console.ReadLine();
                    if (response.ToLower() == "s")
                    {
                        Console.Clear();
                        ProcesoInscripcion();

                    }

                }
                else
                {
                    Console.WriteLine("Usted ya selecciono esa materia.");
                    Console.WriteLine("Desea agregar otra materia s/n");
                    string response = Console.ReadLine();
                    if (response.ToLower() == "s")
                    {
                        Console.Clear();
                        ProcesoInscripcion();

                    }
                }
                

            }
            catch (Exception)
            {

            }
        }

        public bool validaterepeat(string name)
        {
            foreach (Materia item in materiaSeleccionada)
            {
                if (item.Name == name)
                {
                    return false;
                }
            }
            return true;
        }
        public bool ValidateMaterias()
        {
            if (RepositorioDeDatos.Instancia.materias.Count<=0)
            {
                return false;
            }
            return true;

        }

        public bool ValidateEstudiantes()
        {
            if (RepositorioDeDatos.Instancia.estudiantes.Count <= 0)
            {
                return false;
            }
            return true;

        }
    }
}
