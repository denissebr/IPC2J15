<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="administrador.aspx.cs" Inherits="_IPC2_JDBR.administrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>ADMINISTRADOR</title>
</head>
<body>
    <form id="form1" runat="server">
   <div class="panel panel-success">
  <div class="panel-heading" style="text-align:center">
    <h3 class="panel-title">ADMINISTRADOR</h3>
  </div>
  <div class="panel-body">
      <br />
      <asp:Panel ID="carga" runat="server" BorderColor="#FF0066" BorderStyle="Solid" Height="225px">
          <asp:Panel ID="pcm" runat="server" BackColor="#FF0066" Height="40px">
              <center>
              <asp:Label ID="Label1" runat="server" Text="CARGA MASIVA" Font-Bold="True" Font-Size="Medium" ForeColor="White"></asp:Label>
                  </center>
          </asp:Panel>
          <center style="height: 295px">

              Seleccione el archivo:
              <asp:FileUpload ID="FileUpload1" runat="server" />
              
               <asp:RadioButtonList ID="lista" runat="server" AutoPostBack="True">
                  <asp:ListItem>Empleado</asp:ListItem>
                  <asp:ListItem>Impuesto</asp:ListItem>
              </asp:RadioButtonList>
              
              <br />
              <asp:Button ID="cargar" runat="server" OnClick="cargar_Click" Text="Cargar" />
                   
          </center>

          <br />

      </asp:Panel>
      <br />
      <br /><br />
      <br />
      <br />
      <br />
    
  </div>
</div>
    </form>
</body>
</html>
