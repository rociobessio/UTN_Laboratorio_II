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
    public partial class FrmMenu : Form
    {
        Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent(); this.Text = "Central Telefonica";
            this.centralita = new Centralita("Saltamonte");

            Local l1 = new Local("3452345", 30, "23452345", (float)2.65);
            Local l1b = l1;
            Provincial l2 = new Provincial("53452345", Provincial.Franja.Franja_1, 15, "#546745634");
            Local l3 = new Local("6785678", 40, "6345346", (float)2.65);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            this.centralita = centralita + l1;
            this.centralita = centralita + l1b;
            this.centralita = centralita + l2;
            this.centralita = centralita + l3;
            this.centralita = centralita + l4;
        }

        private void btnGnrLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(this.centralita);
            frmLlamador.ShowDialog();//Si presiona generar abro un form de forma Modal
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.centralita);//Le paso la centralita
            frmMostrar.Tipo = Llamada.TipoLlamada.Todas;//El tipo de llamada asigo todas
            frmMostrar.ShowDialog();//Lo muestro de forma modal
        }

        private void btnFacturaLocacl_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.centralita);//Le paso la centralita
            frmMostrar.Tipo = Llamada.TipoLlamada.Local;//El tipo de llamada asigo todas
            frmMostrar.ShowDialog();//Lo muestro de forma modal
        }

        private void btnFacturacionProv_Click(object sender, EventArgs e)
        {

            FrmMostrar frmMostrar = new FrmMostrar(this.centralita);//Le paso la centralita
            frmMostrar.Tipo = Llamada.TipoLlamada.Provincial;//El tipo de llamada asigo todas
            frmMostrar.ShowDialog();//Lo muestro de forma modal
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
