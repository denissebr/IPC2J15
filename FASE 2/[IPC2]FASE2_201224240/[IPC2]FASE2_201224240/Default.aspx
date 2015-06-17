<%@ Page Title="QUTEZAL EXPRESS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_IPC2_FASE2_201224240._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">

<link href='http://fonts.googleapis.com/css?family=Ubuntu:300,400,700,400italic' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Oswald:400,300,700' rel='stylesheet' type='text/css'>
<link rel="stylesheet" href="Content/base.css" />
<link rel="stylesheet" href="Content/style.css" />
    
<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/modernizr.js"></script>
<script src="Scripts/tabs.js"></script>




<head>


</head>
    <body>

        <div id="wrapper">

            <header>
                <div id="title" class="container">
                    <h1>QUETZAL EXPRESS</h1>
        <h2>La mejor forma de transportar sus pedidos internacionales</h2>
    </div>
</header><!-- /header -->


<div id="main">
    <div class="container">
        <ul id="tabs">
            <li class="active">Inicio</li>
            <li>Cotizar</li>
            <li>Iniciar Sesion</li>
            <li>Registrar</li>
        </ul>
        <ul id="tab">
            <li class="active">
                <h2>QUETZAL EXPRESS</h2>
                somos una empresa confiable cuya finalidad es brindar el mejor servicio de paqueteria internacional. Por el momento solo contamos con sedes en USA y Guatemala pero esperamos muy pronto expandir nuestro servicio por toda Centro America.<br />
                Para poder mandar a traer sus paquetes debe registrarse con nosotros. Tratamos de mantener los precios mas bajos del mercado en cuanto a importacion. Esperamos que su experiencia sea nada menos que excelente.</li>
            <li>
                <h2>Cotizacion</h2>
                Precio&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                US $<br />
                <br />
                Peso&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                Libras<br />
                <br />
                Tipo&nbsp;
                <asp:ListBox ID="ListBox1" runat="server" Height="25px" Width="225px"></asp:ListBox>
                </li>
            <li>
                <h2>Bienvenido</h2>
                <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="us" runat="server"></asp:TextBox>
                <br />
                <br />
                Contraseña <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Iniciar Sesion" OnClick="Button1_Click" />
           </li>
            <li >
                <h2>Registro</h2>
                <table class="nav-justified">
                    <tr>
                        <td class="auto-style1">NOMBRE</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="nombre" runat="server" Width="457px"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">APELLIDO</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="apellido" runat="server" Width="457px"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">NIT</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="nit" runat="server" TextMode="Number" Width="457px"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">TELEFONO</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="tel" runat="server" TextMode="Phone" Width="457px"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">DIRECCION</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="dir" runat="server" Width="457px"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">No. TARJETA</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="tarjeta" runat="server" TextMode="Number" Width="457px"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">DPI</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="dpi" runat="server" TextMode="Number" Width="457px"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">CORREO</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="mail" runat="server" TextMode="Email" Width="457px"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">CONTRASEÑA </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="con" runat="server" TextMode="Password" Width="457px"></asp:TextBox>
                            <br />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Button ID="reg" runat="server" Text="Registrar" OnClick="reg_Click" />
            </li>
           
        </ul>
    </div>
</div><!-- #main -->


<footer>
</footer><!-- /footer -->



</div><!-- /#wrapper -->


</body>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 113px;
        }
        .auto-style2 {
            width: 340px;
        }
    </style>
</asp:Content>

