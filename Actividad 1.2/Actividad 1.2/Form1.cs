using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Actividad_1._2.Domain;

namespace Actividad_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tienda tienda = new Tienda();

        private void buttonAgregarP_Click(object sender, EventArgs e) 
        {
            tienda.AgregarProducto();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            listBoxDisponibles.Items.Clear();
            listBoxRetirados.Items.Clear();
            listBoxDisponibles.Visible = true;
            listBoxRetirados.Visible = true;
            List<Producto> productoDisponible = tienda.ProductosDisponibles;
            foreach(var producto in productoDisponible)
            {
                listBoxDisponibles.Items.Add($"ID: {producto.Id},Nombre:{producto.Nombre}, Precio: ${producto.Precio}, Cantidad: {producto.Cantidad}");
            }
            List<Producto> productosRetirados = tienda.ProductosEliminados;
            foreach(var producto in productosRetirados)
            {
                listBoxRetirados.Items.Add($"ID: {producto.Id}, Nombre:{producto.Nombre}, Precio: ${producto.Precio}, Cantidad: {producto.Cantidad}");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(textBox1.Text);
            tienda.QuitarProducto(Id);
        }
    }
}
