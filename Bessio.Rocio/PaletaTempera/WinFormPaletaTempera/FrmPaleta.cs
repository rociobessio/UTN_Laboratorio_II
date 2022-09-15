using System;
using System.Windows.Forms;
using MiBiblioteca;
//agregar using a las entidades


namespace WinFormPaletaTempera
{
    public partial class FrmPaleta : Form
    {
        #region ATRIBUTOS
        private Paleta paleta;
        #endregion

        public FrmPaleta()
        {
            InitializeComponent();

            this.paleta = 3;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //con getter
                //this.paleta += frm.ObtenerTempera();
                //con propiedad
                this.paleta += frm.TemperaDelForm;

                this.txtVisor.Clear();
                this.txtVisor.Text = (string)this.paleta;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //con getter
                //this.paleta -= frm.ObtenerTempera();
                //con propiedad
                this.paleta -= frm.TemperaDelForm;

                this.txtVisor.Clear();
                this.txtVisor.Text = (string)this.paleta;
            }
        }
    }
}
