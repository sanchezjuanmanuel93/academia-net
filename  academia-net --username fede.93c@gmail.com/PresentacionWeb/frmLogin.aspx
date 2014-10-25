<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            width: 77px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:60%;">
    <tr>
        <td class="auto-style4">
            <asp:Label ID="Label1" runat="server" Text="Usuario" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUsuario" runat="server" Width="209px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Label ID="Label2" runat="server" Text="Contraseña" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtContraseña" runat="server" Width="209px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="#2F9DC4"></asp:Label>
        </td>
        <td>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Width="219px" Font-Bold="False" OnClick="btnIngresar_Click" />
        </td>
    </tr>
</table>
</asp:Content>

