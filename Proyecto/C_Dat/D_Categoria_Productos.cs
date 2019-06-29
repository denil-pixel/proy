using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using C_Dat;
namespace C_Dat
{
   public  class D_Categoria_Productos
    {
        private int _Idcategoria;
        private string _Nombre;
        private string _Descripcion;
        private string _TextoBuscar;

    

        
        
     
      public int Idcategoria1
{
  get { return _Idcategoria; }
  set { _Idcategoria = value; }
}
       public string Nombre1
{
  get { return _Nombre; }
  set { _Nombre = value; }
}
       public string Descripcion1
{
  get { return _Descripcion; }
  set { _Descripcion = value; }
}

       public string TextoBuscar
       {
           get { return _TextoBuscar; }
           set { _TextoBuscar = value; }
       }

     
           

    
    public D_Categoria_Productos()
    {

    }

    
    public D_Categoria_Productos(int idcategoria,string nombre,string descripcion,string textobuscar)
    {
      
      this.Idcategoria1 = idcategoria;
      this.Nombre1 = nombre;
      this.Descripcion1 = descripcion;
      this.TextoBuscar = textobuscar;
    }

   



    public string Insertar(D_Categoria_Productos Categoria)
    {
        string Rpta = "";
        SqlConnection SqlCon = new SqlConnection();
        try
        {
            
            SqlCon.ConnectionString = Conexion.Cn;
           
            SqlCon.Open();
         
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "spinsertar_categoria";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            
            SqlParameter ParIdcategoria = new SqlParameter();
            ParIdcategoria.ParameterName = "@idcategoria";
            ParIdcategoria.SqlDbType = SqlDbType.Int;
      
            ParIdcategoria.Direction = ParameterDirection.Output;
            SqlCmd.Parameters.Add(ParIdcategoria);
           


          
            SqlParameter ParNombre = new SqlParameter();
            ParNombre.ParameterName = "@nombre";
            ParNombre.SqlDbType = SqlDbType.VarChar;
            ParNombre.Size = 50;
            ParNombre.Value = Categoria.Nombre1;
            SqlCmd.Parameters.Add(ParNombre);
            
            SqlParameter ParDescripcion = new SqlParameter();
            ParDescripcion.ParameterName = "@descripcion";
            ParDescripcion.SqlDbType = SqlDbType.VarChar;
            ParDescripcion.Size = 256;
            ParDescripcion.Value = Categoria.Descripcion1;
            SqlCmd.Parameters.Add(ParDescripcion); 
            
            Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro de forma correcta";

        }
        catch (Exception ex)
        {
            Rpta = ex.Message;
           
        }
        finally
        {
            
            if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        }
        return Rpta;
    }


 
    public string Editar(D_Categoria_Productos Categoria)
    {
        string Rpta = "";
        SqlConnection SqlCon = new SqlConnection();
        try
        {
          
            SqlCon.ConnectionString = Conexion.Cn;
           
            SqlCon.Open();
         
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "spEditar_Categoria";
            SqlCmd.CommandType = CommandType.StoredProcedure;

         
            SqlParameter ParIdcategoria = new SqlParameter();
            ParIdcategoria.ParameterName = "@idcategoria";
            ParIdcategoria.SqlDbType = SqlDbType.Int;
            ParIdcategoria.Value = Categoria.Idcategoria1;
            SqlCmd.Parameters.Add(ParIdcategoria);
         
            SqlParameter ParNombre = new SqlParameter();
            ParNombre.ParameterName = "@nombre";
            ParNombre.SqlDbType = SqlDbType.VarChar;
            ParNombre.Size = 100;
            ParNombre.Value = Categoria.Nombre1;
            SqlCmd.Parameters.Add(ParNombre);
            
            SqlParameter ParDescripcion = new SqlParameter();
            ParDescripcion.ParameterName = "@descripcion";
            ParDescripcion.SqlDbType = SqlDbType.VarChar;
            ParDescripcion.Size = 256;
            ParDescripcion.Value = Categoria.Descripcion1;
            SqlCmd.Parameters.Add(ParDescripcion);
         
            Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro de forma correcta";

        }
        catch (Exception ex)
        {
            Rpta = ex.Message;

        }
        finally
        {
  
            if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        }
        return Rpta;
    }

    public string Eliminar(D_Categoria_Productos Categoria)
    {
        string Rpta = "";
        SqlConnection SqlCon = new SqlConnection();
        try
        {
           
            SqlCon.ConnectionString = Conexion.Cn;
         
            SqlCon.Open();
         
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "speliminar_categoria";
            SqlCmd.CommandType = CommandType.StoredProcedure;

           
            SqlParameter ParIdcategoria = new SqlParameter();
            ParIdcategoria.ParameterName = "@idcategoria";
            ParIdcategoria.SqlDbType = SqlDbType.Int;
            ParIdcategoria.Value = Categoria.Idcategoria1;
            SqlCmd.Parameters.Add(ParIdcategoria);
  
            Rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

        }
        catch (Exception ex)
        {
            Rpta = ex.Message;
        }
        finally
        {
        
            if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        }
        return Rpta;
    }




    //Método utilizado para obtener todas las categorías de la base de datos
    public DataTable Mostrar()
    {
        DataTable DtResultado = new DataTable("categoria");
        SqlConnection SqlCon = new SqlConnection();
        try
        {
            // Establecer la cadena de conexion
            SqlCon.ConnectionString = Conexion.Cn;

        
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;//La conexión que va a usar el comando
            SqlCmd.CommandText = "spmostrar_categoria";//El comando a ejecutar
            SqlCmd.CommandType = CommandType.StoredProcedure;
            //De al comando que va a ejecutar una sentencia SQL

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);//Llenamos el DataTable
        }
        catch (Exception ex)
        {
            DtResultado = null;
           
        }
        return DtResultado;
    }

    public DataTable BuscarNombre(D_Categoria_Productos Categoria)
    {
        DataTable DtResultado = new DataTable("categoria");
        SqlConnection SqlCon = new SqlConnection();
        try
        {
           
            SqlCon.ConnectionString = Conexion.Cn;

            
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "spBuscar_Categoria_Nombre";//El comando a ejecutar
            SqlCmd.CommandType = CommandType.StoredProcedure;
            

            //nviamos wl parámetro de Búsqueda
            SqlParameter ParTextoBuscar = new SqlParameter();
            ParTextoBuscar.ParameterName = "@TextoBuscare";
            ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
            ParTextoBuscar.Size = 50;
            ParTextoBuscar.Value = Categoria.TextoBuscar;
            SqlCmd.Parameters.Add(ParTextoBuscar);

            
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
        }
        catch (Exception ex)
        {
            DtResultado = null;

        }
        return DtResultado;
    }
    }

}

   
