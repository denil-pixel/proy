using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace Formulario_Validado
{
    public class Validacion
    {
        static public long num { get; set; }
        static public bool isLetras(string cadena)
        {
            for (int i = 0; i < cadena.Length;i++ )
            {
                if (!char.IsLetter(cadena[i]))
                {
                    return false;
                }
            }
           // return true;
            int ii = 0;
            while (ii < cadena.Length && char.IsLetter(cadena[ii++])) ;
            return ii >= cadena.Length;
            
              
        }
        static public bool isEntero(string x)
        {
            long aux;
            
            bool t=long.TryParse(x, out aux);
            num = aux;
            return t;
        }
        static public bool isEmail(string x)
        {
            try
            {
                MailAddress v = new MailAddress(x);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
