using modelo.nativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace insertar_editar_borrar_listar.modelo
{
    class juego
    {
        private string tabla;
          public int id { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public string descripcion { get; set; }
        public string foto { get; set; }
        public int categoria { get; set; }
        public int estado {get;set;}
        DBModelo conexion;
        public juego(){
            conexion = new DBModelo();
            tabla = "tbjuego";
        }
       public bool insert(){
            conexion.open();
            conexion.query("insert into "+tabla+"(nombre,genero,descripcion,foto,categoria)"+
                "values ('@nombre','@genero','@descripcion','@foto',@categoria)");
            conexion.close();
            return true;
        }
    }
}
