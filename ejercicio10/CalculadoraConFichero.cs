using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    public class CalculadoraConFichero
    {
        public ICalculadora calculadora
        {
            get;
            set;
        }

        public IFicheroService ficheroService { get; set; }

        public void SumarGuardando(int a, int b)
        {
            int c = new Calculadora().Sumar(a, b);

            ficheroService.GuardarNumero(c);
        }
    }
}
