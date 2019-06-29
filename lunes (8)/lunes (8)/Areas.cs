using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lunes__8_
{
    class Areas
    {
        public int Base { set; get; }
        public int Altura { get; set; }
        public Areas()
        {

        }
        public Areas (Int32 b ,Int32 a)
        {
            Base = b;
            Altura = a;
        }
        public Int32 Rectangulo()
        {
            return Base * Altura;

        }
        public Single Triangulo()
        {
            return Base * Altura / 2;
        }
    }
}
