using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Telegrama : Form
    {
        public Telegrama()
        {
            InitializeComponent();
        }

        private string textoTelegrama;
        private char tipoTelegrama;
        private int numeroPalabras;
        public const string ERROR_CANTIDAD_NO_VALIDA = "Debe contener al menos una palabra.";
        public string TextoTelegrama
        {
            get => textoTelegrama;
            set => textoTelegrama = value;
        }
        public char TipoTelegrama
        {
            get => tipoTelegrama;
            set => tipoTelegrama = 'o';
        }
        public int NumeroPalabras
        {
            get => numeroPalabras;
            set => numeroPalabras = value;
        }

        /// <summary>
        /// Evento por el que se obtiene por formulario TextoTelegrama y tipoTelegrama
        /// </summary>
        /// <returns>Calcula y devuelve el coste del telegrama</returns>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double coste;

            TextoTelegrama = txtTelegrama.Text;
            NumeroPalabras = TextoTelegrama.Length;

            if(rbUrgente.Checked)
                TipoTelegrama = 'u';

            coste = CalcularCosteTelegrama(TipoTelegrama, NumeroPalabras);
            txtPrecio.Text = coste.ToString() + " euros";
        }

        /// <summary>
        /// Método que calcula el coste, según el tipoTelegrama.
        /// </summary>
        /// <param name="tipoTelegrama"></param>
        /// <param name="numeroPalabras"></param>
        /// <returns>Devuelve el coste del telegrama, tipo double</returns>
        /// <exception cref="ArgumentOutOfRangeException">Si se pasa un mensaje vacio, salta excepción</exception>
        public double CalcularCosteTelegrama(char tipoTelegrama, int numeroPalabras)
        {
            double coste = 0;

            if(numeroPalabras <= 0)
                throw new ArgumentOutOfRangeException(ERROR_CANTIDAD_NO_VALIDA);

            if(tipoTelegrama == 'o')
            {
                if(numeroPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + (0.5 * (numeroPalabras - 10));
            }
            else
                if(tipoTelegrama == 'u')
            {
                if(numeroPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + (0.75 * (numeroPalabras - 10));
            }
            return coste;
        }
    }
}
