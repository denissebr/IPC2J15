<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="director.aspx.cs" Inherits="_IPC2_JDBR.director" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/director.min.css" rel="stylesheet" />
    <link href="Content/director.css" rel="stylesheet" />
    <title>DIRECTOR</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel panel-primary">
  <div class="panel-heading" style="text-align: center">
    <h3 class="panel-title">GESTION DE EMPLEADO</h3>
  </div>
  <div class="panel-body" >
      <asp:Panel ID="csv" runat="server" Height="220px" BorderColor="Black" BorderStyle="Solid"  style="align-content:space-around" ScrollBars="Auto">
          <asp:Panel ID="tirc" runat="server" Font-Bold="True" Font-Size="Medium" ScrollBars="Auto" BackColor="#FFCC99" BorderColor="Black">
              <CENTER>
                  <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="REALIZAR CONTRATACION"></asp:Label>
         </CENTER>

                   </asp:Panel>
          <br />
          <br />
          <center>
          <asp:Label ID="Label6" runat="server" Text="Seleccione el archivo CSV: "></asp:Label>
            </center>
          <br />
          <br />
          <center>
          <asp:FileUpload ID="FileUpload1" runat="server" />
            </center>
          <br />
          <center>
          <asp:Button ID="cargaEmpleado" runat="server" Text="Cargar Archivo" OnClick="cargaEmpleado_Click" />
      </center>
              </asp:Panel>
      <br />
      <%--<br />--%>
      <asp:Panel ID="consultarEquipo" runat="server" Height="188px" BorderColor="Black" BorderStyle="Solid" ScrollBars="Auto" style="margin-top: 0px">
          <asp:Panel ID="pce" runat="server" BackColor="#CCFFFF">
              <CENTER>
              <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="CONSULTAR EQUIPO"></asp:Label>
              </CENTER>
           </asp:Panel>
          <br />
          <br />
          <center>
        <asp:Button ID="consultar" runat="server" Text="Consultar Equipo"  />
          </center>
          <center>
          <asp:GridView ID="GridView1" runat="server">
          </asp:GridView>
              </center>
          
      </asp:Panel>
      <br />
      <br />
      <asp:Panel ID="modificarContratacion" runat="server" Height="154px" BorderColor="Black" BorderStyle="Solid" ScrollBars="Auto">
          <asp:Panel ID="pmc" runat="server" BackColor="#66FF66">
              <center>
              <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="MODIFICAR CONTRATACION"></asp:Label>
          </center>
                  </asp:Panel>
          <br />
          <br />
          <center>

              <asp:Label ID="Label7" runat="server" Text="Ingrese el codigo del empleado: "></asp:Label>
              &nbsp;<asp:TextBox ID="codigoEmp" runat="server"></asp:TextBox>
              <br />
              <br />
              <asp:Button ID="buscar" runat="server" Text="Buscar" />
              <br />
              <br />
              <asp:GridView ID="GridView2" runat="server">
              </asp:GridView>
              <br />
              <br />
              <asp:Button ID="modificar" runat="server" Text="Modificar" />
              <br />
              <br />

          </center>
      </asp:Panel>
      <br />
      <asp:Panel ID="despedir" runat="server" Height="168px" BorderColor="Black" BorderStyle="Solid">
          <asp:Panel ID="pde" runat="server" BackColor="#9999FF">
              <CENTER>
              <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="DESPEDIR EMPLEADO"></asp:Label>
              </CENTER>
          </asp:Panel>
          <br />
          <br />
          <center>

             <asp:Label ID="Label8" runat="server" Text="Ingrese el codigo del empleado: "></asp:Label>
              &nbsp;<asp:TextBox ID="id" runat="server"></asp:TextBox>
              <br />
              <br />
              <asp:Button ID="baja" runat="server" Text="Dar de baja" OnClick="baja_Click" /> 

          </center>
          <br />
          <br />
      </asp:Panel>
  </div>
</div>
    </form>
</body>
</html>
