using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// clase horarioservicio

public class clsHorarioServicio : clsConexion
{
    string tablaHorarios = "Cat_HorarioServicio"; //nombre de la tabla
    protected string t_HoraInicio, t_HoraFinal, vc_DiaServicio;
    protected int i_Fk_idMedico;
  
    public clsHorarioServicio(int i_Fk_idMedico,string t_HoraInicio,string t_HoraFinal,string vc_DiaServicio)
    {
        this.i_Fk_idMedico = i_Fk_idMedico;
        this.t_HoraInicio = t_HoraInicio;
        this.t_HoraFinal = t_HoraFinal;
        this.vc_DiaServicio = vc_DiaServicio;
    }
    //sets y gets

    public int idmedico
    {
        set { i_Fk_idMedico = value; }
        get { return i_Fk_idMedico; }
    }

    public string inicio
    {
        set { t_HoraInicio = value; }
        get { return t_HoraInicio; }
    }
    public string final
    {
        set { t_HoraFinal = value; }
        get { return t_HoraFinal; }
    }
    public string dia
    {
        set { vc_DiaServicio = value; }
        get { return vc_DiaServicio; }
    }

    //metodo agregar

    public void agregarHorario() {
        conectar(tablaHorarios);//abre coneccion
        DataRow fila;//creamos nuevo registro de fila
        fila = data.Tables[tablaHorarios].NewRow();//creamos una nueva fila de instancia de la tabla horarios
        fila["i_Fk_idMedico"] = idmedico;//agregamos los registros
        fila["t_HoraInicio"] = inicio;
        fila["t_HoraFinal"] = final;
        fila["vc_DiaServicio"] = dia;

        data.Tables[tablaHorarios].Rows.Add(fila);//agregamos la fila al dataset
        adaptador.Update(data, tablaHorarios);//actualizamos
    }
    

    //metodo eliminar
    public bool eliminarHorario(int valor) {
        conectar(tablaHorarios);
        DataRow fila;
        int x = data.Tables[tablaHorarios].Rows.Count - 1;
        for(int i=0; i <=x; i++) {
            fila = data.Tables[tablaHorarios].Rows[i];

            if(int.Parse(fila["i_Fk_idMedico"].ToString())==valor) {
                fila = data.Tables[tablaHorarios].Rows[i];
                fila.Delete();
                DataTable datosHorariosEliminados;
                datosHorariosEliminados = data.Tables[tablaHorarios].GetChanges(DataRowState.Deleted);
                adaptador.Update(datosHorariosEliminados);
                data.Tables[tablaHorarios].AcceptChanges();
                return true;
            }
            }
        return false;
    }

    //metodo buscar
    public bool buscar(int valor) {
        conectar(tablaHorarios);
        DataRow fila;
        int x = data.Tables[tablaHorarios].Rows.Count - 1;

        for(int i=0; i <=x; i++) {
            fila = data.Tables[tablaHorarios].Rows[i];

            if (int.Parse(fila["i_Fk_idMedico"].ToString()) == valor)
            {
                idmedico = int.Parse(fila["i_Fk_idMedico"].ToString());
                inicio = fila["t_HoraInicio"].ToString();
                final =  fila["t_HoraFinal"].ToString();
                dia   = fila["vc_DiaServicio"].ToString();
                return true;
            }
        }return false;


    }

}