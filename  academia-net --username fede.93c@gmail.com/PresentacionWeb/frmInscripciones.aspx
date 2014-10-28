<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmInscripciones.aspx.cs" Inherits="frmInscripciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 215px;
            height: 54px;
        }
        .auto-style10 {
            height: 54px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="height: 175px;">
        <tr>
            <td>
                <asp:GridView ID="dgvInscripciones" runat="server" AutoGenerateColumns="False" 
                    Width="689px" OnDataBound="dgvInscripciones_DataBound1" ForeColor="#333333" 
                    Font-Bold="True" Font-Size="Large" AutoGenerateSelectButton="True" 
                    CellPadding="4" GridLines="None" 
                    OnRowCancelingEdit="dgvInscripciones_RowCancelingEdit" 
                    OnRowEditing="dgvInscripciones_RowEditing" 
                    OnRowUpdating="dgvInscripciones_RowUpdating" onselectedindexchanged="dgvInscripciones_SelectedIndexChanged" 
                    >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField HeaderText="Legao" DataField="Legajo"></asp:BoundField>
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido"></asp:BoundField>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre"></asp:BoundField>
                        <asp:BoundField HeaderText="Materia" DataField="NombreMateria"></asp:BoundField>
                        <asp:BoundField HeaderText="Fecha Inscripcion" DataField="Fecha"></asp:BoundField>
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
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style9">
                            <asp:Button ID="btnAlta" runat="server" Text="Alta" Width="200px" Font-Bold="False" Height="50px" OnClick="btnAlta_Click" />
                        </td>
                        <td class="auto-style10">
                            <asp:Button ID="btnBaja" runat="server" Text="Baja" Width="200px" Font-Bold="False" Height="50px" OnClick="btnBaja_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

