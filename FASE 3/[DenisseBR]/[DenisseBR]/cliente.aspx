<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="_DenisseBR_.cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">


    <asp:Panel ID="pnlc" runat="server" Height="345px">
        <div style="text-align:right">
    <asp:Panel ID="datos" runat="server" BackColor="White" Height="98px">
        <asp:Label ID="Label1" runat="server" CssClass="label" Font-Size="XX-Large" Text="Bienvenido: " ForeColor="Black"></asp:Label>
        <asp:Label ID="usuarioN" runat="server" CssClass="label" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
        <br />
        <asp:Button ID="linkd" runat="server" CssClass="btn-link active" Font-Bold="True" Font-Size="X-Large" Text="Actualizar Datos" ForeColor="#CCFF33" OnClick="linkd_Click" />
        <asp:Button ID="end" runat="server" CssClass="btn-link active" Font-Bold="True" Font-Size="X-Large" OnClick="end_Click" Text="Cerrar Sesion" ForeColor="#CCFF33" />
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
                <asp:Button ID="btncot" runat="server" CssClass="btn active" Text="Cotizar" />
                <br />
                <br />
                <asp:Label ID="Label12" runat="server" Text="El precio del pedido seria: "></asp:Label>
                <asp:Label ID="lblprecio" runat="server"></asp:Label>
            </asp:Panel>
           
        </div>
        <div style="text-align:center">
             <asp:Panel ID="pnlpedido" runat="server" Height="310px">
 <br />
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="Precio: "></asp:Label>
                <asp:TextBox ID="txtprecio1" runat="server" Font-Size="Medium"></asp:TextBox>
                &nbsp;<asp:Label ID="Label8" runat="server" Text="US$"></asp:Label>
                <br />
                <br />
                 &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="Peso:"></asp:Label>
                &nbsp;<asp:TextBox ID="txtpeso1" runat="server" Font-Size="Medium"></asp:TextBox>
                <asp:Label ID="Label10" runat="server" Text="Libras"></asp:Label>
                 <br />
                 <br />
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Medium" Text="Tipo: "></asp:Label>
                <asp:DropDownList ID="ddt1" runat="server" Font-Size="Medium">
                </asp:DropDownList>
                 <br />
                 <br />
                 <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sucursal: "></asp:Label>
                 <asp:Label ID="nSucursal" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="crear" runat="server" CssClass="btn active" Text="Crear Pedido" />
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
                 <asp:GridView ID="GridView1" runat="server" style="align-self:center">
                 </asp:GridView>
                 <br />
 <br />
                
             </asp:Panel>
        </div>
        
</asp:Panel>


    <br />


</asp:Content>
