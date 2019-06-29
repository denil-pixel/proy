using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    public class Compras
    {
        public int ID { get; set; }
        public string  descripcion { get; set; }

        public decimal precioTotal { get; set; }
        public DateTime fecha { get; set; }
            public persona persona {get; set;}

    }
}
