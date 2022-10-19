
namespace Unidad_09_Polimorfismo_Ejercicio_C01
{
    partial class FrmLlamador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNroOrigen = new System.Windows.Forms.TextBox();
            this.tbNroDestino = new System.Windows.Forms.TextBox();
            this.cbFranja = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNroOrigen
            // 
            this.tbNroOrigen.Location = new System.Drawing.Point(211, 135);
            this.tbNroOrigen.Name = "tbNroOrigen";
            this.tbNroOrigen.Size = new System.Drawing.Size(130, 23);
            this.tbNroOrigen.TabIndex = 0;
            this.tbNroOrigen.Text = "Nro. Origen";
            this.tbNroOrigen.TextChanged += new System.EventHandler(this.tbNroOrigen_TextChanged);
            // 
            // tbNroDestino
            // 
            this.tbNroDestino.Location = new System.Drawing.Point(24, 29);
            this.tbNroDestino.Name = "tbNroDestino";
            this.tbNroDestino.Size = new System.Drawing.Size(347, 23);
            this.tbNroDestino.TabIndex = 1;
            this.tbNroDestino.Text = "Nro. Destino";
            this.tbNroDestino.TextChanged += new System.EventHandler(this.tbNroDestino_TextChanged);
            // 
            // cbFranja
            // 
            this.cbFranja.FormattingEnabled = true;
            this.cbFranja.Location = new System.Drawing.Point(24, 307);
            this.cbFranja.Name = "cbFranja";
            this.cbFranja.Size = new System.Drawing.Size(347, 23);
            this.cbFranja.TabIndex = 2;
            this.cbFranja.Text = "Franja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btnAsterisco);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btnNumeral);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLlamar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.tbNroOrigen);
            this.groupBox1.Location = new System.Drawing.Point(24, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 214);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(55, 38);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(39, 34);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(100, 38);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(39, 34);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(11, 162);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(39, 33);
            this.btnAsterisco.TabIndex = 15;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(56, 164);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(38, 31);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(101, 162);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(38, 33);
            this.btnNumeral.TabIndex = 13;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(11, 123);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(39, 35);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(56, 123);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(38, 35);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(101, 123);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(38, 35);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(11, 78);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(39, 37);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(56, 78);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(38, 37);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(100, 77);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(39, 37);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(11, 38);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(39, 34);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(211, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(211, 38);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(130, 23);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "btnLlamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(211, 91);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbFranja);
            this.Controls.Add(this.tbNroDestino);
            this.Name = "FrmLlamador";
            this.Text = "FrmLlamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNroOrigen;
        private System.Windows.Forms.TextBox tbNroDestino;
        private System.Windows.Forms.ComboBox cbFranja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}