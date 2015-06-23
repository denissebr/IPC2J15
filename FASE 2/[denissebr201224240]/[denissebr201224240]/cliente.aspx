<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="_denissebr201224240_.cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>QUETZAL EXPRESS-[CLIENTE]</title>
    <style type="text/css">
        .auto-style2 {            height: 41px;
        }
        .auto-style11 {
            width: 363px;
            height: 40px;
        }
        .auto-style12 {
            height: 40px;
            width: 364px;
        }
        .auto-style14 {
            width: 363px;
            height: 39px;
        }
        .auto-style15 {
            height: 39px;
            width: 364px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <div class="panel panel-success">
  <div class="panel-heading" >
    <center>
    <h3 class="panel-title">PERFIL DE USUARIO</h3>
    </center>
    <br />
    <br />
      <right>
      <asp:Label ID="Label1" runat="server" Text="Bienvenido   " Font-Size="Large"></asp:Label><asp:Label ID="username" runat="server" Font-Size="Large"></asp:Label>
      </right>
       <br />
      <right>
      <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/modi.aspx" Font-Size="Medium" ForeColor="#660066">Editar Perfil</asp:HyperLink>
      </right>
  </div>
  <div class="panel-body">
      <asp:Panel ID="Panel1" runat="server" BorderColor="#CC66FF" BorderStyle="Groove" Height="249px" ScrollBars="Auto">
          <asp:Panel ID="Panel2" runat="server" BackColor="#CC66FF" Height="40px">
              <CENTER>
              <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="COTIZADOR"></asp:Label>
         </CENTER>
              <br />
              <br />
              <center>
                   <asp:Label ID="Label3" runat="server" Text="Precio: "></asp:Label>
              <asp:TextBox ID="precio" runat="server" Width="159px"></asp:TextBox>
              <asp:Label ID="Label5" runat="server" Text=" US$"></asp:Label>
              <br />
              <br />
              <asp:Label ID="Label6" runat="server" Text="Peso  "></asp:Label>
              &nbsp;&nbsp;
              <asp:TextBox ID="peso" runat="server" Width="160px"></asp:TextBox>
              <asp:Label ID="Label7" runat="server" Text=" libras"></asp:Label>
              <br />
              <br />
              <asp:Button ID="cotizar" runat="server" Text="COTIZAR" OnClick="cotizar_Click" />
                   &nbsp;<br />
                   <br />
                   <asp:Label ID="Label17" runat="server" Text="El precio del producto es:  "></asp:Label>
                   <asp:Label ID="precioF" runat="server"></asp:Label>
              </center>
                   </asp:Panel>
      </asp:Panel>
    <br />
      <asp:Panel ID="Panel3" runat="server" Height="273px" ScrollBars="Auto" BorderColor="Aqua" BorderStyle="Groove">
          <asp:Panel ID="Panel4" runat="server" BackColor="Aqua" Height="38px">
              <CENTER>
             <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="ESTADO DE PEDIDOS"></asp:Label>
          </CENTER>

                  </asp:Panel>
          <br />
          <br />

          <CENTER>

          
          <asp:GridView ID="GridView1" runat="server">
          </asp:GridView>
          </CENTER>
          
      </asp:Panel>
      <br />
      <asp:Panel ID="Panel5" runat="server" BorderColor="#FF6600" BorderStyle="Groove" Height="355px">
          <asp:Panel ID="Panel6" runat="server" BackColor="#FF6600" Height="42px">
              <CENTER>
                  <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="X-Large" Text="CREAR PEDIDO" ForeColor="White"></asp:Label>
              </CENTER>
              </asp:Panel>
          <br />
          <table align="center" class="table-hover">
              <tr>
                  <td class="auto-style14">PRECIO</td>
                  <td class="auto-style15">
                      <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style14">
                      <asp:Label ID="Label13" runat="server" Text="PESO"></asp:Label>
                  </td>
                  <td class="auto-style15">
                      <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style14">
                      <asp:Label ID="Label14" runat="server" Text="NOMBRE"></asp:Label>
                  </td>
                  <td class="auto-style15">
                      <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style14">
                      <asp:Label ID="Label15" runat="server" Text="DESCRIPCION"></asp:Label>
                  </td>
                  <td class="auto-style15">
                      <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style11">
                      <asp:Label ID="Label16" runat="server" Text="TIPO"></asp:Label>
                  </td>
                  <td class="auto-style12">
                      <asp:DropDownList ID="DropDownList1" runat="server">
                      </asp:DropDownList>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style2" colspan="2" style="align-items:CENTER">

                      <asp:Button ID="boton" runat="server" ForeColor="Black" Text="CREAR PEDIDO" />
                  </td>
              </tr>
          </table>
                </asp:Panel>
      <br />
      <br />

  </div>
</div>
    </form>
</body>
</html>
