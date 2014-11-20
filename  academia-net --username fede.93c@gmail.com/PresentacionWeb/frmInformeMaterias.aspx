<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmInformeMaterias.aspx.cs" Inherits="frmInformeMaterias" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 124%;">
        <tr>
            <td class="style1">
                &nbsp;
                <asp:Button ID="btnInforme" runat="server" onclick="Button1_Click" 
                    Text="Informe" Width="147px" />
            </td>
            <td class="style2">
            </td>
            <td>
                &nbsp;<asp:DropDownList ID="ddlPersonas" runat="server" Height="16px" 
                    Width="148px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
        <CR:CrystalReportViewer ID="crViewer" runat="server" 
            AutoDataBind="true" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style1
        {
            width: 196px;
        }
        #Button1
        {
            text-align: right;
            width: 89px;
        }
        .style2
        {
            width: 294px;
        }
    </style>
</asp:Content>

