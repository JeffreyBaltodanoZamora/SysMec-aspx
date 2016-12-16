using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        //creamos una instancia de la clase horariosServicios
        //try
        //{
        //    //clsHorarioServicio horariosServicios = new clsHorarioServicio(0, "", "", "");
        //    //horariosServicios.idmedico = int.Parse(txtId.Text.Trim());
        //    //horariosServicios.inicio = txtinicio.Text;
        //    //horariosServicios.final = txtfinal.Text;
        //    //horariosServicios.dia = txtdia.Text;
        //    //horariosServicios.agregarHorario();
        //    //lblestado.Text = "Horario de servicio insertado correctamente";
        //    //limpiarHoararios();
        //}

        //catch { lblestado.Text = "Error al ingresar horario"; }
    }

    protected void limpiarHoararios()
    {
        //txtId.Text = " ";
        //txtinicio.Text = " ";
        //txtfinal.Text = " ";
        //txtdia.Text = " ";
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        //clsHorarioServicio horariosServicios = new clsHorarioServicio(0, "", "", "");
        //if (horariosServicios.eliminarHorario(int.Parse(txtId.Text)))
        //{

        //    lblestado.Text = "se ha eliminado correctamente";
        //    limpiarHoararios();
        //}
        //else
        //    lblestado.Text = "Ha ocurrido un error al eliminar el registro";
    }

    protected void BtnBuscar_Click(object sender, EventArgs e)
    {
        //clsHorarioServicio horariosServicios = new clsHorarioServicio(0, "", "", "");

        //if (horariosServicios.buscar(int.Parse(txtId.Text)))
        //{

        //    txtinicio.Text = horariosServicios.inicio;
        //    txtfinal.Text = horariosServicios.final;
        //    txtdia.Text = horariosServicios.dia;
        //    lblestado.Text = "la cedula del medico existe";

        //}
        //else
        //    lblestado.Text = "la cedula del medico NO existe";


    }
}