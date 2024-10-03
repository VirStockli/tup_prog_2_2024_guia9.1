using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador.Models
{
    internal class EvaluacionSimple : Evaluación
    {
        public bool HaVerificado { get; }

        public EvaluacionSimple(string nombre, string descripcion, bool haVerificado) : base(nombre, descripcion)
        {
            HaVerificado = haVerificado;
        }
        public override TipoAprobacion Evaluar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{HaVerificado}\n\r "; //Cómo hacer que concatene este ToString con el anterior
        }
    }
}
