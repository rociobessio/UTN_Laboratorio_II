using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_05_WinForms_Ejercicio_02
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            this.Text = "Registro";
            listbPaises.Items.Add("Argentina");
            listbPaises.Items.Add("Chile");
            listbPaises.Items.Add("Uruguay");
            listbPaises.SelectedIndex = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.ToString();
            string direccion = txtDireccion.Text.ToString();
            int edad = (int)numEdad.Value;
            string pais = listbPaises.SelectedItem.ToString();
            string[] curso = {cbC.Text, cbCSharp.Text, cbJavaScript.Text};
            string genero;
            if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "No binario";
            }
            Ingresante ingreso = new Ingresante(nombre,direccion,genero,pais,curso,edad);
            string infoIngresante = ingreso.Mostrar();
            MessageBox.Show(infoIngresante,"Informacion",MessageBoxButtons.OK);
        }
    }
}
