using System;
using System.Collections.Generic;
using System.Text;

namespace SystemInscription
{
    public sealed class RepositorioDeDatos
    {

        public static RepositorioDeDatos Instancia { get; } = new RepositorioDeDatos();
        public List<Materia> materias = new List<Materia>();
        public List<Estudiantes> estudiantes = new List<Estudiantes>();
        private RepositorioDeDatos()
        {
        }
    }
}
