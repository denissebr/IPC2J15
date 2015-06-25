<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empleado.aspx.cs" Inherits="_denissebr201224240_.empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
    <title>Quetzal Express-[EMPLEADO]</title>
</head>
<body>
    <form id="form1" runat="server">
  <div class="panel panel-info">
  <div class="panel-heading" style="text-align:center">
    <h3 class="panel-title">EMPLEADO<br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">cerrar sesion</asp:HyperLink>
      </h3>
  </div>
  <div class="panel-body" style="text-align:center">
   
      <div class="panel panel-default">
  <div class="panel-heading">BUSCAR CASILLA CLIENTE</div>
  <div class="panel-body">
    
      INGRESE NOMBRE O DIGITO DE LA CASILLA:<br />
      <br />
      <asp:TextBox ID="BUSCAR" runat="server"></asp:TextBox>
&nbsp;
      <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
      <br />
      <br />
      <center>
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" DataKeyNames="DPI" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
          <AlternatingRowStyle BackColor="White" />
          <Columns>
              <asp:BoundField DataField="DPI" HeaderText="DPI" ReadOnly="True" SortExpression="DPI" />
              <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
              <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
              <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
              <asp:BoundField DataField="NIT" HeaderText="NIT" SortExpression="NIT" />
              <asp:BoundField DataField="Domicilio" HeaderText="Domicilio" SortExpression="Domicilio" />
              <asp:BoundField DataField="Casilla" HeaderText="Casilla" InsertVisible="False" ReadOnly="True" SortExpression="Casilla" />
              <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
              <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
          </Columns>
          <FooterStyle BackColor="#CCCC99" />
          <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
          <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
          <RowStyle BackColor="#F7F7DE" />
          <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
          <SortedAscendingCellStyle BackColor="#FBFBF2" />
          <SortedAscendingHeaderStyle BackColor="#848384" />
          <SortedDescendingCellStyle BackColor="#EAEAD3" />
          <SortedDescendingHeaderStyle BackColor="#575357" />
      </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IPC2J15ConnectionString %>" SelectCommand="SELECT [DPI], [Nombre], [Apellido], [Telefono], [NIT], [Domicilio], [Casilla], [Usuario], [Activo] FROM [Cliente] WHERE ([Nombre] = @Nombre)">
              <SelectParameters>
                  <asp:ControlParameter ControlID="BUSCAR" Name="Nombre" PropertyName="Text" Type="String" />
              </SelectParameters>
          </asp:SqlDataSource>
          </center>
    

  </div>
