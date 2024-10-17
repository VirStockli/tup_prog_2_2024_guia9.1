using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Banco
    {
        private List<Persona> clientes = new List<Persona>();
        private List<Cuenta> cuentas = new List<Cuenta>();
        public int CantidadClientes
        { get { return clientes.Count; } }

        public int CantidadCuentas
        { get { return cuentas.Count; } }

        public Cuenta this[int idx]
        { get { return cuentas[idx]; } }
        
        public Cuenta AgregarCuenta(int numeroCuenta, int dni, string nombre)
        {
            Persona p = VerClientePorDNI(dni);
            if (p == null)
            {
                p = new Persona(dni, nombre);
                clientes.Add(p);
            }
            Cuenta c = VerCuentaPorNumero(numeroCuenta);
            if (c == null)
            {
                c = new Cuenta(numeroCuenta, p);
                cuentas.Add(c);
            }
            return c;
            
        }

        public Cuenta VerCuentaPorNumero (int numeroCuenta)
        {
            Cuenta c = new Cuenta(numeroCuenta,null);
            cuentas.Sort();
            int idx = cuentas.BinarySearch(c);
            if (idx >= 0)
            {
                return c;
            }
            return null;
        }
        public Persona VerClientePorDNI (int dni)
        {
            Persona p = null;
            clientes.Sort();
            int idx = clientes.BinarySearch(p);
            if (idx >= 0)
            {
                return p;
            }
            return null;
        }

        public bool RestaurarCuenta(int numero, Persona titular, double saldo, DateTime fecha)
        {
            bool b = false;
            Cuenta c = VerCuentaPorNumero(numero);
            if (c == null)
            {
                c = new Cuenta(numero, titular, saldo, fecha);
                cuentas.Add(c);
                b = true;
            }
            return b;
        }
    }
}
