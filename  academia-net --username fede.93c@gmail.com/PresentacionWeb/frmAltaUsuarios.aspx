<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmAltaUsuarios.aspx.cs" Inherits="frmAltaMaterias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 93px;
        }
        .style2
        {
            width: 93px;
            height: 26px;
        }
        .style3
        {
            height: 26px;
        }
        .style4
        {
            width: 434px;
        }
        .style5
        {
            width: 167px;
        }
        .style6
        {
            width: 168px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4">
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td colspan="2">
                <asp:GridView ID="dgvPersonas" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                    </Columns>
                    <SelectedRowStyle BackColor="#CCCC00" />
                </asp:GridView>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label>
            </td>
            <td class="style3" colspan="2">
                <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style5">
                <asp:Button ID="btnGuardar" runat="server" onclick="btnGuardar_Click1" 
                    Text="Guardar" />
            </td>
            <td class="style6">
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                    onclick="btnCancelar_Click" />
            </td>
        </tr>
        </table>
</asp:Content>

