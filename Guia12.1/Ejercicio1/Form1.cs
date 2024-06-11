using Ejercicio1.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Controlador control = new Controlador();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            FormAgregar fAgregar = new FormAgregar();
            if (fAgregar.ShowDialog() == DialogResult.OK)
            {
                string nombre = fAgregar.tbxNombre.Text;

                control.AgregarCompetidor(nombre);
            }     

            /*
            control.AgregarCompetidor("a");
            control.AgregarCompetidor("b");
            control.AgregarCompetidor("c");*/
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            FormCargar fCargar = new FormCargar();
     
            
            for (int i = 0; i < control.contador;  i++) {

                fCargar.lbNumero.Text = i.ToString("0");

                fCargar.ShowDialog();
                    int hh = Convert.ToInt32(fCargar.tbxHora.Text);
                    int mm = Convert.ToInt32(fCargar.tbxMinuto.Text);

                    control.CargarTiempo(i, hh, mm);

                    fCargar.lbNumero.Text = i.ToString("000");
            }         
            /*
            control.CargarTiempo(0, 5, 1);
            control.CargarTiempo(1, 1, 1);
            control.CargarTiempo(2, 8, 1);*/
        }

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            FormVer fVer = new FormVer();
            
            control.ordenarListadoxTiempo();

            fVer.lbxResultados.Items.Clear();

            for (int i = 0; i < control.contador; i++)
            {
                int tiempo = control.Tiempos[i];
                int HH = tiempo / 60;
                int MM = tiempo % 60;
                fVer.lbxResultados.Items.Add($"{control.Nombres[i]} {HH:00}:{MM:00}");
            }

            fVer.ShowDialog();
        }
    }
}
