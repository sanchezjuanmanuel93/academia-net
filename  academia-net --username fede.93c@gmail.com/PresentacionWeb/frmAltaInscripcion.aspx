<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmAltaInscripcion.aspx.cs" Inherits="frmAltaInscripcion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 95px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style9">
                <asp:Label ID="Label1" runat="server" Text="Materia"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cmbMaterias" runat="server" Height="24px" Width="143px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="140px" OnClick="btnGuardar_Click" />
            </td>
        </tr>        
    </table>
</asp:Content>

