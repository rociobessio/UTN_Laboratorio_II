using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca;

namespace Unidad_05_WinForm_Ejercicio_02_Vis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Tabla";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Al presionar el boton de limpiar, se tiene que limpiar el textBox y la listBox
            this.lbtTabla.Items.Clear();
            this.textBox1.Text = " ";
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)//Valido si se presiono enter
            {
                string numeroIngresado = textBox1.Text;
              /*  var resultado = Multiplicadora.validarNumeros(int.Parse(numeroIngresado));
                if(resultado == false)
                {
                    MessageBox.Show("No es un numero!","Error",MessageBoxButtons.OK);
                }*/
                var tablas = Multiplicadora.TablaMultiplicar(int.Parse(numeroIngresado)).Split('.');
                lbtTabla.Items.Clear();
                foreach(var tabla in tablas)
                {
                    this.lbtTabla.Items.Add(tabla);
                }
            }
        }


        private void FrmTablas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Al cerrar el formulario, se le preguntará al usuario si realmente desea cerrar el formulario (en
            //el evento FormClosing del formulario FrmPrincipal).
            if(MessageBox.Show("¿Desea salir del formulario?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
