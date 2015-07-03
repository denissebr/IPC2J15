﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="_DenisseBR_.cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 55px;
            border-collapse: collapse;
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">


    <asp:Panel ID="pnlc" runat="server" Height="345px">
        <div style="text-align:right">
    <asp:Panel ID="datos" runat="server" Height="98px" CssClass="panel">
        <asp:Label ID="Label1" runat="server" CssClass="label" Font-Size="XX-Large" Text="Bienvenido: " ForeColor="Black"></asp:Label>
        <asp:Label ID="usuarioN" runat="server" CssClass="label" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
        <br />
        <asp:Button ID="linkd" runat="server" CssClass="btn-link active" Font-Bold="True" Font-Size="X-Large" Text="Actualizar Datos" ForeColor="#669999" OnClick="linkd_Click" />
        <asp:Button ID="end" runat="server" CssClass="btn-link active" Font-Bold="True" Font-Size="X-Large" OnClick="end_Click" Text="Cerrar Sesion" ForeColor="#669999" />
    </asp:Panel>
            </div>
        <div style="text-align:center">

            <br />
            <br />

            <asp:Button ID="cotizar" runat="server" CssClass="btn" Text="Cotizar" BorderColor="#CCFFFF" OnClick="cotizar_Click" />
            <asp:Button ID="pedido" runat="server" CssClass="btn" Text="Crear Pedido" BorderColor="#CC99FF" BorderStyle="Solid" OnClick="pedido_Click" />
            <asp:Button ID="estados" runat="server" CssClass="btn" Text="Ver estados de Pedido" BorderColor="#CC33FF" OnClick="estados_Click" />

            <br />

        </div>

        <div style="text-align:center">

            <asp:Panel ID="pnlcot" runat="server" Height="299px" ScrollBars="Auto">
                <br />
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Precio: "></asp:Label>
                <asp:TextBox ID="txtprecio" runat="server" Font-Size="Medium"></asp:TextBox>
                &nbsp;<asp:Label ID="Label3" runat="server" Text="US$"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="Peso:"></asp:Label>
                &nbsp;<asp:TextBox ID="txtpeso" runat="server" Font-Size="Medium"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Libras"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Tipo: "></asp:Label>
                <asp:DropDownList ID="ddt" runat="server" Font-Size="Medium">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="btncot" runat="server" CssClass="btn active" Text="Cotizar" OnClick="btncot_Click" />
                <br />
                <br />
                <asp:Label ID="Label12" runat="server" Text="El precio del pedido seria: "></asp:Label>
                <asp:Label ID="lblprecio" runat="server"></asp:Label>
            </asp:Panel>
           
        </div>
        <div style="text-align:center">
             <asp:Panel ID="pnlpedido" runat="server" Height="471px" TabIndex="1">
 <br />
                 &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="Medium" Text="Nombre:"></asp:Label>
                 <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Medium" Text="Descripcion:"></asp:Label>
                 <asp:TextBox ID="txtdescripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
                 <br />
                 <br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="Precio: "></asp:Label>
                 <asp:TextBox ID="txtprecio1" runat="server" Font-Size="Medium"></asp:TextBox>
                 &nbsp;<asp:Label ID="Label8" runat="server" Text="US$"></asp:Label>
                <br />
                <br />
                 &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="Peso:"></asp:Label>
                &nbsp;<asp:TextBox ID="txtpeso1" runat="server" Font-Size="Medium"></asp:TextBox>
                <asp:Label ID="Label10" runat="server" Text="Libras"></asp:Label>
                 &nbsp;<br /> <br />
                 <table align="center" class="auto-style1">
                     <tr>
                         <td>
                             <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="Medium" Text="Foto:"></asp:Label>
                         </td>
                         <td>
                             <asp:FileUpload ID="precarga" runat="server" ForeColor="Black" />
                         </td>
                     </tr>
                 </table>
                 <br />
                 &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Medium" Text="Tipo: "></asp:Label>
                <asp:DropDownList ID="ddt1" runat="server" Font-Size="Medium" TabIndex="1">
                </asp:DropDownList>
                 <br />
                 <br />
                 <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sucursal: "></asp:Label>
                 <asp:Label ID="nSucursal" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="crear" runat="server" CssClass="btn active" Text="Crear Pedido" OnClick="crear_Click" />
                 <br />
                 <br />
                 <asp:Label ID="lblmsjpe" runat="server"></asp:Label>
                 <br />
             </asp:Panel>
        </div>

        <div style="text-align:center">
             <asp:Panel ID="pnlPedidos" runat="server" ScrollBars="Auto">
                 <br />
                 PEDIDOS:<br />
                 <br />
                 <asp:GridView ID="GridView1" runat="server" style="align-self:center" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" HorizontalAlign="Center">
                     <AlternatingRowStyle BackColor="#F7F7F7" />
                     <EmptyDataTemplate>
                         No hay pedidos que
                         <br />
                         mostrar
                     </EmptyDataTemplate>
                     <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                     <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                     <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                     <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                     <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                     <SortedAscendingCellStyle BackColor="#F4F4FD" />
                     <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                     <SortedDescendingCellStyle BackColor="#D8D8F0" />
                     <SortedDescendingHeaderStyle BackColor="#3E3277" />
                 </asp:GridView>
                 <br />
 <br />
                
             </asp:Panel>
        </div>
        
</asp:Panel>


    <br />


</asp:Content>
