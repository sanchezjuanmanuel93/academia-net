<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmPermisos.aspx.cs" Inherits="frmPermisos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 80px;
        }
        .auto-style10 {
            width: 83px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:GridView ID="dgvPermisos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  AutoGenerateColumns="False" >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Usuario">
                            <ItemTemplate>
                                <asp:Label ID="Usuario" runat="server" Text='<%# Eval("Usuario") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Modulo">
                            <ItemTemplate>
                                <asp:Label ID="Modulo" runat="server" Text='<%# Eval("Modulo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Alta">
                            <ItemTemplate>
                                <asp:CheckBox ID="Alta" runat="server" Checked='<%# Eval("Alta") %>' AutoPostBack="true" OnCheckedChanged="altaChekedChanged"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Baja">
                                                        <ItemTemplate>
                                <asp:CheckBox ID="Baja" runat="server" Checked='<%# Eval("Baja") %>'  AutoPostBack="true" OnCheckedChanged="bajaChekedChanged"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Modifica">
                                                        <ItemTemplate>
                                <asp:CheckBox ID="Modifica" runat="server" Checked='<%# Eval("Modifica") %>'  AutoPostBack="true" OnCheckedChanged="modificaChekedChanged"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Consulta">
                                                        <ItemTemplate>
                                <asp:CheckBox ID="Consulta" runat="server" Checked='<%# Eval("Consulta") %>'  AutoPostBack="true" OnCheckedChanged="consultaChekedChanged"/>
                            </ItemTemplate>
                        </asp:TemplateField>
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
                            <asp:Button ID="btnAlta" runat="server" Text="Alta" Width="87px" />
                        </td>
                        <td class="auto-style9">
                            <asp:Button ID="btnBaja" runat="server" Text="Baja" Width="86px" OnClick="btnBaja_Click" style="height: 26px" />
                        </td>
                        <td class="auto-style10">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="86px" OnClick="btnGuardar_Click"  />
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

