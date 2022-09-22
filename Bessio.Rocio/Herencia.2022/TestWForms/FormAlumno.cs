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
    public partial class FormAlumno : FormPersona
    {
        //Atributo
        protected Alumno alumnito;

        //Propiedad
        public Alumno Alumnito { get { return this.alumnito; } }

        //Constructor
        public FormAlumno()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.btnAceptar.Click-= new EventHandler(this.btnAceptar_Click);
            
        }

        //Manejador de evento
        private void btnAceptar_ClickAlumno(object sender, EventArgs e)
        {
            if(base.CargarFormulario())
            {
             this.alumnito = new Alumno(base.txtNombre.Text, base.txtApellido.Text, int.Parse(base.txtDni.Text),
                                 int.Parse(this.txtNotaUno.Text), int.Parse(this.txtNotaDos.Text), int.Parse(this.txtNotaTres.Text));
             this.DialogResult = DialogResult.OK;
            }
           
        }

      
    }
}
