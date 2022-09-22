using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TestWForms
{
    public partial class FormProfesor : FormPersona
    {
        //Atributo
        private Profesor profe;

        //Constructor
        public FormProfesor()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.btnAceptar.Click -= new EventHandler(this.btnAceptar_Click);

        }

        //Propiedad
        public Profesor Profe { get {return this.profe; } }

        //Manejador de evento
        private void btnAceptar_ClickProfesor(object sender, EventArgs e)
        {
            if(base.CargarFormulario())
            {
                this.profe = new Profesor(base.txtNombre.Text, base.txtApellido.Text,
                                                         int.Parse(base.txtDni.Text), int.Parse(this.txtSueldo.Text));
                this.DialogResult = DialogResult.OK;
            }
          
                 
        }

        
    }
}
