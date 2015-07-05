<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="_DenisseBR_.cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">




    <asp:Panel ID="pnlc" runat="server" Height="345px">
        <div style="text-align:right">
    <asp:Panel ID="datos" runat="server" Height="98px" CssClass="panel">
        <asp:Label ID="Label1" runat="server" CssClass="label" Font-Size="XX-Large" Text="Bienvenido: " ForeColor="Black"></asp:Label>
        <asp:Label ID="usuarioN" runat="server" CssClass="label" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
        <br />
        <asp:Button ID="linkd" runat="server" CssClass="btn-link active" Font-Bold="True" Font-Size="X-Large" Text="Actualizar Datos" ForeColor="#669999" OnClick="linkd_Click" Height="40px" />
        <asp:Button ID="end" runat="server" CssClass="btn-link active" Font-Bold="True" Font-Size="X-Large" OnClick="end_Click" Text="Cerrar Sesion" ForeColor="#669999" Height="38px" />
    </asp:Panel>
            </div>
        <div style="text-align:center; height: 87px;">

            <br />
            <br />

            <asp:Button ID="cotizar" runat="server" CssClass="btn" Text="Cotizar" BorderColor="#CCFFFF" OnClick="cotizar_Click" Height="36px" />
            <asp:Button ID="pedido" runat="server" CssClass="btn" Text="Crear Pedido" BorderColor="#CC99FF" BorderStyle="Solid" OnClick="pedido_Click" Height="36px" />
            <asp:Button ID="estados" runat="server" CssClass="btn" Text="Ver estados de Pedido" BorderColor="#CC33FF" OnClick="estados_Click" Height="36px" />

            <asp:Button ID="pedido0" runat="server" BorderColor="#CC99FF" BorderStyle="Solid" CssClass="btn" OnClick="pedido0_Click" Text="Imagen de Precarga" Height="36px" />

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
                <asp:Button ID="btncot" runat="server" CssClass="btn active" Text="Cotizar" OnClick="btncot_Click" Height="38px" />
                <br />
                <br />
                <asp:Label ID="Label12" runat="server" Text="El precio del pedido seria: "></asp:Label>
                <asp:Label ID="lblprecio" runat="server"></asp:Label>
            </asp:Panel>
           
        </div>
        <div style="text-align:center">
             <asp:Panel ID="pnlpedido" runat="server" Height="532px" TabIndex="1">
                 <br />
                 &nbsp;&nbsp;<asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="Medium" Text="Nombre:"></asp:Label>
                 <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Medium" Text="Descripcion:"></asp:Label>
                 <asp:TextBox ID="txtdescripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
                 <br />
                 <br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="Precio: "></asp:Label>
                 <asp:TextBox ID="txtprecio1" runat="server" Font-Size="Medium"></asp:TextBox>
                 &nbsp;<asp:Label ID="Label8" runat="server" Text="US$"></asp:Label>
                 &nbsp;&nbsp;<br /><br />&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="Peso:"></asp:Label>
                &nbsp;<asp:TextBox ID="txtpeso1" runat="server" Font-Size="Medium"></asp:TextBox>
                <asp:Label ID="Label10" runat="server" Text="Libras"></asp:Label>
                 &nbsp;<br /> 
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
                <asp:Button ID="crear" runat="server" CssClass="btn active" Text="Crear Pedido" OnClick="crear_Click" Height="38px" />
                 <br />
                 <br />
                 <br />
             </asp:Panel>
        </div>

        <div style="text-align:center">
             <asp:Panel ID="pnlPedidos" runat="server" ScrollBars="Auto">
                 <br />
                 PEDIDOS:<br />
                 <br />
                 <asp:GridView ID="pedidoGV" runat="server" style="align-self:center" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Vertical" HorizontalAlign="Center" CssClass="table-condensed" ForeColor="Black" OnSelectedIndexChanged="pedidoGV_SelectedIndexChanged" Width="310px">
                     <AlternatingRowStyle BackColor="White" />
                     <Columns>
                         <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                     </Columns>
                     <EmptyDataTemplate>
                         No hay pedidos que
                         <br />
                         mostrar
                     </EmptyDataTemplate>
                     <FooterStyle BackColor="#CCCC99" />
                     <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                     <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                     <RowStyle BackColor="#F7F7DE" />
                     <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                     <SortedAscendingCellStyle BackColor="#FBFBF2" />
                     <SortedAscendingHeaderStyle BackColor="#848384" />
                     <SortedDescendingCellStyle BackColor="#EAEAD3" />
                     <SortedDescendingHeaderStyle BackColor="#575357" />
                 </asp:GridView>
                 <br />
 <br />
                
             </asp:Panel>
             <div>
                 <asp:Panel ID="precarga" runat="server">
                     <br />
                     &nbsp;&nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="Medium" Text="Nombre:"></asp:Label>
                     <asp:TextBox ID="nombrep" runat="server"></asp:TextBox>
                     <br />
                     <br />
                <asp:Label ID="Label17" runat="server" Text="Descripcion:" Font-Bold="True" Font-Size="Medium"></asp:Label>
                     <asp:TextBox ID="descp" runat="server" TextMode="MultiLine"></asp:TextBox>
                     <br />
                     <br />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="Medium" Text="Precio: "></asp:Label>
                     <center>
                         <asp:FileUpload ID="pre" runat="server" />
                     </center>
                     &nbsp;&nbsp;&nbsp;<br /><br />&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="Medium" Text="Peso:"></asp:Label>
                 &nbsp;<asp:TextBox ID="pesp" runat="server" Font-Size="Medium"></asp:TextBox>
                     <asp:Label ID="Label21" runat="server" Text="Libras"></asp:Label>
                     &nbsp;<br /> <br />
                 <br />
                 &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="Medium" Text="Tipo: "></asp:Label>
                <asp:DropDownList ID="ddt2" runat="server" Font-Size="Medium" TabIndex="1">
                </asp:DropDownList>
                 <br />
                 <br />
                 <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sucursal: "></asp:Label>
                 <asp:Label ID="Label24" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnprecar" runat="server" CssClass="btn active" Text="Crear Pedido" OnClick="btnprecar_Click" Height="38px" />
                 <br />
                 <br />
                 <br />
                 </asp:Panel>
             </div>
        </div>

        
</asp:Panel>


    <br />


  


</asp:Content>


