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
    public partial class FrmMenuCrud : Form
    {
        #region ATRIBUTOS
        private List<Persona> listaPersonas = new List<Persona>();
        PersonaADO ado = new PersonaADO();
        Persona persona = new Persona(0, "", "");
        #endregion

        public FrmMenuCrud()
        {
            InitializeComponent();
        }


        #region BOTONES FORM
        /// <summary>
        /// Debera mostrar la lista de personas devuelta por el metodo Leer de PersonaDAO, invocado al presionar el boton Leer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeer_Click(object sender, EventArgs e)
        {
            listaPersonas = ado.Leer();//Me devuelve la lista de la base de datos..
            dataGridPersonas.DataSource = listaPersonas;
        }

        /// <summary>
        /// btnGuardar agregara una persona en la base de datos tomando sus datos de los Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarIngresoDatos(txtNombre.Text,txtApellido.Text))
            {
                this.CargarPersona();
                this.ado.Guardar(persona);
            }
            else
            {
                this.ErrorShow("ERROR AL INTENTAR CARGAR LOS DATOS, REINTENTE!");
            }
        }

        /// <summary>
        /// Borrara de la base de datos a la persona seleccionada en el datagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPersonas.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(this.dataGridPersonas.SelectedRows[0].Cells[0].Value);//ID esta en la fila 0 y en la celda 0
                    ado.Eliminar(id);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool todoOk = Validador.ValidarIngresoDatos(txtNombre.Text, txtApellido.Text);

            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int id = Convert.ToInt32(this.dataGridPersonas.SelectedRows[0].Cells[0].Value);//ID esta en la fila 0 y en la celda 0
                if (todoOk)
                {
                    Persona personaMOdificar = new Persona(id, txtNombre.Text, txtApellido.Text);
                    ado.Modificar(personaMOdificar);
                }
                else
                {
                    this.ErrorShow("ERROR AL INTENTAR CARGAR LOS DATOS, REINTENTE!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Boton de ayuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardar: Se guarda a la persona enla base de datos.\nLeer: Muestra a las personas en la base de datos." +
                "\nModificar: Se cargan los textBox en el indice indicado dentro del dataGrid y se modifica." +
                "\nEliminar: Se selecciona desde el dataGrid con un click a quien quiero eliminar de la base de datos.", 
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Cargo a una persona, añadiendo nombre y apellido de cada textbox
        /// </summary>
        private void CargarPersona()
        {
            this.persona.Apellido = txtApellido.Text;
            this.persona.Nombre = txtNombre.Text;
        }

        /// <summary>
        /// Metodo que muestra un mensaje de error
        /// </summary>
        /// <param name="cadena"></param>
        private void ErrorShow(string cadena)
        {
            MessageBox.Show(cadena, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //LIMPIO CONTENIDO DEL TEXT BOX
            this.txtApellido.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
        }

        #endregion

        private void dobleClickModificar(object sender, DataGridViewCellEventArgs e)
        {
        }


    }
}
