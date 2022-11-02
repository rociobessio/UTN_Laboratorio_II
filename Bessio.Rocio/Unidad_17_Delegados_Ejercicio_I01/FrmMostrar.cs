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
    public partial class FrmMostrar : Form
    {
        #region CONSTRUCTOR FORM
        public FrmMostrar()
        {
            InitializeComponent();
            this.Text = "Mostrar";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        #region METODO FORM MOSTRAR
        /// <summary>
        /// Expondrá un método público llamado ActualizarNombre, que recibirá por parámetro un valor de tipo string y no
        /// retornará ningún valor. Dicho método deberá cambiar el valor de la propiedad Text del control Label con el string 
        /// sumistrado como argumento
        /// </summary>
        /// <param name="nombre"></param>
        public void ActualizarNombre(string nombre)
        {
            this.lblNombre.Text = nombre;
        }
        #endregion
    }
}
