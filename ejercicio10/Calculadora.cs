using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    public class Calculadora : ICalculadora
    {
        /// <summary>
        /// Metodo de suma de dos numeros enteros
        /// </summary>
        /// <param name="a">Primer numero</param>
        /// <param name="b">Segundo numero</param>
        /// <returns>La suma de ambos</returns>
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
