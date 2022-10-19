
namespace Unidad_09_Polimorfismo_Ejercicio_C01
{
    partial class FrmMenu
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
            this.btnGnrLlamada = new System.Windows.Forms.Button();
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            this.btnFacturaLocacl = new System.Windows.Forms.Button();
            this.btnFacturacionProv = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGnrLlamada
            // 
            this.btnGnrLlamada.Location = new System.Drawing.Point(46, 39);
            this.btnGnrLlamada.Name = "btnGnrLlamada";
            this.btnGnrLlamada.Size = new System.Drawing.Size(199, 36);
            this.btnGnrLlamada.TabIndex = 0;
            this.btnGnrLlamada.Text = "Generar LLamada";
            this.btnGnrLlamada.UseVisualStyleBackColor = true;
            this.btnGnrLlamada.Click += new System.EventHandler(this.btnGnrLlamada_Click);
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.Location = new System.Drawing.Point(46, 102);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(199, 35);
            this.btnFacturacionTotal.TabIndex = 1;
            this.btnFacturacionTotal.Text = "Facturar Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = true;
            this.btnFacturacionTotal.Click += new System.EventHandler(this.btnFacturacionTotal_Click);
            // 
            // btnFacturaLocacl
            // 
            this.btnFacturaLocacl.Location = new System.Drawing.Point(46, 157);
            this.btnFacturaLocacl.Name = "btnFacturaLocacl";
            this.btnFacturaLocacl.Size = new System.Drawing.Size(199, 32);
            this.btnFacturaLocacl.TabIndex = 2;
            this.btnFacturaLocacl.Text = "Facturacion Local";
            this.btnFacturaLocacl.UseVisualStyleBackColor = true;
            this.btnFacturaLocacl.Click += new System.EventHandler(this.btnFacturaLocacl_Click);
            // 
            // btnFacturacionProv
            // 
            this.btnFacturacionProv.Location = new System.Drawing.Point(46, 208);
            this.btnFacturacionProv.Name = "btnFacturacionProv";
            this.btnFacturacionProv.Size = new System.Drawing.Size(199, 35);
            this.btnFacturacionProv.TabIndex = 3;
            this.btnFacturacionProv.Text = "Facturacion Provincial";
            this.btnFacturacionProv.UseVisualStyleBackColor = true;
            this.btnFacturacionProv.Click += new System.EventHandler(this.btnFacturacionProv_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(46, 261);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(199, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 312);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturacionProv);
            this.Controls.Add(this.btnFacturaLocacl);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Controls.Add(this.btnGnrLlamada);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGnrLlamada;
        private System.Windows.Forms.Button btnFacturacionTotal;
        private System.Windows.Forms.Button btnFacturaLocacl;
        private System.Windows.Forms.Button btnFacturacionProv;
        private System.Windows.Forms.Button btnSalir;
    }
}

