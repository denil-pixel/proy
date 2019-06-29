using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
     public class persona
    {
       private string nombre;
        public string Nombre { get; set; }
        //variable
        //<|>propiedad
        public string apellidos { get; set; }
        int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string fullName
        {
            get
            {
                return nombre + " " + apellidos;
            }
        }
        
            public List<Compras> lista {get;set;}
         //   public decimal Total {
           //     get
             //   {
               //     decimal to = 0;
                 //   for (int i = 0; i < lista.Count; i++)
                   // {
                     //   to += lista[i].precioTotal;
                    //}
                      //  return to;
                //}  
            
            
            //}
        //para sumar los precios
            public decimal Total1
           {
                get
                {
                   // uso de linqu
           return lista.Sum(a => a.precioTotal);
                }
          }
    }
}
