using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_16_SQL_Biblioteca_I01;

namespace Unidad_16_SQL_Ejercicio_I01_WinForm
{
    public partial class FrmLogin : Form
    {
        #region ATRIBUTOS DEL FORM
        private Usuarios usuario;
        private List<Usuarios> listaUsuarios;
        private UsuariosDAO usuariosDAO = new UsuariosDAO();
        #endregion

        #region INCIALIZAR FORM
        public FrmLogin()
        {
            InitializeComponent();
            this.usuario = new Usuarios(0,"","");
            this.listaUsuarios = new List<Usuarios>();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        #region METODOS FORM
        /// <summary>
        /// Al presionar 'Login' se buscara al usuario dentro de la base de datos,
        /// si lo encuentra y pasa las validaciones entonces continua al siguien form...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            this.listaUsuarios = UsuariosDAO.LeerUsuarios();//Me retorna la lista de la base de datos
            this.usuario.Usuario = user;//Asigno el user
            this.usuario.Contraseña = contraseña;//Asigno la contraseña

            //1ro Valido que lo ingresado no sea NULO y 2do me fijo si coincide con la base de datos
            if ((Validador.ValidarIngresoDatos(user,contraseña)) && (usuario.ConfirmarUsuario(listaUsuarios,usuario)))
            {
                MessageBox.Show("USUARIO LOGUEADO!");

                //si el usuario logro LOGUEARSE entonces se abre el SEGUNDO FORMULARIO
                FrmMenuCrud menu = new FrmMenuCrud();

                menu.Show();//MUESTRO EL SEGUNDO FORM

                //Y SI QUIERO QIE OCULTE EL PRIMER FORM
                this.Hide();
            }
            else
            {
                this.ErrorShow("ERROR AL INTENTAR LOGUEARSE, REINTENTE!");
            }
        }

        #endregion

        #region METODOS EXTRA

        /// <summary>
        /// Metodo que muestra un mensaje de error
        /// </summary>
        /// <param name="cadena"></param>
        private void ErrorShow(string cadena)
        {
            MessageBox.Show(cadena, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //LIMPIO CONTENIDO DEL TEXT BOX
            this.txtUsuario.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
        }

        /// <summary>
        /// Boton de ayuda para que el usuario sepa que es lo que hace ese form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario debe de ingresar su usuario y contraseña para continuar", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

    }
}
