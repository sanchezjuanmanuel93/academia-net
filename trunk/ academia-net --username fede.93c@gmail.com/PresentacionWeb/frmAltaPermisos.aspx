<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmAltaPermisos.aspx.cs" Inherits="frmAltaPermisos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    <asp:Label ID="lblUsuarios" runat="server" Text="Usuarios"></asp:Label>
                </td>
                <td class="style1">
                    <asp:DropDownList ID="ddlUsuarios" runat="server" Height="16px" 
                        onselectedindexchanged="ddlUsuarios_SelectedIndexChanged" Width="176px" 
                        AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblModulos" runat="server" Text="Modulos"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="ddlModulos" runat="server" Height="16px" Width="173px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
                        onclick="btnGuardar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        onclick="btnCancelar_Click" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style1
        {
            height: 54px;
        }
        .style2
        {
            height: 61px;
        }
    </style>
</asp:Content>


