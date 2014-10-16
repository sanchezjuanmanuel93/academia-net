<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmInscripciones.aspx.cs" Inherits="frmInscripciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="height: 175px;">
        <tr>
            <td>
                <asp:GridView ID="dgvInscripciones" runat="server" AutoGenerateColumns="False" Width="516px" OnDataBound="dgvInscripciones_DataBound1" BackColor="#2F9DC4" ForeColor="White" Font-Bold="True" Font-Size="Large">
                    <Columns>
                        <asp:BoundField HeaderText="Legao" DataField="Legajo"></asp:BoundField>
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido"></asp:BoundField>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre"></asp:BoundField>
                        <asp:BoundField HeaderText="Materia" DataField="NombreMateria"></asp:BoundField>
                        <asp:BoundField HeaderText="Fecha Inscripcion" DataField="Fecha"></asp:BoundField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%;">
                    <tr>
                        <td>
                            <asp:Button ID="btnAlta" runat="server" Text="Alta" Width="251px" BackColor="#2F9DC4" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" Height="50px" />
                        </td>
                        <td>
                            <asp:Button ID="btnBaja" runat="server" Text="Baja" Width="251px" BackColor="#2F9DC4" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" Height="50px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

