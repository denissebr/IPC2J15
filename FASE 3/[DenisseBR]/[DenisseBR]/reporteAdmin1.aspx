<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="reporteAdmin1.aspx.cs" Inherits="_DenisseBR_.reporteAdmin1" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">
    <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
        <Report FileName="ReporteAdmin1.rpt">
        </Report>
    </CR:CrystalReportSource>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Administrador" />
    <br />
    <br />
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" ReportSourceID="CrystalReportSource1" EnableParameterPrompt="False" ToolPanelView="None" />
</asp:Content>
