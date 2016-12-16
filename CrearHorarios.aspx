<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CrearHorarios.aspx.cs" Inherits="pageUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table style="width: 100%">
        <tr>
            <td colspan="2"><h1> Horarios de Servicio  </h1> </td>
        </tr>
        <tr>
            <td style="width: 251px">
                <asp:Label ID="Label1" runat="server" Text="id medico"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td style="width: 251px">
                <asp:Label ID="Label2" runat="server" Text="hora inicio"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtinicio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 251px">
                <asp:Label ID="Label3" runat="server" Text="hora final"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtfinal" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 251px">
                <asp:Label ID="Label4" runat="server" Text="dia de servicio"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdia" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 251px">
                <asp:Label ID="lblestado" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
            &nbsp;&nbsp;
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
            </td>
        </tr>
    </table>
    
</asp:Content>

