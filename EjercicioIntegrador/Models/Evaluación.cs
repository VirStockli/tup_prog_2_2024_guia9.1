using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador.Models
{
    public abstract class Evaluación
    {
        public string Nombre { get; }

        public string Descripcion { get; }

        public Evaluación (string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        public abstract TipoAprobacion Evaluar();

        public override string ToString()
        {
            return $"{Nombre}-{Descripcion}-{Evaluar()}\n\r";
        }
    }
}
