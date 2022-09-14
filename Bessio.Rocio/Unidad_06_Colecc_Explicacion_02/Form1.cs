using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca;

namespace TestForm
{
    public partial class Form1 : Form
    {
        private Veterinaria veterinaria;
        private StringBuilder sb;
        public Form1()
        {
            InitializeComponent();
            this.veterinaria = new Veterinaria(5);
            this.txtVeterinaria.ReadOnly = true;

            this.sb = new StringBuilder();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgrega m = new FormAgrega();
            
            m.ShowDialog();

            if (m.DialogResult==DialogResult.OK)
            {
                if(this.veterinaria.Agregar(m.mascotita))
                {
                this.sb.AppendLine(m.mascotita.ToString());
                }else
                {
                    MessageBox.Show("No hay lugar");
                }

                this.refrescar(this.sb);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormElimina m = new FormElimina();

            if (m.ShowDialog() == DialogResult.OK)
            {
                if(this.veterinaria.Eliminar(m.mascotita))
                {
                    this.sb.Clear();
                    foreach (Mascota mascota in this.veterinaria.lista)
                    {
                        this.sb.AppendLine(mascota.ToString());
                    }

                }
                this.refrescar(this.sb);
                
            }

        }

        private void refrescar(StringBuilder sb)
        {
            this.txtVeterinaria.Text = sb.ToString();
        }
    }
}
