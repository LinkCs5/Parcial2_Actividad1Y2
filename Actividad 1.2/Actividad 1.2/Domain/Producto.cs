using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1._2.Domain
{
    internal class Producto
    {
        public int Id { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; } 

        Random random = new Random();
        public Producto()
        {
            Id = random.Next(1, 11);
            Precio = random.Next(50, 100);
            Cantidad = random.Next(1, 50);
            Nombre = "Producto " + Id.ToString();
        }
    }
}
