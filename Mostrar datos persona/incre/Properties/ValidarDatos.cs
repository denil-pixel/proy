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
            //for (int i = 0; i < cadena.Length; i++)
            //{
                //if (!char.IsLetter(cadena[i])) {
                //    return false;
              //  }
            //}
           // return true;
            int ii = 0;
            while (ii < cadena.Length &&
                (char.IsLetter(cadena[ii]) || cadena[ii] == ' ')) ii++;
            return ii >= cadena.Length;
        }
        static public bool isEntero(string x) {
            long aux;
            bool t=long.TryParse(x, out aux);
            num = aux;
            return t;
        }
        static public bool isEmail(string x) {
            try
            {
                MailAddress v = new MailAddress(x);
                return true;
            }
            catch  {
                return false;
            }
        }
        static public bool isCi(string x) {
            string []datos=x.Split('-');
            if (!isEntero(datos[0]))
                return false;
            if (num < 100000 || num > 99999999)
                return false;
            if (datos.Length > 1) {
                if (char.IsDigit(datos[1][0]) && char.IsLetter(datos[1][1]))   //1t
                    return true;
                else return false;
            }
            return true;
        }

    }
}
