using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_05_WinForm_Explicacion_Neiner
{
    public partial class Form1 : Form
    {
        public Form1()
        {//Instacia TODOS LOS CONTROLES que se encuentran en el formulario
            InitializeComponent();

            //Para centrar el form en el medio de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// AL HACER DOBLE CLICK EN EL BOTON DEL FORM SE ACTIVA ESTE METODO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Al hacer click en el boton mostramos un msj

            //MessageBoxButtons.OK = en el segundo mini form nos muestra un boton con la palabra OK
            //MessageBoxIcon.Stop = muestra el iconito de stop 
            MessageBox.Show("Hola, me muestro aca!", "Aca arriba!", MessageBoxButtons.OK,MessageBoxIcon.Stop);

            //Cambiamos el color del BOTON
            this.button1.BackColor = Color.Beige;

            ///Esto lo que hace es como bajar la opacidad del form
            string texto = this.textBox1.Text;
            this.Text += texto;
            this.MiMetodo(texto);

            //Lo que hace es listar en el cuadradito
            this.listBox1.Items.Add(this.textBox1.Text);
        }

        /// <summary>
        /// ESTE FORM LOAD SALE DE APRETAR DOBLE CLICK ARRIBA A LA IZQUIERDA DEL FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Se cambia arriba a la izquierda del form
            this.Text = "Cambiado en el load!";

            //Cambio el color del form
            this.BackColor = Color.Aquamarine;
        }

        /// <summary>
        /// Lo que tuve que hacer es agregar un textBox y en el rayito buscar el evento keypress y seleccione enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)//Si la tecla ingresada es Esc se cierra el form
            {
                this.Close();
            }
            MessageBox.Show(e.KeyChar.ToString());
        }

        /// <summary>
        /// Edita la opacidad del forms
        /// </summary>
        /// <param name="algo"></param>
        public void MiMetodo(string algo)
        {
            this.Opacity = 0.3;//Opacidad de...
        }

        /// <summary>
        /// Trying to figure out q hace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }
    }
}
