using Actividad_2.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class Form1 : Form
    {
        private Filtro filtro = new Filtro();
        private GenerarNumero generarNumero = new GenerarNumero();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGenerarNumeros_Click(object sender, EventArgs e)
        {

            int cantidadNumeros;
            if (int.TryParse(textBox1.Text, out cantidadNumeros))
            {
                List<int> numeros = generarNumero.GenerarNumeros(cantidadNumeros);
                List<int> pares = filtro.FiltrarPares(numeros);
                List<int> impares = filtro.FiltrarImpares(numeros);

                lstPares.Items.Clear();
                lstPares.Items.AddRange(pares.Select(n => n.ToString()).ToArray());

                lstImpares.Items.Clear();
                lstImpares.Items.AddRange(impares.Select(n => n.ToString()).ToArray());

            }
            else
            {
                MessageBox.Show("Escribe un numero valido.");
            }
            textBox1.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
