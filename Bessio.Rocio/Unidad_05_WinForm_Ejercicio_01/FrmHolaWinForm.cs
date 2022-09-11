using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_05_WinForm_Ejercicio_01
{
    public partial class FrmHolaWinForm : Form
    {
        public FrmHolaWinForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMaterias.Items.Add("Programacion I");
            cbMaterias.Items.Add("Laboratorio de Computacion I");
            cbMaterias.Items.Add("Ingles I");
            cbMaterias.Items.Add("Sistema de Procesamiento de Datos");
            cbMaterias.Items.Add("Matematicas");
            cbMaterias.Items.Add("Programacion II");
            cbMaterias.Items.Add("Laboratorio de Computacion II");
            cbMaterias.Items.Add("Ingles II");
            cbMaterias.Items.Add("Estadistica");
            cbMaterias.Items.Add("Arquitectura y Sistemas Operativos");
            cbMaterias.Items.Add("Metodologia de la investigacion");
            cbMaterias.SelectedIndex = 0;
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string mensaje = $"Soy {txtNombre.Text} {txtbApellido.Text} y mi materia favorita es {cbMaterias.SelectedItem} ";
            string titulo = "¡Hola, Windows Form!";
            if (Validar())
            {
                FrmMensaje frmMensaje = new FrmMensaje(titulo,mensaje);
                frmMensaje.ShowDialog();
            }
        }

        private bool Validar()
        {
            bool isValid = true;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Debe de completar los siguientes campos: ");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))//Verifico que no devuelva null 
            {
                isValid = false;
                sb.AppendLine("Nombre!");
            }
            if (string.IsNullOrWhiteSpace(txtbApellido.Text))//Verifico que no devuelva null 
            {
                isValid = false;
                sb.AppendLine("Apellido!");
            }
            if (!isValid)//Verifico que no devuelva null 
            {
                MessageBox.Show(sb.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

    }
}
