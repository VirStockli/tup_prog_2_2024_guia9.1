using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Persona : IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona (int dNI, string nombre)
        {
            DNI = dNI;
            Nombre = nombre;
        }

        public int CompareTo(object obj)
        {
            Persona p = obj as Persona;
            if (p != null)
            { return DNI.CompareTo(p.DNI);}
            return 1;
        }
    }
}
