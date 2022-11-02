using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_17_Delegados_Ejercicio_I01
{
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegado(string nombre);
        public ActualizarNombreDelegado actualizarNombreDelegado;

        #region CONSTRUCTOR FORM

        /// <summary>
        /// Se pide que el usuario ingrese un nombre por el TextBox de FrmTestDelegados y que al pulsar el botón btnActualizar, se cambie el valor del Label 
        /// de la instancia de FrmMostrar.
        /// Se deberá utilizar un delegado dentro de FrmTestDelegados, convenientemente diseñado, a fin de cumplir este punto.
        /// El delegado deberá ser invocado (método Invoke) al presionar el btnActualizar.
        /// Al instanciar FrmTestDelegados se deberá asociar el delegado al método ActualizarNombre de FrmMostrar.
        /// </summary>
        /// <param name="actualizarNombreDelegado"></param>
        public FrmTestDelegados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Frm Delegados";
        }
        #endregion

        #region EVENTOS DELEGADOS FORM



        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
        }


        #endregion

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizarNombreDelegado.Invoke(this.txtNombre.Text);//Invoco el delegado y le paso lo que esta en el text box
        }
    }
}
