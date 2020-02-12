using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.HelperFunctions
{
    public class Functions
    {
        public static int ObtenerMayor(IEnumerable<int> numeros)
        {
            int mayor = int.MinValue;
            foreach (int numero in numeros)
                if (numero > mayor)
                    mayor = numero;
            return mayor;
        }

        public static int ObtenerMenor(IEnumerable<int> numeros)
        {
            int menor = int.MaxValue;
            foreach (int numero in numeros)
                if (numero < menor)
                    menor = numero;
            return menor;
        }
    }
}
