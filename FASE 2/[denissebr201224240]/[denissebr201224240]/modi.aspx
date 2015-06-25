<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modi.aspx.cs" Inherits="_denissebr201224240_.modi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Quetzal Express-[ACTUALIZAR]</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel panel-success">
  <div class="panel-heading" style="text-align:center">
    <h3 class="panel-title">Actualizar Informacion<br />
        <br />
        <asp:Label ID="usuarioN" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/cliente.aspx">MODULO CLIENTE</asp:HyperLink>
      </h3>
  </div>
  <div class="panel-body" style="text-align:center">
    
      <center>
      
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="DPI" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
          <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
          <Columns>
              <asp:CommandField ButtonType="Button" ShowEditButton="True" />
              <asp:BoundField DataField="DPI" HeaderText="DPI" ReadOnly="True" SortExpression="DPI" />
              <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
              <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
              <asp:BoundField DataField="NIT" HeaderText="NIT" SortExpression="NIT" />
              <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
              <asp:BoundField DataField="Tarjeta" HeaderText="Tarjeta" SortExpression="Tarjeta" />
              <asp:BoundField DataField="Domicilio" HeaderText="Domicilio" SortExpression="Domicilio" />
              <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
              <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" SortExpression="Contraseña" />
          </Columns>
          <EditRowStyle BackColor="#999999" />
          <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
          <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
          <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
          <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
          <SortedAscendingCellStyle BackColor="#E9E7E2" />
          <SortedAscendingHeaderStyle BackColor="#506C8C" />
          <SortedDescendingCellStyle BackColor="#FFFDF8" />
          <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
      </asp:GridView>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:IPC2J15ConnectionString %>" DeleteCommand="DELETE FROM [Cliente] WHERE [DPI] = @original_DPI AND [Nombre] = @original_Nombre AND [Apellido] = @original_Apellido AND (([NIT] = @original_NIT) OR ([NIT] IS NULL AND @original_NIT IS NULL)) AND (([Telefono] = @original_Telefono) OR ([Telefono] IS NULL AND @original_Telefono IS NULL)) AND [Tarjeta] = @original_Tarjeta AND [Domicilio] = @original_Domicilio AND [Usuario] = @original_Usuario AND [Contraseña] = @original_Contraseña" InsertCommand="INSERT INTO [Cliente] ([DPI], [Nombre], [Apellido], [NIT], [Telefono], [Tarjeta], [Domicilio], [Usuario], [Contraseña]) VALUES (@DPI, @Nombre, @Apellido, @NIT, @Telefono, @Tarjeta, @Domicilio, @Usuario, @Contraseña)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [DPI], [Nombre], [Apellido], [NIT], [Telefono], [Tarjeta], [Domicilio], [Usuario], [Contraseña] FROM [Cliente] WHERE ([Nombre] = @Nombre)" UpdateCommand="UPDATE [Cliente] SET [Nombre] = @Nombre, [Apellido] = @Apellido, [NIT] = @NIT, [Telefono] = @Telefono, [Tarjeta] = @Tarjeta, [Domicilio] = @Domicilio, [Usuario] = @Usuario, [Contraseña] = @Contraseña WHERE [DPI] = @original_DPI AND [Nombre] = @original_Nombre AND [Apellido] = @original_Apellido AND (([NIT] = @original_NIT) OR ([NIT] IS NULL AND @original_NIT IS NULL)) AND (([Telefono] = @original_Telefono) OR ([Telefono] IS NULL AND @original_Telefono IS NULL)) AND [Tarjeta] = @original_Tarjeta AND [Domicilio] = @original_Domicilio AND [Usuario] = @original_Usuario AND [Contraseña] = @original_Contraseña">
          <DeleteParameters>
              <asp:Parameter Name="original_DPI" Type="Int32" />
              <asp:Parameter Name="original_Nombre" Type="String" />
              <asp:Parameter Name="original_Apellido" Type="String" />
              <asp:Parameter Name="original_NIT" Type="Int32" />
              <asp:Parameter Name="original_Telefono" Type="Int32" />
              <asp:Parameter Name="original_Tarjeta" Type="Int64" />
              <asp:Parameter Name="original_Domicilio" Type="String" />
              <asp:Parameter Name="original_Usuario" Type="String" />
              <asp:Parameter Name="original_Contraseña" Type="String" />
          </DeleteParameters>
          <InsertParameters>
              <asp:Parameter Name="DPI" Type="Int32" />
              <asp:Parameter Name="Nombre" Type="String" />
              <asp:Parameter Name="Apellido" Type="String" />
              <asp:Parameter Name="NIT" Type="Int32" />
              <asp:Parameter Name="Telefono" Type="Int32" />
              <asp:Parameter Name="Tarjeta" Type="Int64" />
              <asp:Parameter Name="Domicilio" Type="String" />
              <asp:Parameter Name="Usuario" Type="String" />
              <asp:Parameter Name="Contraseña" Type="String" />
          </InsertParameters>
          <SelectParameters>
              <asp:ControlParameter ControlID="usuarioN" Name="Nombre" PropertyName="Text" Type="String" />
          </SelectParameters>
          <UpdateParameters>
              <asp:Parameter Name="Nombre" Type="String" />
              <asp:Parameter Name="Apellido" Type="String" />
              <asp:Parameter Name="NIT" Type="Int32" />
              <asp:Parameter Name="Telefono" Type="Int32" />
              <asp:Parameter Name="Tarjeta" Type="Int64" />
              <asp:Parameter Name="Domicilio" Type="String" />
              <asp:Parameter Name="Usuario" Type="String" />
              <asp:Parameter Name="Contraseña" Type="String" />
              <asp:Parameter Name="original_DPI" Type="Int32" />
              <asp:Parameter Name="original_Nombre" Type="String" />
              <asp:Parameter Name="original_Apellido" Type="String" />
              <asp:Parameter Name="original_NIT" Type="Int32" />
              <asp:Parameter Name="original_Telefono" Type="Int32" />
              <asp:Parameter Name="original_Tarjeta" Type="Int64" />
              <asp:Parameter Name="original_Domicilio" Type="String" />
              <asp:Parameter Name="original_Usuario" Type="String" />
              <asp:Parameter Name="original_Contraseña" Type="String" />
          </UpdateParameters>
      </asp:SqlDataSource>
   </center>
  </div>
</div>
    </form>
</body>
</html>
