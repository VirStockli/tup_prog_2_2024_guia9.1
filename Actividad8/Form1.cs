using Actividad8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8
{
    public partial class Form1 : Form
    {
        Banco b = new Banco();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //b.AgregarCuenta(100456789, 41236598, "Bona, Mauricio");
            //b.AgregarCuenta(100654789, 41236598, "Bona, Mauricio");
            //b.AgregarCuenta(200456790, 40514826, "Nilo, Miguel");
            //b.AgregarCuenta(300456799, 21365124, "Richi, Lucio");
            //b.AgregarCuenta(300485147, 38254785, "Henna, Carolina");

            lbxVer.Items.Clear();
            Cuenta c;
            lbxVer.Items.Add($"DNI______|Nombre______|Nro Cta_____|Saldo_____");
            for (int i = 0; i < b.CantidadCuentas; i++)
            {
                c = b[i];
                lbxVer.Items.Add(c);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            FileStream letras = null;
            StreamReader leyendo = null;
            try
            {
                #region algoritmo

                //crear archivo
                OpenFileDialog docu = new OpenFileDialog();

                //abrir la dirección del archivo

                if (docu.ShowDialog() == DialogResult.OK)
                {
                    //crear el flujo de bytes
                    letras = new FileStream(docu.FileName, FileMode.Open, FileAccess.ReadWrite);
                    //crear el lector de líneas
                    leyendo = new StreamReader(letras);
                    //leo la primera linea

                    string linea;
                    linea = leyendo.ReadLine();

                    //recorro el archivo leyendo línea por línea
                    while (leyendo.EndOfStream == false) //mientras el lector encuentre algo, recorre
                    {
                        //lee todas las lineas del documeto importado
                        linea = leyendo.ReadLine();
                        //hacer un vector para cada línea y sus datos
                        string[] campos = linea.Split(';');
                        //dividir y asignar cada campo
                        int dni = Convert.ToInt32(campos[0].Trim());
                        string nombre = campos[1].Trim();
                        int cuenta = Convert.ToInt32(campos[2].Trim());
                        double saldo = Convert.ToDouble(campos[3].Trim());
                        //crear un objeto con los campos adquiridos de la línea leída (comprueba si los datos ya han sido ingresados)
                        Cuenta c;
                        c = b.AgregarCuenta(cuenta, dni, nombre);
                        c.Saldo += saldo;
                    }
                

                    btnShow.PerformClick();
                }
                #endregion
            }
            catch (Exception ex)
            {
            }
            finally 
            {
                if(leyendo!=null) leyendo.Close();
                if (letras != null) letras.Close();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FileStream letras = null;
            StreamWriter escribiendo = null;
            try
            {
                #region algoritmo

                //crear archivo
                OpenFileDialog docu = new OpenFileDialog();

                //abrir la dirección del archivo

                if (docu.ShowDialog() == DialogResult.OK)
                {
                    //crear el flujo de bytes
                    letras = new FileStream(docu.FileName, FileMode.Open, FileAccess.ReadWrite);
                    //crear el lector de líneas
                   escribiendo = new StreamWriter(letras);
                    //leo la primera linea

                    for (int idx = 0; idx < b.CantidadCuentas; idx++)
                    {
                        string linea = $"";
                        escribiendo.WriteLine(linea);
                    }

                    
                }
                #endregion
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (escribiendo != null) escribiendo.Close();
                if (letras != null) letras.Close();
            }
        }
    }
}
