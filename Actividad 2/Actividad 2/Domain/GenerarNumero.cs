using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.Domain
{
    internal class GenerarNumero
    {
        private Random ramdom = new Random();
        public List<int> GenerarNumeros (int cantidad)
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < cantidad; i++)
            {
                numeros.Add(ramdom.Next(1, 101)); // Genera números aleatorios del 1 al 100
            }

            return numeros;
        }
    }
}
