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
    public partial class FrmPrincipal : Form
    {
        #region ATRIBUTOS FORM
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;
        #endregion;

        #region CONSTRUCTOR DEL FORM
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text = "FRM PRINCIPAL";
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        #region EVENTOS DEL FORM
        /// <summary>
        /// En el evento Load:
        /// Se asignará una instancia de FrmMostrar a un atributo de la clase.El MdiParent de dicha instancia será FrmPrincipal.
        /// Se asignará una instancia de FrmTestDelegados a un atributo de la clase. El MdiParent de dicha instancia será FrmPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();//Se asignará una instancia de FrmMostrar a un atributo de la clase.
            this.frmTestDelegados = new FrmTestDelegados();//Se asignará una instancia de FrmTestDelegados a un atributo de la clase. 

            this.frmMostrar.MdiParent = this;//El MdiParent de dicha instancia será FrmPrincipal (this).
            this.frmTestDelegados.MdiParent = this;//El MdiParent de dicha instancia será FrmPrincipal (this).

            this.frmTestDelegados.actualizarNombreDelegado += this.frmMostrar.ActualizarNombre;
        }

        /// <summary>
        /// Cuando el usuario pulse el submenú "Test Delegados", mostrar el FrmTestDelegados de forma no-modal.
        /// Una vez que el formulario se encuentre visible se deberá habilitar la opción de menú "Mostrar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();//mostrar el FrmTestDelegados de forma no-modal.
            this.toolStripMenuMostrar.Enabled = false;//Una vez que el formulario se encuentre visible se deberá habilitar la opción de menú "Mostrar".
        }

        #endregion

        private void toolStripMenuAlumnos_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cuando el usuario pulse el menú "Mostrar", mostrar el FrmMostrar de forma no-modal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuMostrar_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();//mostrar el FrmMostrar de forma no-modal.
        }
    }
}
