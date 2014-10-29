<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmUsuarios.aspx.cs" Inherits="frmUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 283px">
        <asp:GridView ID="grvUsuarios" runat="server" AutoGenerateColumns="False" 
            DataSourceID="odsUsuarios">
            <Columns>
                <asp:CommandField ButtonType="Button" 
                    ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Usu" HeaderText="Usu" SortExpression="Usu" />
                <asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" 
                    SortExpression="Legajo" />
            </Columns>
            <SelectedRowStyle BackColor="#CCCC00" />
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
                    <td>
                        <asp:Button ID="btnAlta" runat="server" Text="Alta" Width="66px" 
                            onclick="btnAlta_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnBaja" runat="server" onclick="btnBaja_Click" Text="Baja" 
                            Width="68px" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

