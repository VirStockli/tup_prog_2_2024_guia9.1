using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador.Models
{
    internal class FiscalizadorVTV
    {
        public int CantidadVTV { get; }

        public string PlantillaComprobante { get; set; }

        public VTV AgregarVTV (string patente, Propietario propietario)
    }
}
