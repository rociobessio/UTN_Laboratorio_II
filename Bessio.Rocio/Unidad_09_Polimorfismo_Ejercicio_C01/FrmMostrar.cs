using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca_LaCentralita;

namespace Unidad_09_Polimorfismo_Ejercicio_C01
{
    public partial class FrmMostrar : Form
    {
        #region ATRIBUTOS DE LA CLASE
        private Llamada.TipoLlamada tipo;
        Centralita central;
        #endregion

        #region PROPIEDAD
        public Llamada.TipoLlamada Tipo { set { this.tipo = value; } }
        #endregion

        #region FRM INICIAR
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.central = centralita;
            this.tipo = Llamada.TipoLlamada.Todas;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "\n\t :::::::::::::::::::::::::::: FACTURACION ::::::::::::::::::::::::::::";
            this.richTextBox1.Text += this.central.Mostrar(this.tipo);
            this.richTextBox1.Enabled = false;
        }
        #endregion
    }
}
