using System;
using System.Windows.Forms;
using MiBiblioteca;
//agregar using a las entidades


namespace WinFormsAppTest
{
    public partial class Form1 : Form
    {
        private Paleta paleta;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.paleta = 3;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();
            frm.Text = "Agregar Tempera";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //con getter
                //this.paleta += frm.ObtenerTempera();
                //con propiedad
                this.paleta += frm.TemperaDelForm;

                this.CargarListadoTemperas();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstTemperas.SelectedIndex;

            if(indice == -1)
            {
                return;
            }

            FrmTempera frm = new FrmTempera(this.paleta[indice]);
            frm.Text = "Modificar Tempera";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.paleta[indice] = frm.TemperaDelForm;

                this.CargarListadoTemperas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstTemperas.SelectedIndex;

            if (indice == -1)
            {
                return;
            }

            FrmTempera frm = new FrmTempera(this.paleta[indice], true);
            frm.Text = "Eliminar Tempera";
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //con getter
                //this.paleta -= frm.ObtenerTempera();
                //con propiedad
                this.paleta -= frm.TemperaDelForm;

                this.CargarListadoTemperas();
            }
        }

        private void CargarListadoTemperas()
        {
            this.lstTemperas.Items.Clear();

            for (int i = 0; i < this.paleta.CantidadTemperas; i++)
            {
                this.lstTemperas.Items.Add(Tempera.Mostrar(this.paleta[i]));
            }
        }
    }
}
