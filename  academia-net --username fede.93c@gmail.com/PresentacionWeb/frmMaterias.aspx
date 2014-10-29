<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmMaterias.aspx.cs" Inherits="frmMaterias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:GridView ID="dgvMaterias" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" 
                    DataSourceID="odsMaterias">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                        <asp:BoundField DataField="nroMateria" HeaderText="nroMateria" 
                            SortExpression="nroMateria" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                            SortExpression="Nombre" />
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
                <asp:ObjectDataSource ID="odsMaterias" runat="server" 
                    SelectMethod="getMaterias" TypeName="Negocio.ControladorMaterias">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style9">
                            <asp:Button ID="btnAlta" runat="server" Text="Alta" Width="87px" 
                                onclick="btnAlta_Click" />
                        </td>
                        <td class="auto-style9">
                            <asp:Button ID="btnBaja" runat="server" Text="Baja" Width="86px" Height="28px" 
                                onclick="btnBaja_Click" />
                        </td>
                        <td class="auto-style10">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="86px" 
                                onclick="btnGuardar_Click"   />
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="86px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

