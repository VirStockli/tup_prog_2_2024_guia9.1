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
        { 
            get 
            { 
                double saldo =+ 0;
                return saldo; 
            }
            
            set { } 
        }
        public DateTime Fecha 
        { 
            get
            { return DateTime.Now; }
            set { }
        }
        public Cuenta (int numero, Persona titular)
        {
            this.Numero = numero;

        }

        public Cuenta(int numero, Persona titular, double saldo, DateTime fecha)
        {
            Numero = numero;
            Saldo = saldo;
            Fecha = fecha;
        }

        public int CompareTo(object obj)
        {
            Cuenta c = (Cuenta) obj;
            if (c != null)
            { return Numero.CompareTo(c.Numero); }
            return 1;
        }
    }
}
