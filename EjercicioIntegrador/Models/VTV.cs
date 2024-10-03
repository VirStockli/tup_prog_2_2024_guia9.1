using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador.Models
{
    internal class VTV
    {
        private int verificaciones;
        public string Patente { get; }
        public DateTime Fecha { get; }
        public int CantidadVerificaciones
        {
            get 
            {  verificaciones += 1;
                return verificaciones; //revisar por relacion composición dice muchos(?)
            }
        }
        
        public Evaluación VTV 
         //Ver cómo implementar indexador con indexer
        
        public Propietario p {  get; }
        public TipoAprobacion Aprobacion { get; }

        public VTV (string patente, Propietario propietario)
        {
            this.Patente = patente;
            this.p = propietario;
        }
        public string[] EmitirComprobante() 
        {
            return new string[0]; //Comprobar método para realizar un vector de strings ej5?
        }

        public override string ToString()
        {
            return @"";
        }
    }
}
