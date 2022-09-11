using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *                          Guía de ejercicios básicos con Windows Forms
                        --------------------------------------------------
Controles:
#GroupBoxes
#TextBoxes
#ListBox
#Buttons
#RadioButton
            Elabore una aplicación que permita agregar los números ingresados en el TextBox
            txtNumero a un ListBox (lstNumeros), al presionar el botón btnAgregar y los ordene
            según el criterio de  ordenamiento (al pulsar el botón btnOrdenar). El btnLimpiar, se
            encargará de restablecer los valores de todos los controles (recorrer la propiedad Controls del
            formulario y “limpiar” los TextBoxes, RadioButtons y ListBox).
 */
namespace Unidad_05_WinForm_Ejercicio_04_Vis
{
    public partial class FrmOrdenarNum : Form
    {
        public FrmOrdenarNum()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmOrdenarNum_Load(object sender, EventArgs e)
        {
            this.Text = "Ordenamiento";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
             listBoxNum.Items.Clear();
             txtNumIngresado.Text = "";
             rBtnAsc.Checked = false;
             rBtnDesc.Checked = false;
            /* foreach (var item in this.listBoxNum.Controls)//Limpio con el foreach las 3 text box del form
             {
                 if (item.GetType() == typeof(ListBox))
                 {
                     ListBox t1 = item as ListBox;
                    t1.Items.Clear();
                 }
             }*/
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int auxiliarNum;

            if(rBtnAsc.Checked == true)
            {
                for(int i = 0; i < this.listBoxNum.Items.Count - 1; i++)
                {
                    for(int j= i + 1; j<this.listBoxNum.Items.Count;j++)
                    {
                        if (int.Parse(listBoxNum.Items[i].ToString()) < int.Parse(listBoxNum.Items[j].ToString()))
                        {
                            auxiliarNum = int.Parse(this.listBoxNum.Items[i].ToString());
                            this.listBoxNum.Items[i] = this.listBoxNum.Items[j];
                            this.listBoxNum.Items[j] = auxiliarNum;
                        }
                    }
                }
            }

            if (rBtnDesc.Checked == true)
            {
                for (int i = 0; i < this.listBoxNum.Items.Count - 1; i++)
                {
                    for (int j = i + 1; j < this.listBoxNum.Items.Count; j++)
                    {
                        if (int.Parse(listBoxNum.Items[i].ToString()) > int.Parse(listBoxNum.Items[j].ToString()))
                        {
                            auxiliarNum = int.Parse(this.listBoxNum.Items[i].ToString());
                            this.listBoxNum.Items[i] = this.listBoxNum.Items[j];
                            this.listBoxNum.Items[j] = auxiliarNum;
                        }
                    }
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numeroIngresado = txtNumIngresado.Text.ToString();

            listBoxNum.Items.Add(numeroIngresado);
        }

        private void frmOrdenamiento(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea finalizar la aplicacion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
