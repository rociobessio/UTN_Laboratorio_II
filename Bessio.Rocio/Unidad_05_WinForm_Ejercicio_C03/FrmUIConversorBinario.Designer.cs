
namespace Unidad_05_WinForm_Ejercicio_C03
{
    partial class FrmUIConversorBinario
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
            this.lbBinADec = new System.Windows.Forms.Label();
            this.lbDecimalABin = new System.Windows.Forms.Label();
            this.txtDecIngresado = new System.Windows.Forms.TextBox();
            this.txBinIngresado = new System.Windows.Forms.TextBox();
            this.txtBinADecCovert = new System.Windows.Forms.TextBox();
            this.txtDecABinConvert = new System.Windows.Forms.TextBox();
            this.btnBinADec = new System.Windows.Forms.Button();
            this.btnDecABin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBinADec
            // 
            this.lbBinADec.AutoSize = true;
            this.lbBinADec.Location = new System.Drawing.Point(12, 38);
            this.lbBinADec.Name = "lbBinADec";
            this.lbBinADec.Size = new System.Drawing.Size(102, 15);
            this.lbBinADec.TabIndex = 0;
            this.lbBinADec.Text = "Binario a Decimal:";
            // 
            // lbDecimalABin
            // 
            this.lbDecimalABin.AutoSize = true;
            this.lbDecimalABin.Location = new System.Drawing.Point(12, 96);
            this.lbDecimalABin.Name = "lbDecimalABin";
            this.lbDecimalABin.Size = new System.Drawing.Size(102, 15);
            this.lbDecimalABin.TabIndex = 1;
            this.lbDecimalABin.Text = "Decimal a Binario:";
            // 
            // txtDecIngresado
            // 
            this.txtDecIngresado.Location = new System.Drawing.Point(143, 93);
            this.txtDecIngresado.Name = "txtDecIngresado";
            this.txtDecIngresado.Size = new System.Drawing.Size(100, 23);
            this.txtDecIngresado.TabIndex = 2;
            // 
            // txBinIngresado
            // 
            this.txBinIngresado.Location = new System.Drawing.Point(143, 35);
            this.txBinIngresado.Name = "txBinIngresado";
            this.txBinIngresado.Size = new System.Drawing.Size(100, 23);
            this.txBinIngresado.TabIndex = 3;
            // 
            // txtBinADecCovert
            // 
            this.txtBinADecCovert.Location = new System.Drawing.Point(408, 35);
            this.txtBinADecCovert.Name = "txtBinADecCovert";
            this.txtBinADecCovert.Size = new System.Drawing.Size(100, 23);
            this.txtBinADecCovert.TabIndex = 4;
            // 
            // txtDecABinConvert
            // 
            this.txtDecABinConvert.Location = new System.Drawing.Point(408, 94);
            this.txtDecABinConvert.Name = "txtDecABinConvert";
            this.txtDecABinConvert.Size = new System.Drawing.Size(100, 23);
            this.txtDecABinConvert.TabIndex = 5;
            // 
            // btnBinADec
            // 
            this.btnBinADec.Location = new System.Drawing.Point(289, 35);
            this.btnBinADec.Name = "btnBinADec";
            this.btnBinADec.Size = new System.Drawing.Size(75, 23);
            this.btnBinADec.TabIndex = 6;
            this.btnBinADec.Text = "->";
            this.btnBinADec.UseVisualStyleBackColor = true;
            this.btnBinADec.Click += new System.EventHandler(this.btnBinADec_Click);
            // 
            // btnDecABin
            // 
            this.btnDecABin.Location = new System.Drawing.Point(289, 96);
            this.btnDecABin.Name = "btnDecABin";
            this.btnDecABin.Size = new System.Drawing.Size(75, 23);
            this.btnDecABin.TabIndex = 7;
            this.btnDecABin.Text = "->";
            this.btnDecABin.UseVisualStyleBackColor = true;
            this.btnDecABin.Click += new System.EventHandler(this.btnDecABin_Click);
            // 
            // FrmUIConversorBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 156);
            this.Controls.Add(this.btnDecABin);
            this.Controls.Add(this.btnBinADec);
            this.Controls.Add(this.txtDecABinConvert);
            this.Controls.Add(this.txtBinADecCovert);
            this.Controls.Add(this.txBinIngresado);
            this.Controls.Add(this.txtDecIngresado);
            this.Controls.Add(this.lbDecimalABin);
            this.Controls.Add(this.lbBinADec);
            this.Name = "FrmUIConversorBinario";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCerrar);
            this.Load += new System.EventHandler(this.FrmUIConversorBinario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBinADec;
        private System.Windows.Forms.Label lbDecimalABin;
        private System.Windows.Forms.TextBox txtDecIngresado;
        private System.Windows.Forms.TextBox txBinIngresado;
        private System.Windows.Forms.TextBox txtBinADecCovert;
        private System.Windows.Forms.TextBox txtDecABinConvert;
        private System.Windows.Forms.Button btnBinADec;
        private System.Windows.Forms.Button btnDecABin;
    }
}

