<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="_denissebr201224240_.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Quetzal Express-[ADMINISTRADOR]</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel panel-primary">
  <div class="panel-heading" style="text-align:center">
    <h3 class="panel-title">BIENVENIDO</h3>
  </div>
  <div class="panel-body" style="text-align:center">
      <asp:Panel ID="Panel1" runat="server" BorderColor="#99FF33" BorderStyle="Ridge" Height="318px">
          <asp:Panel ID="Panel2" runat="server" BackColor="#99FF33" Height="45px">
              <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="CARGA DE ARCHIVOS"></asp:Label>
          </asp:Panel>
          <br />
          <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Seleccione el archivo a cargar:"></asp:Label>
          <br />
          <br />
          <CENTER>
          <asp:FileUpload ID="archivo" runat="server" />
          </CENTER>
          <br />

          <asp:DropDownList ID="ddo" runat="server">
              <asp:ListItem>Empleados</asp:ListItem>
              <asp:ListItem>Impuesto</asp:ListItem>
          </asp:DropDownList>
          <br />
          <br />
          <asp:Button ID="cargar" runat="server" OnClick="cargar_Click" Text="Cargar Archivos" />

      </asp:Panel>
   <br />
   <br /> 

  </div>
</div>
    </form>
</body>
</html>
