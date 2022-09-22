using System;
using System.Windows.Forms;
using MiBiblioteca;//agregar using a las entidades



namespace WinFormsAppTest
{
    public partial class FrmTempera : Form
    {
        private Tempera tempera;

        //Getter
        public Tempera ObtenerTempera()
        {
            return this.tempera;
        }
        //Propiedad de sólo lectura
        public Tempera TemperaDelForm
        {
            get
            {
                return this.tempera;
            }
        }

        public FrmTempera()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(color);
            }

            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboColor.SelectedItem = ConsoleColor.DarkRed;
        }

        public FrmTempera(Tempera obj) : this()
        {
            this.txtCantidad.Text = ((int)obj).ToString();
            this.txtMarca.Text = obj.Marca;
            this.cboColor.SelectedItem = obj.Color;

            //No se editan
            this.txtMarca.ReadOnly = true;
            this.cboColor.Enabled = false;
        }

        public FrmTempera(Tempera obj, bool cantidadSoloLectura) : this(obj)
        {
            this.txtCantidad.ReadOnly = cantidadSoloLectura;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.tempera = new Tempera((ConsoleColor)this.cboColor.SelectedItem, this.txtMarca.Text, int.Parse(this.txtCantidad.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
