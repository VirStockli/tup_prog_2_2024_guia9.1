using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Banco
    {
        private List<Persona> clientes;
        private List<Cuenta> cuentas;
        public int CantidadClientes
        { get { return clientes.Count; } }

        public int CantidadCuentas
        { get { return cuentas.Count; } }

        public Cuenta this[int idx]
        { get { return cuentas[idx]; } }
        
        public Cuenta AgregarCuenta(int numeroCuenta, int dni, string nombre)
        {
            Cuenta c = null;
            Persona p = new Persona (dni, nombre);
            clientes.Sort();
            int idx = clientes.BinarySearch(p);
            if (idx >= 0)
            { 
                c = VerCuentaPorNumero(numeroCuenta);
                if (c!=null)
                c = new Cuenta(numeroCuenta, p);
                cuentas.Add(c);
            }
            else
            {
                clientes.Add(p);
                c = new Cuenta(numeroCuenta, p);
                cuentas.Add(c);
            }

            
            return c;
        }

        public Cuenta VerCuentaPorNumero (int numeroCuenta)
        {
            Cuenta c = null;
            return c;
        }
        public Persona VerClientePorDNI (int dni)
        {
            Persona p = null;
            return p;
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