</div>
      
      <div class="panel panel-default">
  <div class="panel-heading">USUARIOS PENDIENTES DE APROBACION</div>
  <div class="panel-body">
    <CENTER>
      <asp:GridView ID="GridView2" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" AutoGenerateColumns="False" DataKeyNames="DPI" >
          <AlternatingRowStyle BackColor="PaleGoldenrod" />
          <Columns>
              <asp:CommandField ShowEditButton="True" />
              <asp:BoundField DataField="DPI" HeaderText="DPI" ReadOnly="True" SortExpression="DPI" />
              <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" SortExpression="Nombre" />
              <asp:BoundField DataField="Apellido" HeaderText="Apellido" ReadOnly="True" SortExpression="Apellido" />
              <asp:BoundField DataField="NIT" HeaderText="NIT" ReadOnly="True" SortExpression="NIT" />
              <asp:BoundField DataField="Telefono" HeaderText="Telefono" ReadOnly="True" SortExpression="Telefono" />
              <asp:BoundField DataField="Domicilio" HeaderText="Domicilio" ReadOnly="True" SortExpression="Domicilio" />
              <asp:BoundField DataField="Idsucursal" HeaderText="Idsucursal" ReadOnly="True" SortExpression="Idsucursal" />
              <asp:BoundField DataField="Usuario" HeaderText="Usuario" ReadOnly="True" SortExpression="Usuario" />
              <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
          </Columns>
          <FooterStyle BackColor="Tan" />
          <HeaderStyle BackColor="Tan" Font-Bold="True" />
          <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
          <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
          <SortedAscendingCellStyle BackColor="#FAFAE7" />
          <SortedAscendingHeaderStyle BackColor="#DAC09E" />
          <SortedDescendingCellStyle BackColor="#E1DB9C" />
          <SortedDescendingHeaderStyle BackColor="#C2A47B" />
      </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:IPC2J15ConnectionString %>" DeleteCommand="DELETE FROM [Cliente] WHERE [DPI] = @original_DPI AND [Nombre] = @original_Nombre AND [Apellido] = @original_Apellido AND (([NIT] = @original_NIT) OR ([NIT] IS NULL AND @original_NIT IS NULL)) AND (([Telefono] = @original_Telefono) OR ([Telefono] IS NULL AND @original_Telefono IS NULL)) AND [Domicilio] = @original_Domicilio AND [Idsucursal] = @original_Idsucursal AND [Usuario] = @original_Usuario AND [Activo] = @original_Activo" InsertCommand="INSERT INTO [Cliente] ([DPI], [Nombre], [Apellido], [NIT], [Telefono], [Domicilio], [Idsucursal], [Usuario], [Activo]) VALUES (@DPI, @Nombre, @Apellido, @NIT, @Telefono, @Domicilio, @Idsucursal, @Usuario, @Activo)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [DPI], [Nombre], [Apellido], [NIT], [Telefono], [Domicilio], [Idsucursal], [Usuario], [Activo] FROM [Cliente] WHERE ([Activo] = @Activo)" UpdateCommand="UPDATE [Cliente] SET [Nombre] = @Nombre, [Apellido] = @Apellido, [NIT] = @NIT, [Telefono] = @Telefono, [Domicilio] = @Domicilio, [Idsucursal] = @Idsucursal, [Usuario] = @Usuario, [Activo] = @Activo WHERE [DPI] = @original_DPI AND [Nombre] = @original_Nombre AND [Apellido] = @original_Apellido AND (([NIT] = @original_NIT) OR ([NIT] IS NULL AND @original_NIT IS NULL)) AND (([Telefono] = @original_Telefono) OR ([Telefono] IS NULL AND @original_Telefono IS NULL)) AND [Domicilio] = @original_Domicilio AND [Idsucursal] = @original_Idsucursal AND [Usuario] = @original_Usuario AND [Activo] = @original_Activo">
            <DeleteParameters>
                <asp:Parameter Name="original_DPI" Type="Int32" />
                <asp:Parameter Name="original_Nombre" Type="String" />
                <asp:Parameter Name="original_Apellido" Type="String" />
                <asp:Parameter Name="original_NIT" Type="Int32" />
                <asp:Parameter Name="original_Telefono" Type="Int32" />
                <asp:Parameter Name="original_Domicilio" Type="String" />
                <asp:Parameter Name="original_Idsucursal" Type="Int32" />
                <asp:Parameter Name="original_Usuario" Type="String" />
                <asp:Parameter Name="original_Activo" Type="Boolean" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="DPI" Type="Int32" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Apellido" Type="String" />
                <asp:Parameter Name="NIT" Type="Int32" />
                <asp:Parameter Name="Telefono" Type="Int32" />
                <asp:Parameter Name="Domicilio" Type="String" />
                <asp:Parameter Name="Idsucursal" Type="Int32" />
                <asp:Parameter Name="Usuario" Type="String" />
                <asp:Parameter Name="Activo" Type="Boolean" />
            </InsertParameters>
            <SelectParameters>
                <asp:Parameter DefaultValue="FALSE" Name="Activo" Type="Boolean" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Apellido" Type="String" />
                <asp:Parameter Name="NIT" Type="Int32" />
                <asp:Parameter Name="Telefono" Type="Int32" />
                <asp:Parameter Name="Domicilio" Type="String" />
                <asp:Parameter Name="Idsucursal" Type="Int32" />
                <asp:Parameter Name="Usuario" Type="String" />
                <asp:Parameter Name="Activo" Type="Boolean" />
                <asp:Parameter Name="original_DPI" Type="Int32" />
                <asp:Parameter Name="original_Nombre" Type="String" />
                <asp:Parameter Name="original_Apellido" Type="String" />
                <asp:Parameter Name="original_NIT" Type="Int32" />
                <asp:Parameter Name="original_Telefono" Type="Int32" />
                <asp:Parameter Name="original_Domicilio" Type="String" />
                <asp:Parameter Name="original_Idsucursal" Type="Int32" />
                <asp:Parameter Name="original_Usuario" Type="String" />
                <asp:Parameter Name="original_Activo" Type="Boolean" />
            </UpdateParameters>
        </asp:SqlDataSource>
        </CENTER>
    
  </div>
</div>  
  </div>
</div>
    </form>
</body>
</html>
