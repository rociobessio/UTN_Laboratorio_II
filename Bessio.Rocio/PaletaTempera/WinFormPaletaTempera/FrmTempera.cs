﻿using System;
using System.Windows.Forms;
using MiBiblioteca;
//agregar using a las entidades


namespace WinFormPaletaTempera
{
    public partial class FrmTempera : Form
    {
        #region ATRIBUTOS
        private Tempera tempera;
        #endregion

        #region PROPIEDADES
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
        #endregion

        public FrmTempera()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(color);
            }

            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboColor.SelectedItem = ConsoleColor.DarkRed;
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
