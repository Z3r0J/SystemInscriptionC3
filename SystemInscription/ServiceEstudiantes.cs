using System;
using System.Collections.Generic;
using System.Text;

namespace SystemInscription
{
    public class ServiceEstudiantes
    {
        public void AgregarEstudiantes()
        {
            Console.WriteLine("Ingresa el nombre de el Estudiantes: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido de el Estudiantes: ");
            string lastName = Console.ReadLine();
            Estudiantes Estudiantes = new Estudiantes(Nombre,lastName);
            RepositorioDeDatos.Instancia.estudiantes.Add(Estudiantes);

        }
        public void ListConMaterias()
        {
            int count = 1;

            foreach (Estudiantes item in RepositorioDeDatos.Instancia.estudiantes)
            {
                Console.WriteLine($"{count} - {item.Name}          {item.LastName}");
                int counter = 1;
                Console.WriteLine("Listado de materias seleccionadas: ");
                foreach (Materia materia in  item.OwnMaterias)
                {
                    Console.WriteLine($"    {counter}- {materia.Name}");
                    counter++;
                }
                count++;
            }

        }
        public void List()
        {
            int count = 1;

            foreach (Estudiantes item in RepositorioDeDatos.Instancia.estudiantes)
            {
                Console.WriteLine($"{count} - {item.Name}          {item.LastName}");
                count++;
            }
            
        }
        public void Delete()
        {
            try
            {
                List();
                Console.WriteLine("Seleccione la Estudiantes a eliminar: ");
                int index = Convert.ToInt32(Console.ReadLine());

                RepositorioDeDatos.Instancia.estudiantes.RemoveAt(index - 1);

                Console.WriteLine("Se elimino con exito.");
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Edit()
        {
            try
            {
                List();
                Console.WriteLine("Seleccione el Estudiantes a editar: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nuevo nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo apellido: ");
                string lastName = Console.ReadLine();
                Estudiantes Estudiantes = new Estudiantes(name, lastName);


                RepositorioDeDatos.Instancia.estudiantes[index - 1] = Estudiantes;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
