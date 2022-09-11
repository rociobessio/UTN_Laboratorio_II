
namespace Unidad_05_WinForm_Ejercicio_03_Vis
{
    partial class FrmDescuento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtValorCobrar = new System.Windows.Forms.TextBox();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.lbDescuentoRecibido = new System.Windows.Forms.Label();
            this.lbvalorIngresado = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalPagar);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.txtValorCobrar);
            this.groupBox1.Controls.Add(this.lbTotalPagar);
            this.groupBox1.Controls.Add(this.lbDescuentoRecibido);
            this.groupBox1.Controls.Add(this.lbvalorIngresado);
            this.groupBox1.Location = new System.Drawing.Point(36, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(162, 163);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPagar.TabIndex = 6;
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(162, 98);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtDescuento.TabIndex = 5;
            // 
            // txtValorCobrar
            // 
            this.txtValorCobrar.Location = new System.Drawing.Point(162, 32);
            this.txtValorCobrar.Name = "txtValorCobrar";
            this.txtValorCobrar.Size = new System.Drawing.Size(100, 23);
            this.txtValorCobrar.TabIndex = 2;
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPagar.Location = new System.Drawing.Point(6, 162);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(105, 20);
            this.lbTotalPagar.TabIndex = 4;
            this.lbTotalPagar.Text = "Total a pagar:";
            // 
            // lbDescuentoRecibido
            // 
            this.lbDescuentoRecibido.AutoSize = true;
            this.lbDescuentoRecibido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescuentoRecibido.Location = new System.Drawing.Point(6, 99);
            this.lbDescuentoRecibido.Name = "lbDescuentoRecibido";
            this.lbDescuentoRecibido.Size = new System.Drawing.Size(124, 17);
            this.lbDescuentoRecibido.TabIndex = 3;
            this.lbDescuentoRecibido.Text = "Descuento recibido:";
            // 
            // lbvalorIngresado
            // 
            this.lbvalorIngresado.AutoSize = true;
            this.lbvalorIngresado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbvalorIngresado.Location = new System.Drawing.Point(6, 33);
            this.lbvalorIngresado.Name = "lbvalorIngresado";
            this.lbvalorIngresado.Size = new System.Drawing.Size(147, 17);
            this.lbvalorIngresado.TabIndex = 2;
            this.lbvalorIngresado.Text = "Ingrese valor a cobrar:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(56, 272);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(209, 272);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 307);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDescuento";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDescuento_FormClosing);
            this.Load += new System.EventHandler(this.FrmDescuento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbvalorIngresado;
        private System.Windows.Forms.Label lbDescuentoRecibido;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.TextBox txtValorCobrar;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotalPagar;
    }
}

