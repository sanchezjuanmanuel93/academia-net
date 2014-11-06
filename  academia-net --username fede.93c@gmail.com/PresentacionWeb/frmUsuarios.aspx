<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmUsuarios.aspx.cs" Inherits="frmUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            height: 30px;
        }
        .auto-style10 {
            height: 30px;
            width: 437px;
        }
        .auto-style11 {
            height: 30px;
            width: 188px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 283px">
        <asp:GridView ID="grvUsuarios" runat="server" AutoGenerateColumns="False" 
            DataSourceID="odsUsuarios" CellPadding="4" ForeColor="#333333" GridLines="None" Width="457px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField 
                    ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Usu" HeaderText="Usuario" SortExpression="Usu" />
                <asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" 
                    SortExpression="Legajo" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="odsUsuarios" runat="server" 
            DataObjectTypeName="Entidades.Usuario" DeleteMethod="eliminarUsuario" 
            InsertMethod="agregarUsuario" SelectMethod="getUsuarios" 
            TypeName="Negocio.ControladorUsuarios" UpdateMethod="actualizaUsuario">
            <DeleteParameters>
                <asp:Parameter Name="usuario" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="persona" Type="Object" />
                <asp:Parameter Name="usuario" Type="String" />
                <asp:Parameter Name="clave" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style11">
                        <asp:Button ID="btnAlta" runat="server" Text="Alta" Width="159px" 
                            onclick="btnAlta_Click" />
                    </td>
                    <td class="auto-style10">
                        <asp:Button ID="btnBaja" runat="server" onclick="btnBaja_Click" Text="Baja" 
                            Width="161px" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

