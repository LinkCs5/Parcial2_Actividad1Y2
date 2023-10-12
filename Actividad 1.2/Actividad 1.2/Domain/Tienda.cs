using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_1._2.Domain;

namespace Actividad_1._2.Domain
{
    internal class Tienda
    {
        public List<Producto> ProductosDisponibles = new List<Producto>();
        public List<Producto> ProductosEliminados = new List<Producto>();

        public void AgregarProducto()
        {
            Producto nuevo = new Producto();
            Producto productoEncontrado = ProductosDisponibles.Find(x => x.Id == nuevo.Id);
            if (productoEncontrado == null)
            {
                ProductosDisponibles.Add(nuevo);

            }
            else
            {
                int index = ProductosDisponibles.FindIndex(x => x.Id == nuevo.Id);
                ProductosDisponibles[index].Cantidad++;
            }
        }

        public void QuitarProducto(int Id)
        {
            Producto productoEncontrado = ProductosDisponibles.Find(x=>x.Id == Id);
            if (productoEncontrado == null)
            {
                MessageBox.Show("Producto no encontrado");
            }
                
            else
            {
                int index = ProductosEliminados.FindIndex(p => p.Id == Id);
                if(index !=  -1)
                {
                    ProductosEliminados[index].Cantidad++;
                    int i = ProductosDisponibles.FindIndex(x => x.Id == Id);
                    ProductosDisponibles[i].Cantidad--;
                    if (ProductosDisponibles[i].Cantidad == 0)
                    {
                        
                        ProductosDisponibles.RemoveAt(i);

                    }
                    
               
                }
                else
                {
                    Producto copaiProducto = new Producto
                    {
                        Id = productoEncontrado.Id,
                        Nombre = productoEncontrado.Nombre,
                        Precio = productoEncontrado.Precio,
                        Cantidad = 1

                    };
                    ProductosEliminados.Add(copaiProducto);

                    int i = ProductosDisponibles.FindIndex(x => x.Id == Id);
                    ProductosDisponibles[i].Cantidad--;
                }
            }
        }
    }
}
