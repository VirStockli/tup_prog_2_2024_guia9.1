using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador.Models
{
    internal class Propietario
    {
        public int DNI { get; set; }
        public string ApellidosNombres {  get; set; }
        public string Email {  get; set; }

        public Propietario (int dni, string nombre, string email)
        {
            DNI = dni;
            Email = email;
            ApellidosNombres = nombre;
        }

        public override string ToString()
        {
            return $"{DNI} - {ApellidosNombres} - {Email}";
        }
    }
}
