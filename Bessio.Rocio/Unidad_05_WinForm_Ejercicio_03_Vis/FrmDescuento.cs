using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
                            
            Guía de ejercicios básicos con Windows Forms:
        ---------------------------------------------------

    Un restaurante ofrece un descuento del 10% para consumos entre $3000 y $5000; un
    descuento del 20% para consumos mayores a $5000; para todos los demás casos no se
    aplica ningún tipo de descuento.
    Elaborar una aplicación que permita determinar el importe a pagar por el consumidor.
    El btnAceptar, realizará los cálculos.
    El btnLimpiar, se encargará de restablecer los valores de todos los controles (recorrer la
    propiedad Controls del formulario y “limpiar” los TextBoxes).
*/
namespace Unidad_05_WinForm_Ejercicio_03_Vis
{
    public partial class FrmDescuento : Form
    {
        public FrmDescuento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmDescuento_Load(object sender, EventArgs e)
        {
            //lO QUE HACE ES ESCRIBIR ARRIBA A LA IZQUIERDA DEL FORM
            this.Text = "Descuento";
            
            //LO QUE HACEMOS ES INHABILITAR AL USUARIO DE PODER ESCRIBIR EN LOS TEXT BOX
            txtDescuento.Enabled = false;
            txtTotalPagar.Enabled = false;
        }


        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*    Un restaurante ofrece un descuento del 10% para consumos entre $3000 y $5000; un
                  descuento del 20% para consumos mayores a $5000; para todos los demás casos no se
                  aplica ningún tipo de descuento.
             */
            float precioIngresado = float.Parse(txtValorCobrar.Text);
            float precioFinal = 0;
            float precioDescuento = 0;
            if(precioIngresado>=3000 && precioIngresado<=5000)
            {
                //descuento del 10
                precioDescuento = (precioIngresado + (precioIngresado * 10)) / 100;
                precioFinal = precioIngresado - precioDescuento;
                this.txtDescuento.Text = Convert.ToString(precioDescuento);
                this.txtTotalPagar.Text = Convert.ToString(precioFinal);
            }
            else if(precioIngresado>5000)
            {
                precioDescuento = (precioIngresado + (precioIngresado * 20)) / 100;
                precioFinal = precioIngresado - precioDescuento;
                this.txtDescuento.Text = Convert.ToString(precioDescuento);
                this.txtTotalPagar.Text = Convert.ToString(precioFinal);
            }
            else
            {
                this.txtDescuento.Text = Convert.ToString(0);
                this.txtTotalPagar.Text = Convert.ToString(precioIngresado);
            }
        }

        /// <summary>
        ///     El btnLimpiar, se encargará de restablecer los valores de todos los controles (recorrer la
        ///     propiedad Controls del formulario y “limpiar” los TextBoxes).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //El foreach garantiza que al momento de buscar un indice de array sin saltear ninguno y desbordar 
            //Primero recibe EL TIPO Y NOMBRE DE LA VARIABLE, in (sobre que coleccion se recorre) 

            //Se tienen que recorrer controles
            foreach(Control item in this.groupBox1.Controls)//Limpio con el foreach las 3 text box del form que estan alojadas en el GROUPBOX
            {
                if (item is TextBox)//Operador is indica si la variable es del tipo que coloco a la derecha, devuelve true or false
                {
                    //Casteo el control a textbox
                    ((TextBox)item).Clear();
                }
                /*if(item.GetType() == typeof(TextBox))
                {
                    TextBox t1 = item as TextBox;//Con estructuras
                    t1.Text = "";
                }*/
            }
        }

        private void FrmDescuento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea finalizar la aplicacion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
