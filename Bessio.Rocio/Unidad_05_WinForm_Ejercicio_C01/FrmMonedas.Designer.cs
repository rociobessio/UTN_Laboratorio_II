
namespace Unidad_05_WinForm_Ejercicio_C01
{
    partial class FrmMonedas
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
            this.lbCotizacion = new System.Windows.Forms.Label();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.lbPesoA = new System.Windows.Forms.Label();
            this.lbDolarA = new System.Windows.Forms.Label();
            this.lbEuroA = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.lbEuroB = new System.Windows.Forms.Label();
            this.lbDolarB = new System.Windows.Forms.Label();
            this.lbPesoB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCotizacion
            // 
            this.lbCotizacion.AutoSize = true;
            this.lbCotizacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCotizacion.Location = new System.Drawing.Point(41, 26);
            this.lbCotizacion.Name = "lbCotizacion";
            this.lbCotizacion.Size = new System.Drawing.Size(64, 15);
            this.lbCotizacion.TabIndex = 0;
            this.lbCotizacion.Text = "Cotización";
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.Location = new System.Drawing.Point(237, 22);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(75, 23);
            this.btnLockCotizacion.TabIndex = 1;
            this.btnLockCotizacion.Text = "Locked";
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(351, 23);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionEuro.TabIndex = 2;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(478, 23);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionDolar.TabIndex = 3;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(602, 23);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionPeso.TabIndex = 4;
            // 
            // lbPesoA
            // 
            this.lbPesoA.AutoSize = true;
            this.lbPesoA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPesoA.Location = new System.Drawing.Point(41, 170);
            this.lbPesoA.Name = "lbPesoA";
            this.lbPesoA.Size = new System.Drawing.Size(33, 15);
            this.lbPesoA.TabIndex = 5;
            this.lbPesoA.Text = "Peso";
            // 
            // lbDolarA
            // 
            this.lbDolarA.AutoSize = true;
            this.lbDolarA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDolarA.Location = new System.Drawing.Point(41, 128);
            this.lbDolarA.Name = "lbDolarA";
            this.lbDolarA.Size = new System.Drawing.Size(37, 15);
            this.lbDolarA.TabIndex = 6;
            this.lbDolarA.Text = "Dolar";
            // 
            // lbEuroA
            // 
            this.lbEuroA.AutoSize = true;
            this.lbEuroA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEuroA.Location = new System.Drawing.Point(41, 80);
            this.lbEuroA.Name = "lbEuroA";
            this.lbEuroA.Size = new System.Drawing.Size(32, 15);
            this.lbEuroA.TabIndex = 7;
            this.lbEuroA.Text = "Euro";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(101, 77);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 23);
            this.txtEuro.TabIndex = 8;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(101, 125);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolar.TabIndex = 9;
            this.txtDolar.TextChanged += new System.EventHandler(this.txtDolar_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(101, 167);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPeso.TabIndex = 10;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(237, 72);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 11;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(237, 120);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 12;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(237, 166);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPeso.TabIndex = 13;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(351, 162);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtPesoAEuro.TabIndex = 14;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(351, 120);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtDolarAEuro.TabIndex = 15;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(351, 73);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtEuroAEuro.TabIndex = 16;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(478, 72);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 23);
            this.txtEuroADolar.TabIndex = 17;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(478, 162);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 23);
            this.txtPesoADolar.TabIndex = 18;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(478, 120);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolarADolar.TabIndex = 19;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(602, 120);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtDolarAPeso.TabIndex = 21;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(602, 72);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtEuroAPeso.TabIndex = 22;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(602, 162);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPesoAPeso.TabIndex = 23;
            // 
            // lbEuroB
            // 
            this.lbEuroB.AutoSize = true;
            this.lbEuroB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEuroB.Location = new System.Drawing.Point(383, 55);
            this.lbEuroB.Name = "lbEuroB";
            this.lbEuroB.Size = new System.Drawing.Size(32, 15);
            this.lbEuroB.TabIndex = 24;
            this.lbEuroB.Text = "Euro";
            // 
            // lbDolarB
            // 
            this.lbDolarB.AutoSize = true;
            this.lbDolarB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDolarB.Location = new System.Drawing.Point(508, 55);
            this.lbDolarB.Name = "lbDolarB";
            this.lbDolarB.Size = new System.Drawing.Size(37, 15);
            this.lbDolarB.TabIndex = 25;
            this.lbDolarB.Text = "Dolar";
            // 
            // lbPesoB
            // 
            this.lbPesoB.AutoSize = true;
            this.lbPesoB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPesoB.Location = new System.Drawing.Point(636, 55);
            this.lbPesoB.Name = "lbPesoB";
            this.lbPesoB.Size = new System.Drawing.Size(33, 15);
            this.lbPesoB.TabIndex = 26;
            this.lbPesoB.Text = "Peso";
            // 
            // FrmMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 209);
            this.Controls.Add(this.lbPesoB);
            this.Controls.Add(this.lbDolarB);
            this.Controls.Add(this.lbEuroB);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lbEuroA);
            this.Controls.Add(this.lbDolarA);
            this.Controls.Add(this.lbPesoA);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.lbCotizacion);
            this.Name = "FrmMonedas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMonedas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCotizacion;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.Label lbPesoA;
        private System.Windows.Forms.Label lbDolarA;
        private System.Windows.Forms.Label lbEuroA;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.Label lbEuroB;
        private System.Windows.Forms.Label lbDolarB;
        private System.Windows.Forms.Label lbPesoB;
    }
}

