using Unidad_16_SQL_Biblioteca_Ejercicio_I03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmBiblioteca : Form
    {
        #region INTANCIAR FORM
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarBiblioteca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region ACCIONES FORM
        /// <summary>
        /// Realiza la llamada al metodo Leer cada vez que ocurra un cambio en las entidades
        /// </summary>
        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDAO.Leer();//Leo la lista de la Base de datos y se la paso al dataGrid
            dtgvBiblioteca.Refresh();
            dtgvBiblioteca.Update();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBiblioteca.SelectedRows.Count > 0)
                {
                    Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                    JuegoDAO.Eliminar(biblioteca.CodigoJuego);
                    RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Crea una nueva instancia de FrmAlta para cargarlo a nuestro nuevo juego a la tabla.
        /// Retorna DialogResul.OK una vez terminada la operacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAlta frmAlta = new FrmAlta();//Instancio el Formulario de alta

                if (frmAlta.ShowDialog() == DialogResult.OK)
                {
                    RefrescarBiblioteca();//Refresco la biblioteca
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Reutilizar FrmAlta para poder modificar toda la informacion del juego pero sin dejarle utilizar
        /// el combo de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgvBiblioteca.SelectedRows.Count > 0)
                {
                    Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                    FrmAlta frmAlta = new FrmAlta(biblioteca.CodigoJuego);

                    if (frmAlta.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarBiblioteca();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
