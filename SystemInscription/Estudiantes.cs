using System;
using System.Collections.Generic;
using System.Text;

namespace SystemInscription
{
    public class Estudiantes
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Materia> OwnMaterias { get; set; }

        public Estudiantes(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
