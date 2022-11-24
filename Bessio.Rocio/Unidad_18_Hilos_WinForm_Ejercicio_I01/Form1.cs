using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;

namespace Unidad_18_Hilos_WinForm_Ejercicio_I01
{
    public partial class Form1 : Form
    {

        #region ATRIBUTOS
        private CancellationTokenSource cancellation;
        private CancellationToken cancellationToken;
        private Task t;
        #endregion

        public Form1()
        {
            InitializeComponent();
            this.cancellation = new CancellationTokenSource();
            this.cancellationToken = cancellation.Token;
            this.ActualizarHoraConHilos();
        }

        #region METODOS
        /// <summary>
        /// De forma iterativa con un do-while se ira actualizando el lblHora cada un segundo siempre y cuando sea true.
        /// </summary>
        public void ActualizarHoraIterativa()
        {
            do
            {
                this.AsignarHora();//Invoco al metodo de asignar la hora
                Thread.Sleep(1000);//Actualizo cada 1 segundo
            } while (true);
        } 

        /// <summary>
        /// Se encarga de imprimir la hora en el lblHora
        /// </summary>
        public void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)//Me fijo si invoque al hilo 
            {
                Action delegado = new Action(AsignarHora);
                this.lblHora.Invoke(delegado);//Invoco al delegado
            }
            else//Si no...
            {
                this.lblHora.Text = DateTime.Now.ToString();//Imprimo en el lbl la fecha.
            }
        }

        /// <summary>
        /// Agregar un control de Windows Forms de tipo Timer, configurarlo para refrescar la hora actual cada 1 segundo usando su evento Tick.
        /// </summary>
        public void AsignarHoraConTimer()
        {
            this.AsignarHora();
        }

        public void ActualizarHoraConHilos()
        {
            this.t = Task.Run(() => 
            {
                do
                {
                    AsignarHora();
                    Thread.Sleep(1000);
                } while (true);
            });
        }
        #endregion

    }
}
