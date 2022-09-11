using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_05_WinForm_Explicacion_Lucas
{
    /// <summary>
    /// El modificador PARTIAL, quiere decir que una clase esta partida en dos, que el proyecto
    /// va a manejar dos particiones, ejemplo el codigo y el designer.
    /// </summary>
    public partial class FrmLogin1 : Form
    {
        public FrmLogin1()
        {//Instacia TODOS LOS CONTROLES que se encuentran en el formulario
            InitializeComponent();
        }

        /// <summary>
        ///Al darle doble click al elemento del form se nos activa ESTE METODO/EVENTO
        ///y cada click que le hagamos, tendra una reaccion, es lo que va a hacer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Si el formulario instanciado (el elemento) de textbox de user, .Text porque es una caracterica hace referencia al
            //contenido que tienne, el texto que esta escrito
            if (this.tb_user.Text == "rocio" && this.tb_pass.Text == "1234")
            {
                //Con el MessageBox.Show se al hacer click se muestra el mensaje en pantalla
                // MessageBox.Show("USUARIO LOGUEADO!");

                //si el usuario logro LOGUEARSE entonces se abre el SEGUNDO FORMULARIO
                //FrmMenuPrincipal menu = new FrmMenuPrincipal(this.tb_user.Text);//Para pasarle el nombre del usuario lo que hacemos es: 
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.ActualizarMensaje(this.tb_user.Text);
                
                menu.Show();//MUESTRO EL SEGUNDO FORM

                //Y SI QUIERO QIE OCULTE EL PRIMER FORM
                this.Hide();
            }
            else
            {
                MessageBox.Show("USUARIO INCORRECTO!");
                //LIMPIO CONTENIDO DEL TEXT BOX
                this.tb_user.Text = string.Empty;
                this.tb_pass.Text = string.Empty;
            }
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
