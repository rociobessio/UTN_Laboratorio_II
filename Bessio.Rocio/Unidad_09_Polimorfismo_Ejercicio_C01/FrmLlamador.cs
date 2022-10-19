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
    public partial class FrmLlamador : Form
    {
        #region ATRIBUTOS
        Centralita centralita1;
        Random random;
        #endregion

        #region INICIAR FRM
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita1 = centralita;
            this.random = new Random();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cbFranja.Enabled = false;
            cbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));//Si la llamada es provincial cb pasa a ser disabled
            btnLlamar.Enabled = false;
            btnLimpiar.Enabled = false;

        }
        private void tbNroDestino_TextChanged(object sender, EventArgs e)
        {
            //Si el tbDestino arranca con #
            this.cbFranja.Enabled = (tbNroDestino.Text.StartsWith("#")) ? true : false;
        }

        private void tbNroOrigen_TextChanged(object sender, EventArgs e)
        {
            this.HabilitarBtn();
        }
        #endregion

        #region BOTONES (CONCATENO AL TEXT BOX LOS NUMEROS QUE TOQUE EN EL PANEL)
        private void btn1_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "1";
            this.HabilitarBtn();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "2";
            this.HabilitarBtn();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "3";
            this.HabilitarBtn();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "4";
            this.HabilitarBtn();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "5";
            this.HabilitarBtn();
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "6";
            this.HabilitarBtn();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "7";
            this.HabilitarBtn();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "8";
            this.HabilitarBtn();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "9";
            this.HabilitarBtn();
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "*";
            this.HabilitarBtn();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "0";
            this.HabilitarBtn();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text += "#";
            this.HabilitarBtn();
        }
        #endregion

        #region ACTIVAR BOTONES
        /// <summary>
        /// Habilito los botones Llamar y limpiar mediante un Metodo del Frm
        /// </summary>
        private void HabilitarBtn()
        {
            if (this.tbNroDestino.Text != "" && this.tbNroOrigen.Text != "")
            {
                btnLlamar.Enabled = true;
            }

            if (this.tbNroDestino.Text != "" || this.tbNroOrigen.Text != "")
            {
                btnLimpiar.Enabled = true;
            }
        }

        /// <summary>
        /// Se encarga de calcular la duracion y costos de la llamada dependiendo la franja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            float duracion = (float)random.Next(1,50);//La duracion se calcula de forma aleatoria
            if (this.cbFranja.Enabled)//Si la cb esta habilitada
            {
                Provincial.Franja franja;//variable del tipo Provincial.Franja
                Enum.TryParse<Provincial.Franja>(cbFranja.SelectedValue.ToString(), out franja);//Parseo lo del cb
                Provincial llamada = new Provincial(this.tbNroOrigen.Text,franja,duracion,this.tbNroDestino.Text);//Instancio ese nuevo objeto
                centralita1 = centralita1 + llamada;//Lo agrego a la lista
            }
            else
            {
                float costo = (float)random.Next(5,56)/10;
                Local llamada = new Local(this.tbNroOrigen.Text,duracion,this.tbNroDestino.Text,costo);
                centralita1 = centralita1 + llamada;
            }
            this.tbNroDestino.Text = "";
            this.tbNroOrigen.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.tbNroDestino.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
