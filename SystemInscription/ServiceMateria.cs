using System;
using System.Collections.Generic;
using System.Text;

namespace SystemInscription
{
    public class ServiceMateria
    {
        public void AgregarMaterias()
        {
            Console.WriteLine("Ingresa el nombre de la materia: ");
            string Nombre = Console.ReadLine();

            Materia materia = new Materia(Nombre);
            RepositorioDeDatos.Instancia.materias.Add(materia);

        }

        public void List()
        {
            int count = 1;

            foreach (Materia item in RepositorioDeDatos.Instancia.materias)
            {
                Console.WriteLine($"{count} - {item.Name}");
                count++;
            }
            
        }
        public void Delete()
        {
            try
            {
                List();
                Console.WriteLine("Seleccione la materia a eliminar: ");
                int index = Convert.ToInt32(Console.ReadLine());

                RepositorioDeDatos.Instancia.materias.RemoveAt(index - 1);

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
                Console.WriteLine("Seleccione la materia a editar: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nuevo nombre: ");
                string name = Console.ReadLine();
                RepositorioDeDatos.Instancia.materias[index - 1].Name = name;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
