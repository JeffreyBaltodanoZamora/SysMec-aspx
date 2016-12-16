using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// clase de conexion

public class clsConexion
{
    protected SqlDataReader reader; //para leer los datos que vayamos a usar
    protected SqlDataAdapter adaptador; //adaptar los datod
    protected DataSet data;
    protected SqlConnection aconexion = new SqlConnection();
    public clsConexion()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void conectar(string tabla){

        string strConeccion = ConfigurationManager.ConnectionStrings["BD_SysMecConnectionString"].ConnectionString;
        aconexion.ConnectionString = strConeccion;
        aconexion.Open();//abrimos coneccion
        adaptador = new SqlDataAdapter(" select * from " + tabla, aconexion);//hacer una consulta
        SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(adaptador);
        Data = new DataSet();
        adaptador.Fill(Data,tabla);
        aconexion.Close();//cerramos coneccion
    }
    public DataSet Data {
        set{ data = value; }
        get { return data; }
    }
    public SqlDataReader DataReader {
        set{ reader = value; }
        get { return reader; }
    }
}
