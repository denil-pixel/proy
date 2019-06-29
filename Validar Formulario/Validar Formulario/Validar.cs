using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validar_Formulario
{
    class Validar
    {
        static public long num { get; set; }
        static public bool isEntero(string x)
        {
            long aux;
            bool t = long.TryParse(x, out aux);
            num = aux;
            return t;
        }
        static public bool isCi(string x)
        {
            string[] datos = x.Split('-');
            if (!isEntero(datos[0]))
                return false;
            if (num < 100000 || num > 99999999)
                return false;
            if (datos.Length > 1)
            {
                if (char.IsDigit(datos[1][0]) && char.IsLetter(datos[1][1]))   //1t
                    return true;
                else return false;
            }
            return true;
        }
        static public bool isIp(string x)
        {
            string[] datos = x.Split('.');
            if (!isEntero(datos[0]))
                return false;
            if (num >= 1 && num <= 255)
                return true;
            if (datos.Length > 3)
            {
                if (char.IsDigit(datos[1][0]) && char.IsDigit(datos[1][1])  && char.IsDigit(datos[1][2]) && char.IsDigit(datos[1][3])) //1t
                    return true;
                else return false;
            }
            return true;
        }
    
    }
}
