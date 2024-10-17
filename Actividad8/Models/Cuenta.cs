using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Cuenta : IComparable
    {
        public int Numero { get; set; }
        public double Saldo 
        { get; set; }

        public Persona Titular {  get; set; }
        public DateTime Fecha {  get; }
        public Cuenta (int numero, Persona titular)
        {
            Numero = numero;
            Titular = titular;

        }

        public Cuenta(int numero, Persona titular, double saldo, DateTime fecha)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Fecha = DateTime.Now;
        }

        public int CompareTo(object obj)
        {
            Cuenta c = (Cuenta) obj;
            if (c != null)
            { return Numero.CompareTo(c.Numero); }
            return 1;
        }

        public override string ToString()
        {
            // $"Cta:   -Saldo:$
            return  $"{Titular} - {Numero} - {Saldo:f2}";
        }
    }
}
