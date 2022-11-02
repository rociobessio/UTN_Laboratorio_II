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
    /// <summary>
    /// Se encarga de guardar o modificar el juego en la base de datos
    /// </summary>
    public partial class FrmAlta : Form
    {

        #region ATRIBUTOS
        int codigoJuego;
        #endregion

        #region INSTANCIAR FORM
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            cmbUsuarios.Hide();
            lblUsuarios.Text = string.Empty;
            this.codigoJuego = codigoJuego;
            PintarForm();
        }
        #endregion

        #region ACCIONES FORM
        private void PintarForm()
        {
            Juego juego = JuegoDAO.LeerPorID(codigoJuego);

            txtGenero.Text = juego.Genero;
            txtNombre.Text = juego.Nombre;
            nupPrecio.Value = (decimal)juego.Precio;
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            try
            {
                cmbUsuarios.DataSource = UsuarioDAO.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text != "Modificar")//Si no es modificar el boton, realizo la logica
                {
                    Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text,//Instancio el juego
                    ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);//Elijo el usuario del comboBox

                    JuegoDAO.Guardar(nuevoJuego);
                }
                else//Si es modificar
                {
                    Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, codigoJuego,
                   ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                    JuegoDAO.Modificar(nuevoJuego);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
            }
        }
        #endregion
    }
}

