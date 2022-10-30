
namespace Unidad_16_SQL_Ejercicio_I01_WinForm
{
    partial class FrmMenuCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCrud));
            this.groupBoxContainer = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPersonas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.groupBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxContainer
            // 
            this.groupBoxContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxContainer.BackgroundImage")));
            this.groupBoxContainer.Controls.Add(this.btnHelp);
            this.groupBoxContainer.Controls.Add(this.label1);
            this.groupBoxContainer.Controls.Add(this.dataGridPersonas);
            this.groupBoxContainer.Controls.Add(this.btnModificar);
            this.groupBoxContainer.Controls.Add(this.btnBorrar);
            this.groupBoxContainer.Controls.Add(this.btnGuardar);
            this.groupBoxContainer.Controls.Add(this.btnLeer);
            this.groupBoxContainer.Controls.Add(this.txtNombre);
            this.groupBoxContainer.Controls.Add(this.txtApellido);
            this.groupBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxContainer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxContainer.Name = "groupBoxContainer";
            this.groupBoxContainer.Size = new System.Drawing.Size(871, 362);
            this.groupBoxContainer.TabIndex = 0;
            this.groupBoxContainer.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.Thistle;
            this.btnHelp.Location = new System.Drawing.Point(6, 333);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseMnemonic = false;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(372, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "MENU CRUD";
            // 
            // dataGridPersonas
            // 
            this.dataGridPersonas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonas.Location = new System.Drawing.Point(77, 113);
            this.dataGridPersonas.Name = "dataGridPersonas";
            this.dataGridPersonas.RowTemplate.Height = 25;
            this.dataGridPersonas.Size = new System.Drawing.Size(727, 184);
            this.dataGridPersonas.TabIndex = 7;
            this.dataGridPersonas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dobleClickModificar);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.Thistle;
            this.btnModificar.Location = new System.Drawing.Point(501, 312);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 38);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.Thistle;
            this.btnBorrar.Location = new System.Drawing.Point(696, 312);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 38);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.Thistle;
            this.btnGuardar.Location = new System.Drawing.Point(311, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 38);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeer.BackColor = System.Drawing.Color.Transparent;
            this.btnLeer.FlatAppearance.BorderSize = 0;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeer.ForeColor = System.Drawing.Color.Thistle;
            this.btnLeer.Location = new System.Drawing.Point(104, 312);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(93, 38);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(192, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingresa el Nombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.Location = new System.Drawing.Point(527, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingresa el Apellido";
            this.txtApellido.Size = new System.Drawing.Size(139, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // FrmMenuCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(871, 362);
            this.Controls.Add(this.groupBoxContainer);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FrmMenuCrud";
            this.Text = "MENU CRUD";
            this.groupBoxContainer.ResumeLayout(false);
            this.groupBoxContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContainer;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.DataGridView dataGridPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelp;
    }
}