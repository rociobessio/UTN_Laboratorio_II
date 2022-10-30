using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unidad_14_Archivos_Ejercicio_I03
{
    public partial class FrmNotepad : Form
    {
        #region ATRIBUTOS
        private OpenFileDialog openFileDialog; //Abrir archivp
        private SaveFileDialog saveFileDialog; // Guardar el archivo
        private string archivo;
        #endregion

        #region PROPIEDAD DE ARCHIVOS
        private string ultimoArchivo {  get { return this.ultimoArchivo; } set { if (!string.IsNullOrWhiteSpace(value)) { this.ultimoArchivo = value; } } }
        #endregion

        #region INSTANCIAR FORM
        public FrmNotepad()
        {
            InitializeComponent();

            //Instancio los obj
            this.openFileDialog = new OpenFileDialog();
            this.saveFileDialog = new SaveFileDialog();
        }

        private void FrmNotepad_Load(object sender, EventArgs e)
        {
            this.Text = "Siempre quise un Notepad";
            this.rbContent.Text = "# Caracteres";
        }
        #endregion
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void FrmNotepad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /// <summary>
        /// Atajos del FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNotepad_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A) && e.Control) //Abrir: Ctrl + A
            {
               // this.abrirToolStrip(sender,e);
            }
            else if ((e.KeyCode == Keys.S) && e.Control)//Guardar: Ctrl + S
            {

            }
            else if ((e.KeyCode == Keys.S && e.KeyCode == Keys.Shift) && e.Control) //Guardar como..: Ctrl + Shift + S
            {

            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void rbContent_TextChanged(object sender, EventArgs e)
        {
            stripStatusLabelCaracteres.Text = $"{ rbContent.Text.Length} caracteres.";
        }

        #region BOTONES TOOL STRIP
        /// <summary>
        /// Al pulsar "Abrir" se debra abrir una ventana para seleccionar el archivo a abrir.
        /// Mostrar el contenido del archivo en el RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirToolStrip_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                try // Busco una EXCEPCION EN CASO DE QUE EXITA ERROR AL ABRIR EL ARCHIVO
                {
                    this.archivo = openFileDialog.FileName;//Lo que hago es guardar en archivo el NOMBRE DE ESTE

                    using StreamReader streamReader = new StreamReader(archivo) ; //Creo un StreamReader con el contenido de archivo.

                    rbContent.Text = streamReader.ReadToEnd();//LEEMOS TODO EL CONTENIDO.
                }
                catch (Exception ex)//Atrapa la excepcion en caso de que ocurra una
                {
                   MostrarError(ex); //Muestro el menssaje de error mediante el metodo creado
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivo))//Si el archivo EXISTE...
            {
                this.archivo = SeleccionarRutaPath();
            }
            this.GuardarArchivo(this.archivo);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.archivo = SeleccionarRutaPath();
            this.GuardarArchivo(this.archivo);
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Muestra un mensaje de excepcion si lo hay
        /// </summary>
        /// <param name="e"></param>
        private void MostrarError(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ERROR: {e.Message}");
            sb.AppendLine($"Detalles : {e.StackTrace}");
            MessageBox.Show(sb.ToString(), "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
        }

        /// <summary>
        /// Para seleccionar aquella ruta donde se guardara el archivo,
        /// </summary>
        /// <returns></returns>
        private string SeleccionarRutaPath()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return string.Empty;
        }

        /// <summary>
        /// Sirve para guardar el path del archivo
        /// </summary>
        /// <param name="path"></param>
        private void GuardarArchivo(string path)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(path))//Se fija que path no sea null o que no contenga nada
                {
                    using StreamWriter streamWriter = new StreamWriter(archivo);
                    streamWriter.Write(rbContent.Text);//Escribo lo que esta en ek rich box
                }
            }
            catch (Exception e)
            {
                this.MostrarError(e);//Muestro el error
            }
        }
        #endregion


    }
}
