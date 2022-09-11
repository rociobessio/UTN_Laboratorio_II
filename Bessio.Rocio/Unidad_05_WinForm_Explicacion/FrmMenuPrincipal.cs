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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }/*
        /// <summary>
        /// CREO UNA SOBRECARGA DE CONSTRUCTOR PARA PODER MOSTRAR EL NOMBRE DEL USUARIO
        /// </summary>
        /// <param name="userName"></param>
        public FrmMenuPrincipal(string userName) : this()
        {
            this.label1.Text = this.label1.Text + " " + userName;
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// HACE LO MISMO QUE EL CONSTRUCTOR SOLO QUE ES EL METODO
        /// </summary>
        /// <param name="nombreUser"></param>
        public void ActualizarMensaje(string nombreUser)
        {
            this.label1.Text = this.label1.Text + " " + nombreUser;

        }

    }
}
