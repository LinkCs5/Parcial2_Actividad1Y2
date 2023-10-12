using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.Domain
{
    internal class Filtro

    {
        public List<int> FiltrarPares(List<int> numeros)
        {
            List<int> pares = new List<int>();

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    pares.Add(numero);
                }
            }

            return pares;
        }

        public List<int> FiltrarImpares (List<int> numeros)
        {
            List<int> impares = new List<int> ();
            {
                foreach (int numero in numeros)
                {
                    if(numero %2 != 0)
                    {
                        impares.Add(numero);
                    }
                }
                return impares;
            }
        }
    }
}
