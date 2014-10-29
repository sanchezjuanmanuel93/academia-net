<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmAltaPersona.aspx.cs" Inherits="frmAltaPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 157px;
        }
        .style2
        {
            width: 157px;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table style="width:100%;">
        <tr>
            <td class="style1">
                <asp:Label ID="Label1" runat="server" Text="Legajo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLegajo" runat="server" Height="22px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label5" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label6" runat="server" Text="Tipo"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlTipo" runat="server" DataSourceID="odsTipo" 
                    DataTextField="Descripcion" DataValueField="tipo">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="odsTipo" runat="server" SelectMethod="getTipos" 
                    TypeName="Negocio.ControladorPersonas"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                    onclick="btnCancelar_Click" />
            </td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" onclick="btnGuardar_Click" 
                    Text="Guardar" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                
            </td>
        </tr>
    </table>

</asp:Content>

