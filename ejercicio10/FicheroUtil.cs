using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    public class FicheroUtil
    {
        private static Boolean llamada = false;

        public void AlmacenarDatos(Object datos, string nombreFichero)
        {
            llamada = true;
            // TODO
            // throw new Exception('No implementado aun');
        }

        public static bool EsLlamada()
        {
            return llamada;
        }
    }
}
