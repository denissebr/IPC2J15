<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="_IPC2_JDBR.cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/modernizr.custom.04022.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-primary">
  <div class="panel-heading">
      <center> <h3 class="panel-title">PERFIL DE USUARIO</h3></center>
   
  </div>
  <div class="panel-body" style="text-align: right">
      
          
      <asp:Label ID="bien" runat="server" Text="Bienvenido" Font-Size="XX-Large"></asp:Label>
      &nbsp;
      &nbsp;<asp:Label ID="nombre" runat="server" Font-Size="XX-Large"></asp:Label>
      <br />
      <asp:HyperLink ID="perfil" runat="server" Font-Size="XX-Large">Editar Perfil</asp:HyperLink>
     
         
  </div>
</div>
  <div class="panel panel-success">
  <div class="panel-heading">
      <center><h3 class="panel-title">HISTORIAL DE PAQUETES</h3></center>
  </div>
  <div class="panel-body">
      &nbsp;<br />
      <br />
      <CENTER>
          <asp:GridView ID="GridView1" runat="server">
      </asp:GridView>
      </CENTER>
      
  </div>
</div>
   <div class="panel panel-info">
  <div class="panel-heading">
      <center><h3 class="panel-title">COTIZACIONES</h3</center>>
  </div>
  <div class="panel-body">
      Precio&nbsp;
      <asp:TextBox ID="precio" runat="server" Width="165px"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="pn" runat="server" ControlToValidate="precio" Display="Dynamic" ErrorMessage="Solo se aceptan numeros" ForeColor="#FF3300" SetFocusOnError="True" ValidateRequestMode="Enabled" ValidationExpression="^\d+(\.\d\d)?$"></asp:RegularExpressionValidator>
&nbsp;US $<br />
      <br />
      Peso&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="peso" runat="server"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="pen" runat="server" ControlToValidate="peso" Display="Dynamic" ErrorMessage="Solo se aceptan numeros" ForeColor="#FF3300" ValidateRequestMode="Enabled" ValidationExpression="^\d+(\.\d\d)?$"></asp:RegularExpressionValidator>
&nbsp;Libras<br />
      <br />
      Tipo&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:DropDownList ID="DropDownList1" runat="server">
      </asp:DropDownList>
      <br />
      <br />

    <center>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cotizar" ValidateRequestMode="Enabled" />
    </center>
      <asp:Label ID="error" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#FF3300" Text="Debe llenar todos los campos para poder cotizar" Visible="False"></asp:Label>
      <br />
      EL PRECIO DEL PRODUCTO ES DE: <asp:Label ID="total" runat="server" BorderColor="White" ForeColor="White" Visible="False"></asp:Label>
      <br />
      
  </div>
        

    </form>
</body>
</html>
