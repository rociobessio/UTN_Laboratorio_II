﻿
namespace Unidad_17_Delegados_Ejercicio_I01
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTestDeDelegados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.toolStripMenuMostrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripTestDeDelegados,
            this.toolStripMenuAlumnos});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // menuStripTestDeDelegados
            // 
            this.menuStripTestDeDelegados.Name = "menuStripTestDeDelegados";
            this.menuStripTestDeDelegados.Size = new System.Drawing.Size(168, 22);
            this.menuStripTestDeDelegados.Text = "Test de Delegados";
            this.menuStripTestDeDelegados.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuAlumnos
            // 
            this.toolStripMenuAlumnos.Name = "toolStripMenuAlumnos";
            this.toolStripMenuAlumnos.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuAlumnos.Text = "Alumnos";
            this.toolStripMenuAlumnos.Click += new System.EventHandler(this.toolStripMenuAlumnos_Click);
            // 
            // toolStripMenuMostrar
            // 
            this.toolStripMenuMostrar.Name = "toolStripMenuMostrar";
            this.toolStripMenuMostrar.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuMostrar.Text = "Mostrar";
            this.toolStripMenuMostrar.Click += new System.EventHandler(this.toolStripMenuMostrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 362);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripTestDeDelegados;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuMostrar;
    }
}

