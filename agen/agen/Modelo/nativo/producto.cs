using Modelo.nativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace agen.Modelo.nativo
{
    class producto
    {
          public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public string cantidad { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public int precio { get; set; }
        private string tabla;
        public producto() {

            tabla = "productos";
        }
        public bool Add()
        {
            //....
            return true;
        }
        public bool Add(DBModelo conexion) {
            conexion.open();
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "nombre", Value = nombre });
            datos.Add(new SqlParameter() { ParameterName = "categoria", Value = categoria });
            datos.Add(new SqlParameter() { ParameterName = "cantidad", Value = cantidad });
            datos.Add(new SqlParameter() { ParameterName = "fecha_vencimiento", Value = fecha_vencimiento });
            datos.Add(new SqlParameter() { ParameterName = "precio", Value = precio });

            int? x=conexion.querySimple("insert into " + tabla + "(nombre,categoria,cantidad,fecha_vencimiento,precio) " +
                "values (@nombre,@categoria,@cantidad,@fecha_vencimiento,@precio)", datos);
            conexion.close();
            return x>0 || x == null ? true:false;
        }
        public List<producto> Select(DBModelo conexion)
        {
            conexion.open();
            DataTable t = conexion.query("select * from  " + tabla + " where estado=1 "
                    , null);
            conexion.close();
            List<producto> lista = new List<producto>();
         //   for (int i = 0; i < t.Rows.Count; i++)
           // {
         //       lista.Add(new producto()
             //   {
         

            return lista;
        }
        /*public bool Edit(DBModelo conexion)
        {
            conexion.open();
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "nombre", Value = nombre });
            datos.Add(new SqlParameter() { ParameterName = "cantidad", Value = cantidad });
            datos.Add(new SqlParameter() { ParameterName = "id", Value = id });

            int? x = conexion.querySimple("update " + tabla + " set nombre=@nombre,cantidad=@cantidad " +
               "where id=@id", datos);
            conexion.close();
            return x > 0 ||x==null ? true : false;
        }
        public bool Delete(DBModelo conexion)
        {
            conexion.open();
            List<SqlParameter> datos = new List<SqlParameter>();
            datos.Add(new SqlParameter() { ParameterName = "id", Value = id });

            int? x = conexion.querySimple("update " + tabla + " set estado=0 " +
               "where id=@id", datos);
            conexion.close();
            return x > 0 || x == null ? true : false;
        }*/

      
    }
}
