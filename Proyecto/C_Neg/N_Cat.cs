using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using C_Dat;
using System.Data;
using System.Data.SqlClient;
using C_Neg;

namespace C_Neg
{
public class N_Cat
    {
        
        public static string Insertar(string nombre, string descripcion)
        {
            D_Categoria_Productos Obj = new D_Categoria_Productos();
            Obj.Nombre1 = nombre;
            Obj.Descripcion1 = descripcion;
            return  Obj.Insertar(Obj);
        }
      
        public static string Editar(int idcategoria, string nombre, string descripcion)
        {
            D_Categoria_Productos Obj = new D_Categoria_Productos();
            Obj.Idcategoria1 = idcategoria;
            Obj.Nombre1 = nombre;
            Obj.Descripcion1 = descripcion;
            return Obj.Editar(Obj);
        }

        
        public static string Eliminar(int idcategoria)
        {
            D_Categoria_Productos Obj = new D_Categoria_Productos();
            Obj.Idcategoria1 = idcategoria;
            return Obj.Eliminar(Obj);
        }

      
        public static DataTable Mostrar()
        {
            return new D_Categoria_Productos().Mostrar();
        }
    public static DataTable BuscarNombre(string textobuscar)
        {
            D_Categoria_Productos Obj = new D_Categoria_Productos();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

      
    }
}
    
