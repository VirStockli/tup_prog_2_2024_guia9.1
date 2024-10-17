using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ClaseP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Clase Directory es para Directorios
        //Clase File es para archivos
        private void button1_Click(object sender, EventArgs e)
        {
            string directorio = Application.StartupPath; //ruta o camino donde guarda la aplicación

            //MessageBox.Show(directorio); <-- muestra la ruta
            directorio += @"\" + textBox1.Text; //Crea un directorio: agrega una carpeta en la carpeta anterior,
            if (!Directory.Exists(directorio)) //controla que no haya otra carpeta/directorio con el mismo nombre
            { Directory.CreateDirectory(directorio); } 
            else { MessageBox.Show("Ya existe");
                string[] archivos = Directory.GetFiles(directorio);
                if (archivos.Length == 0)
                {
                    Directory.Delete(directorio);
                }
                else { foreach (string a in archivos)
                    { File.Delete(a);
                }
            } //si ya existe ese nombre no la crea

           
        }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
