using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ejemploValidaciones
{
    public class ValidarDatos
    {
        static public long num { get; set; }

        static public bool isLetras(string cadena) {
          //  for (int i = 0; i < cadena.Length; i++)
          //  {
              //  if (!char.IsLetter(cadena[i])) {
             //       return false;
             //   }
           // }
           // return true;
           int ii = 0;
            while (ii < cadena.Length &&
               (char.IsLetter(cadena[ii]) || cadena[ii] == ' ')) ii++;
            return ii >= cadena.Length;
        }
     
       

    }
}
