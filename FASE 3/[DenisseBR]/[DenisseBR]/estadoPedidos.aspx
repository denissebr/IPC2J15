<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="estadoPedidos.aspx.cs" Inherits="_DenisseBR_.estadoPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">
    <div style="text-align:center">
        <asp:Panel ID="Panel1" runat="server" CssClass="panel" Height="117px">
        <asp:Label ID="Label3" runat="server" Text="INFORMACION DE PEDIDO INDIVIDUAL" Font-Bold="True" Font-Size="XX-Large"></asp:Label>

           
            <br />
            <br />
            <span class="auto-style1">Cliente:</span>
            <asp:Label ID="usuarioN" runat="server" Font-Size="X-Large"></asp:Label>

           
        </asp:Panel>

    </div>
    <div style="text-align:center">
        <br />
        <asp:GridView ID="pain" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <br />
    </div>
    
</asp:Content>
