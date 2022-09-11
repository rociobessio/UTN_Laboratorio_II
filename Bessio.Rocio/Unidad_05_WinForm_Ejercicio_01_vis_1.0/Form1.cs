using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_05_WinForm_Ejercicio_01_vis_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Para centrar el form en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Estas acciones se realizan en el evento load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Creo una app que al iniciar torne en invisible el label:
            this.lblSaludo.Visible = false;

            //Aparece arriba a la izquierda del form
            this.Text = "Saludo desde un Form!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Al hacer click en el boton se muestra/hace visible el enunciado del label
            lblSaludo.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
