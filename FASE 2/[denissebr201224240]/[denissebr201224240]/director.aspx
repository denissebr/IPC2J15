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
    <h3 class="panel-title">BIENVENIDO DIRECTOR</h3>
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
      <asp:Panel ID="Panel5" runat="server" BorderColor="#CC99FF" BorderStyle="Double" Height="172px" ScrollBars="Auto">
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
          <asp:GridView ID="GridView2" runat="server">
          </asp:GridView>
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

