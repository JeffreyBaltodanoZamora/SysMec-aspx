<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="IndexCatalogos.aspx.cs" Inherits="IndexCatalogos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Página principal Catálogos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td rowspan="4">
                <img alt="" src="images/img/catalogos.jpg" style="width: 272px; height: 206px" /></td>
            <td>
                <a href="IndexExpedientes.aspx">Gestión de Expedientes</a>
            </td>
        </tr>
        <tr>
            <td>
                <a href="IndexCitas.aspx">Gestión de Citas</a>
            </td>
        </tr>
        <tr>
            <td>
                
                <a href="IndexUsuarios.aspx">Gestión Usuarios</a>
            </td>
        </tr>
        <tr>
            <td style="height: 146px">
                
                <a href="IndexHorarios.aspx">Horarios de servicio</a>
            </td>
        </tr>
    </table>
</asp:Content>

