using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador.Models
{
    internal class EvaluacionParametrica : Evaluación
    {
        public double ValorMinimo { get; }
        public double ValorMaximo { get; }
        public string Unidad { get; }
        public double ValorTolerado { get; }
        public double ValorMedido { get; set; }

        public EvaluacionParametrica (string nombre, string descripcion, double min, double max, 
        string unidad, double tolerado, double valorMedido) : base (nombre, descripcion)
        {
            ValorMaximo = max;
            ValorMinimo = min;
            ValorTolerado = tolerado;
            Unidad = unidad;
            ValorMedido = valorMedido;
        }

        public override TipoAprobacion Evaluar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Valor Medido: {ValorMedido}({Unidad})\n\r "; //Cómo hacer que concatene este ToString con el anterior
        }

    }
}
