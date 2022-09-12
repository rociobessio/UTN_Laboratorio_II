
namespace Unidad_05_WinForm_Ejercicio_C02
{
    partial class FrmVulcano
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
            this.lbFahrenheitA = new System.Windows.Forms.Label();
            this.lbCelsius = new System.Windows.Forms.Label();
            this.lbKelvinA = new System.Windows.Forms.Label();
            this.btnConvertFahrenhit = new System.Windows.Forms.Button();
            this.btnConvertCelsius = new System.Windows.Forms.Button();
            this.btnConvertKelvin = new System.Windows.Forms.Button();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrAKel = new System.Windows.Forms.TextBox();
            this.txtFahrenheitACelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsiusAFahr = new System.Windows.Forms.TextBox();
            this.txtCelAKelv = new System.Windows.Forms.TextBox();
            this.txtCelACel = new System.Windows.Forms.TextBox();
            this.txtKelvAKelv = new System.Windows.Forms.TextBox();
            this.txtKelACel = new System.Windows.Forms.TextBox();
            this.txtKelvinAFahr = new System.Windows.Forms.TextBox();
            this.lbFahrenheitB = new System.Windows.Forms.Label();
            this.lbCelsiusB = new System.Windows.Forms.Label();
            this.lbKelvinB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFahrenheitA
            // 
            this.lbFahrenheitA.AutoSize = true;
            this.lbFahrenheitA.Location = new System.Drawing.Point(24, 28);
            this.lbFahrenheitA.Name = "lbFahrenheitA";
            this.lbFahrenheitA.Size = new System.Drawing.Size(63, 15);
            this.lbFahrenheitA.TabIndex = 0;
            this.lbFahrenheitA.Text = "Fahrenheit";
            // 
            // lbCelsius
            // 
            this.lbCelsius.AutoSize = true;
            this.lbCelsius.Location = new System.Drawing.Point(24, 78);
            this.lbCelsius.Name = "lbCelsius";
            this.lbCelsius.Size = new System.Drawing.Size(44, 15);
            this.lbCelsius.TabIndex = 1;
            this.lbCelsius.Text = "Celsius";
            // 
            // lbKelvinA
            // 
            this.lbKelvinA.AutoSize = true;
            this.lbKelvinA.Location = new System.Drawing.Point(24, 125);
            this.lbKelvinA.Name = "lbKelvinA";
            this.lbKelvinA.Size = new System.Drawing.Size(39, 15);
            this.lbKelvinA.TabIndex = 2;
            this.lbKelvinA.Text = "Kelvin";
            // 
            // btnConvertFahrenhit
            // 
            this.btnConvertFahrenhit.Location = new System.Drawing.Point(275, 24);
            this.btnConvertFahrenhit.Name = "btnConvertFahrenhit";
            this.btnConvertFahrenhit.Size = new System.Drawing.Size(75, 23);
            this.btnConvertFahrenhit.TabIndex = 3;
            this.btnConvertFahrenhit.Text = "->";
            this.btnConvertFahrenhit.UseVisualStyleBackColor = true;
            this.btnConvertFahrenhit.Click += new System.EventHandler(this.btnConvertFahrenhit_Click);
            // 
            // btnConvertCelsius
            // 
            this.btnConvertCelsius.Location = new System.Drawing.Point(275, 74);
            this.btnConvertCelsius.Name = "btnConvertCelsius";
            this.btnConvertCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnConvertCelsius.TabIndex = 4;
            this.btnConvertCelsius.Text = "->";
            this.btnConvertCelsius.UseVisualStyleBackColor = true;
            this.btnConvertCelsius.Click += new System.EventHandler(this.btnConvertCelsius_Click);
            // 
            // btnConvertKelvin
            // 
            this.btnConvertKelvin.Location = new System.Drawing.Point(275, 121);
            this.btnConvertKelvin.Name = "btnConvertKelvin";
            this.btnConvertKelvin.Size = new System.Drawing.Size(75, 23);
            this.btnConvertKelvin.TabIndex = 5;
            this.btnConvertKelvin.Text = "->";
            this.btnConvertKelvin.UseVisualStyleBackColor = true;
            this.btnConvertKelvin.Click += new System.EventHandler(this.btnConvertKelvin_Click);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(131, 25);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtFahrenheit.TabIndex = 6;
            this.txtFahrenheit.TextChanged += new System.EventHandler(this.txtFahrenheit_TextChanged);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(131, 75);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 23);
            this.txtCelsius.TabIndex = 7;
            this.txtCelsius.TextChanged += new System.EventHandler(this.txtCelsius_TextChanged);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(131, 122);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtKelvin.TabIndex = 8;
            this.txtKelvin.TextChanged += new System.EventHandler(this.txtKelvin_TextChanged);
            // 
            // txtFahrAKel
            // 
            this.txtFahrAKel.Location = new System.Drawing.Point(716, 24);
            this.txtFahrAKel.Name = "txtFahrAKel";
            this.txtFahrAKel.Size = new System.Drawing.Size(100, 23);
            this.txtFahrAKel.TabIndex = 9;
            // 
            // txtFahrenheitACelsius
            // 
            this.txtFahrenheitACelsius.Location = new System.Drawing.Point(559, 24);
            this.txtFahrenheitACelsius.Name = "txtFahrenheitACelsius";
            this.txtFahrenheitACelsius.Size = new System.Drawing.Size(100, 23);
            this.txtFahrenheitACelsius.TabIndex = 10;
            // 
            // txtFahrenheitAFahrenheit
            // 
            this.txtFahrenheitAFahrenheit.Location = new System.Drawing.Point(403, 25);
            this.txtFahrenheitAFahrenheit.Name = "txtFahrenheitAFahrenheit";
            this.txtFahrenheitAFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtFahrenheitAFahrenheit.TabIndex = 11;
            // 
            // txtCelsiusAFahr
            // 
            this.txtCelsiusAFahr.Location = new System.Drawing.Point(403, 74);
            this.txtCelsiusAFahr.Name = "txtCelsiusAFahr";
            this.txtCelsiusAFahr.Size = new System.Drawing.Size(100, 23);
            this.txtCelsiusAFahr.TabIndex = 12;
            // 
            // txtCelAKelv
            // 
            this.txtCelAKelv.Location = new System.Drawing.Point(716, 74);
            this.txtCelAKelv.Name = "txtCelAKelv";
            this.txtCelAKelv.Size = new System.Drawing.Size(100, 23);
            this.txtCelAKelv.TabIndex = 13;
            // 
            // txtCelACel
            // 
            this.txtCelACel.Location = new System.Drawing.Point(559, 74);
            this.txtCelACel.Name = "txtCelACel";
            this.txtCelACel.Size = new System.Drawing.Size(100, 23);
            this.txtCelACel.TabIndex = 14;
            // 
            // txtKelvAKelv
            // 
            this.txtKelvAKelv.Location = new System.Drawing.Point(716, 122);
            this.txtKelvAKelv.Name = "txtKelvAKelv";
            this.txtKelvAKelv.Size = new System.Drawing.Size(100, 23);
            this.txtKelvAKelv.TabIndex = 15;
            // 
            // txtKelACel
            // 
            this.txtKelACel.Location = new System.Drawing.Point(559, 122);
            this.txtKelACel.Name = "txtKelACel";
            this.txtKelACel.Size = new System.Drawing.Size(100, 23);
            this.txtKelACel.TabIndex = 16;
            this.txtKelACel.TextChanged += new System.EventHandler(this.txtKelACel_TextChanged);
            // 
            // txtKelvinAFahr
            // 
            this.txtKelvinAFahr.Location = new System.Drawing.Point(403, 122);
            this.txtKelvinAFahr.Name = "txtKelvinAFahr";
            this.txtKelvinAFahr.Size = new System.Drawing.Size(100, 23);
            this.txtKelvinAFahr.TabIndex = 17;
            // 
            // lbFahrenheitB
            // 
            this.lbFahrenheitB.AutoSize = true;
            this.lbFahrenheitB.Location = new System.Drawing.Point(424, 7);
            this.lbFahrenheitB.Name = "lbFahrenheitB";
            this.lbFahrenheitB.Size = new System.Drawing.Size(63, 15);
            this.lbFahrenheitB.TabIndex = 18;
            this.lbFahrenheitB.Text = "Fahrenheit";
            // 
            // lbCelsiusB
            // 
            this.lbCelsiusB.AutoSize = true;
            this.lbCelsiusB.Location = new System.Drawing.Point(580, 7);
            this.lbCelsiusB.Name = "lbCelsiusB";
            this.lbCelsiusB.Size = new System.Drawing.Size(44, 15);
            this.lbCelsiusB.TabIndex = 19;
            this.lbCelsiusB.Text = "Celsius";
            // 
            // lbKelvinB
            // 
            this.lbKelvinB.AutoSize = true;
            this.lbKelvinB.Location = new System.Drawing.Point(742, 7);
            this.lbKelvinB.Name = "lbKelvinB";
            this.lbKelvinB.Size = new System.Drawing.Size(39, 15);
            this.lbKelvinB.TabIndex = 20;
            this.lbKelvinB.Text = "Kelvin";
            // 
            // FrmVulcano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 162);
            this.Controls.Add(this.lbKelvinB);
            this.Controls.Add(this.lbCelsiusB);
            this.Controls.Add(this.lbFahrenheitB);
            this.Controls.Add(this.txtKelvinAFahr);
            this.Controls.Add(this.txtKelACel);
            this.Controls.Add(this.txtKelvAKelv);
            this.Controls.Add(this.txtCelACel);
            this.Controls.Add(this.txtCelAKelv);
            this.Controls.Add(this.txtCelsiusAFahr);
            this.Controls.Add(this.txtFahrenheitAFahrenheit);
            this.Controls.Add(this.txtFahrenheitACelsius);
            this.Controls.Add(this.txtFahrAKel);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.btnConvertKelvin);
            this.Controls.Add(this.btnConvertCelsius);
            this.Controls.Add(this.btnConvertFahrenhit);
            this.Controls.Add(this.lbKelvinA);
            this.Controls.Add(this.lbCelsius);
            this.Controls.Add(this.lbFahrenheitA);
            this.Name = "FrmVulcano";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmVulcano_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFahrenheitA;
        private System.Windows.Forms.Label lbCelsius;
        private System.Windows.Forms.Label lbKelvinA;
        private System.Windows.Forms.Button btnConvertFahrenhit;
        private System.Windows.Forms.Button btnConvertCelsius;
        private System.Windows.Forms.Button btnConvertKelvin;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtFahrAKel;
        private System.Windows.Forms.TextBox txtFahrenheitACelsius;
        private System.Windows.Forms.TextBox txtFahrenheitAFahrenheit;
        private System.Windows.Forms.TextBox txtCelsiusAFahr;
        private System.Windows.Forms.TextBox txtCelAKelv;
        private System.Windows.Forms.TextBox txtCelACel;
        private System.Windows.Forms.TextBox txtKelvAKelv;
        private System.Windows.Forms.TextBox txtKelACel;
        private System.Windows.Forms.TextBox txtKelvinAFahr;
        private System.Windows.Forms.Label lbFahrenheitB;
        private System.Windows.Forms.Label lbCelsiusB;
        private System.Windows.Forms.Label lbKelvinB;
    }
}

