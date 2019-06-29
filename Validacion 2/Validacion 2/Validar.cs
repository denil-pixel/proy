using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validacion_2
{
    class Validar
    {
        static public long num { get; set; }
       
        //   public class Validacion
        // {
   
        static public bool isEntero(string x)
        {
            long aux;

            bool t = long.TryParse(x, out aux);
            num = aux;
            return t;
        }

    }
}
