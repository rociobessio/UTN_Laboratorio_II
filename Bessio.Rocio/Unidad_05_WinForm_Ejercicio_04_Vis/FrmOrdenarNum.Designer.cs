
namespace Unidad_05_WinForm_Ejercicio_04_Vis
{
    partial class FrmOrdenarNum
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ingresoNum = new System.Windows.Forms.GroupBox();
            this.txtNumIngresado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listaNumeros = new System.Windows.Forms.GroupBox();
            this.listBoxNum = new System.Windows.Forms.ListBox();
            this.ordenNum = new System.Windows.Forms.GroupBox();
            this.rBtnDesc = new System.Windows.Forms.RadioButton();
            this.rBtnAsc = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ingresoNum.SuspendLayout();
            this.listaNumeros.SuspendLayout();
            this.ordenNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingresoNum
            // 
            this.ingresoNum.Controls.Add(this.txtNumIngresado);
            this.ingresoNum.Controls.Add(this.btnAgregar);
            this.ingresoNum.Location = new System.Drawing.Point(12, 12);
            this.ingresoNum.Name = "ingresoNum";
            this.ingresoNum.Size = new System.Drawing.Size(239, 100);
            this.ingresoNum.TabIndex = 0;
            this.ingresoNum.TabStop = false;
            this.ingresoNum.Text = "Ingrese un nuevo número:";
            // 
            // txtNumIngresado
            // 
            this.txtNumIngresado.Location = new System.Drawing.Point(15, 40);
            this.txtNumIngresado.Name = "txtNumIngresado";
            this.txtNumIngresado.Size = new System.Drawing.Size(128, 23);
            this.txtNumIngresado.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(158, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listaNumeros
            // 
            this.listaNumeros.Controls.Add(this.listBoxNum);
            this.listaNumeros.Location = new System.Drawing.Point(292, 22);
            this.listaNumeros.Name = "listaNumeros";
            this.listaNumeros.Size = new System.Drawing.Size(208, 295);
            this.listaNumeros.TabIndex = 0;
            this.listaNumeros.TabStop = false;
            this.listaNumeros.Text = "Lista de números";
            // 
            // listBoxNum
            // 
            this.listBoxNum.FormattingEnabled = true;
            this.listBoxNum.ItemHeight = 15;
            this.listBoxNum.Location = new System.Drawing.Point(6, 22);
            this.listBoxNum.Name = "listBoxNum";
            this.listBoxNum.Size = new System.Drawing.Size(196, 259);
            this.listBoxNum.TabIndex = 4;
            // 
            // ordenNum
            // 
            this.ordenNum.Controls.Add(this.rBtnDesc);
            this.ordenNum.Controls.Add(this.rBtnAsc);
            this.ordenNum.Controls.Add(this.btnOrdenar);
            this.ordenNum.Location = new System.Drawing.Point(12, 132);
            this.ordenNum.Name = "ordenNum";
            this.ordenNum.Size = new System.Drawing.Size(239, 100);
            this.ordenNum.TabIndex = 0;
            this.ordenNum.TabStop = false;
            this.ordenNum.Text = "Orden números";
            // 
            // rBtnDesc
            // 
            this.rBtnDesc.AutoSize = true;
            this.rBtnDesc.Location = new System.Drawing.Point(15, 65);
            this.rBtnDesc.Name = "rBtnDesc";
            this.rBtnDesc.Size = new System.Drawing.Size(93, 19);
            this.rBtnDesc.TabIndex = 6;
            this.rBtnDesc.TabStop = true;
            this.rBtnDesc.Text = "Descendente";
            this.rBtnDesc.UseVisualStyleBackColor = true;
            // 
            // rBtnAsc
            // 
            this.rBtnAsc.AutoSize = true;
            this.rBtnAsc.Location = new System.Drawing.Point(15, 22);
            this.rBtnAsc.Name = "rBtnAsc";
            this.rBtnAsc.Size = new System.Drawing.Size(87, 19);
            this.rBtnAsc.TabIndex = 5;
            this.rBtnAsc.TabStop = true;
            this.rBtnAsc.Text = "Ascendente";
            this.rBtnAsc.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(158, 45);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 262);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(233, 55);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmOrdenarNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 329);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.ordenNum);
            this.Controls.Add(this.listaNumeros);
            this.Controls.Add(this.ingresoNum);
            this.Name = "FrmOrdenarNum";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdenamiento);
            this.Load += new System.EventHandler(this.FrmOrdenarNum_Load);
            this.ingresoNum.ResumeLayout(false);
            this.ingresoNum.PerformLayout();
            this.listaNumeros.ResumeLayout(false);
            this.ordenNum.ResumeLayout(false);
            this.ordenNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ingresoNum;
        private System.Windows.Forms.GroupBox listaNumeros;
        private System.Windows.Forms.GroupBox ordenNum;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNumIngresado;
        private System.Windows.Forms.ListBox listBoxNum;
        private System.Windows.Forms.RadioButton rBtnAsc;
        private System.Windows.Forms.RadioButton rBtnDesc;
    }
}

