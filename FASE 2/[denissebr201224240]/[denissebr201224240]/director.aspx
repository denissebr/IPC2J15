<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="director.aspx.cs" Inherits="_denissebr201224240_.director" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <title>Quetzal Express-[DIRECTOR]</title>
    <style type="text/css">
        .auto-style3 {
            width: 240px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel panel-warning">
  <div class="panel-heading" style="text-align:center">
    <h3 class="panel-title">BIENVENIDO DIRECTOR<br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">Cerrar Sesion</asp:HyperLink>
      </h3>
  </div>
  <div class="panel-body" style="text-align:center">
      <asp:Panel ID="Panel1" runat="server" BorderColor="#00FF99" BorderStyle="Double" Height="177px">
          <asp:Panel ID="Panel2" runat="server" BackColor="#00FF99" Height="42px">
              <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="CARGA DE ARCHIVOS"></asp:Label>
          </asp:Panel>
          <br />
          <br />

          <table align="center">
              <tr>
                  <td class="table-condensed">
                      <asp:Label ID="Label5" runat="server" Text="Seleccione el archivo a cargar: "></asp:Label>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style3">
                      <asp:FileUpload ID="cargarEmp" runat="server" ForeColor="Black" />
                  </td>
              </tr>
              <tr>
                  <td class="auto-style3">
                      <asp:Button ID="carga" runat="server" ForeColor="Black" Text="Cargar" OnClick="carga_Click" />
                  </td>
              </tr>
          </table>

      </asp:Panel>
      <br />
   <br />
      <asp:Panel ID="Panel3" runat="server" BorderColor="#FFCCCC" BorderStyle="Double" Height="164px" ScrollBars="Auto">
          <asp:Panel ID="Panel4" runat="server" BackColor="#FFCCCC" Height="47px">
              <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="CONSULTAR EQUIPO"></asp:Label>
          </asp:Panel>
          <br />
          <asp:Button ID="consultar" runat="server" Text="Consultar Equipo" />
          <br />
          <br />
          <br />
          <center>
          <asp:GridView ID="GridView1" runat="server" >
          </asp:GridView>
          </center>

      </asp:Panel>
      <br />
   <br />
      <asp:Panel ID="Panel5" runat="server" BorderColor="#CC99FF" BorderStyle="Double" Height="274px" ScrollBars="Auto">
          <asp:Panel ID="Panel6" runat="server" BackColor="#CC99FF" Height="50px">
              <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" Text="MODIFICAR CONTRATACION"></asp:Label>
          </asp:Panel>
          <br />
          <br />

          <asp:Label ID="Label6" runat="server" Text="Ingrese el codigo del empleado:  "></asp:Label>
          <asp:TextBox ID="codEmp" runat="server"></asp:TextBox>
          &nbsp;
          <asp:Button ID="buscar" runat="server" Text="Buscar" />
          <br />
          <br />
          <center>
          <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="codigo" DataSourceID="SqlDataSource1" GridLines="Horizontal">
              <AlternatingRowStyle BackColor="#F7F7F7" />
              <Columns>
                  <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
                  <asp:BoundField DataField="codigo" HeaderText="codigo" InsertVisible="False" ReadOnly="True" SortExpression="codigo" />
                  <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                  <asp:BoundField DataField="Apelllido" HeaderText="Apelllido" SortExpression="Apelllido" />
                  <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                  <asp:BoundField DataField="Sueldo" HeaderText="Sueldo" SortExpression="Sueldo" />
                  <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                  <asp:BoundField DataField="IdDepartamento" HeaderText="IdDepartamento" SortExpression="IdDepartamento" />
                  <asp:BoundField DataField="Rol" HeaderText="Rol" SortExpression="Rol" />
                  <asp:BoundField DataField="IdSucursal" HeaderText="IdSucursal" SortExpression="IdSucursal" />
                  <asp:BoundField DataField="UsuarioEmpleado" HeaderText="UsuarioEmpleado" SortExpression="UsuarioEmpleado" />
                  <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" SortExpression="Contraseña" />
              </Columns>
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
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:IPC2J15ConnectionString %>" DeleteCommand="DELETE FROM [Empleado] WHERE [codigo] = @original_codigo AND [Nombre] = @original_Nombre AND [Apelllido] = @original_Apelllido AND [Telefono] = @original_Telefono AND [Sueldo] = @original_Sueldo AND [Direccion] = @original_Direccion AND [IdDepartamento] = @original_IdDepartamento AND [Rol] = @original_Rol AND [IdSucursal] = @original_IdSucursal AND [UsuarioEmpleado] = @original_UsuarioEmpleado AND [Contraseña] = @original_Contraseña" InsertCommand="INSERT INTO [Empleado] ([Nombre], [Apelllido], [Telefono], [Sueldo], [Direccion], [IdDepartamento], [Rol], [IdSucursal], [UsuarioEmpleado], [Contraseña]) VALUES (@Nombre, @Apelllido, @Telefono, @Sueldo, @Direccion, @IdDepartamento, @Rol, @IdSucursal, @UsuarioEmpleado, @Contraseña)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Empleado] WHERE ([codigo] = @codigo)" UpdateCommand="UPDATE [Empleado] SET [Nombre] = @Nombre, [Apelllido] = @Apelllido, [Telefono] = @Telefono, [Sueldo] = @Sueldo, [Direccion] = @Direccion, [IdDepartamento] = @IdDepartamento, [Rol] = @Rol, [IdSucursal] = @IdSucursal, [UsuarioEmpleado] = @UsuarioEmpleado, [Contraseña] = @Contraseña WHERE [codigo] = @original_codigo AND [Nombre] = @original_Nombre AND [Apelllido] = @original_Apelllido AND [Telefono] = @original_Telefono AND [Sueldo] = @original_Sueldo AND [Direccion] = @original_Direccion AND [IdDepartamento] = @original_IdDepartamento AND [Rol] = @original_Rol AND [IdSucursal] = @original_IdSucursal AND [UsuarioEmpleado] = @original_UsuarioEmpleado AND [Contraseña] = @original_Contraseña">
                  <DeleteParameters>
                      <asp:Parameter Name="original_codigo" Type="Int32" />
                      <asp:Parameter Name="original_Nombre" Type="String" />
                      <asp:Parameter Name="original_Apelllido" Type="String" />
                      <asp:Parameter Name="original_Telefono" Type="Int32" />
                      <asp:Parameter Name="original_Sueldo" Type="Double" />
                      <asp:Parameter Name="original_Direccion" Type="String" />
                      <asp:Parameter Name="original_IdDepartamento" Type="Int32" />
                      <asp:Parameter Name="original_Rol" Type="String" />
                      <asp:Parameter Name="original_IdSucursal" Type="Int32" />
                      <asp:Parameter Name="original_UsuarioEmpleado" Type="String" />
                      <asp:Parameter Name="original_Contraseña" Type="String" />
                  </DeleteParameters>
                  <InsertParameters>
                      <asp:Parameter Name="Nombre" Type="String" />
                      <asp:Parameter Name="Apelllido" Type="String" />
                      <asp:Parameter Name="Telefono" Type="Int32" />
                      <asp:Parameter Name="Sueldo" Type="Double" />
                      <asp:Parameter Name="Direccion" Type="String" />
                      <asp:Parameter Name="IdDepartamento" Type="Int32" />
                      <asp:Parameter Name="Rol" Type="String" />
                      <asp:Parameter Name="IdSucursal" Type="Int32" />
                      <asp:Parameter Name="UsuarioEmpleado" Type="String" />
                      <asp:Parameter Name="Contraseña" Type="String" />
                  </InsertParameters>
                  <SelectParameters>
                      <asp:ControlParameter ControlID="codEmp" Name="codigo" PropertyName="Text" Type="Int32" />
                  </SelectParameters>
                  <UpdateParameters>
                      <asp:Parameter Name="Nombre" Type="String" />
                      <asp:Parameter Name="Apelllido" Type="String" />
                      <asp:Parameter Name="Telefono" Type="Int32" />
                      <asp:Parameter Name="Sueldo" Type="Double" />
                      <asp:Parameter Name="Direccion" Type="String" />
                      <asp:Parameter Name="IdDepartamento" Type="Int32" />
                      <asp:Parameter Name="Rol" Type="String" />
                      <asp:Parameter Name="IdSucursal" Type="Int32" />
                      <asp:Parameter Name="UsuarioEmpleado" Type="String" />
                      <asp:Parameter Name="Contraseña" Type="String" />
                      <asp:Parameter Name="original_codigo" Type="Int32" />
                      <asp:Parameter Name="original_Nombre" Type="String" />
                      <asp:Parameter Name="original_Apelllido" Type="String" />
                      <asp:Parameter Name="original_Telefono" Type="Int32" />
                      <asp:Parameter Name="original_Sueldo" Type="Double" />
                      <asp:Parameter Name="original_Direccion" Type="String" />
                      <asp:Parameter Name="original_IdDepartamento" Type="Int32" />
                      <asp:Parameter Name="original_Rol" Type="String" />
                      <asp:Parameter Name="original_IdSucursal" Type="Int32" />
                      <asp:Parameter Name="original_UsuarioEmpleado" Type="String" />
                      <asp:Parameter Name="original_Contraseña" Type="String" />
                  </UpdateParameters>
              </asp:SqlDataSource>
          </center>

      </asp:Panel>
      <br />
      <asp:Panel ID="Panel7" runat="server" BorderColor="#FFFF66" BorderStyle="Double" Height="150px">
          <asp:Panel ID="Panel8" runat="server" BackColor="#FFFF66" Height="41px">
              <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" Text="DESPEDIR EMPLEADO"></asp:Label>
          </asp:Panel>
          <br />
          <asp:Label ID="Label7" runat="server" Text="Ingrese el Codigo del empleado:  "></asp:Label>
          <asp:TextBox ID="baja" runat="server"></asp:TextBox>
          <br />
          <br />
          <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Dar de Baja" />
          &nbsp;&nbsp;
          <asp:Label ID="msj" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Lime" Text="Empleado Eliminado Exitosamente" Visible="False"></asp:Label>
          <br />

      </asp:Panel>
  </div>
</div>
    </form>
</body>
</html>

