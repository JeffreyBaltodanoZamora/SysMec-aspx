<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="indexHorarios.aspx.cs" Inherits="indexHorarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td rowspan="2">
                <img alt="Horarios de Servicio" src="images/img/horarios.png" style="width: 275px; height: 183px" /></td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Mostrar Horarios"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <a href="CrearHorarios.aspx">Crear Nuevo Horario de Servicio</a>
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

