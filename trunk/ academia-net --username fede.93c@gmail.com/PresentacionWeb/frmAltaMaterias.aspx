<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmAltaMaterias.aspx.cs" Inherits="frmAltaMaterias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style9">
                <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="140px" 
                    OnClick="btnGuardar_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                     <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

