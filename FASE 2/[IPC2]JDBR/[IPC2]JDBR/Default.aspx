<%@ Page Title="Quetzal Express" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_IPC2_JDBR._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
<head>

<!-- title and meta -->
<meta charset="utf-8" />
<meta name="viewport" content="width=device-width,initial-scale=1.0" />
<meta name="description" content="A neat and simple tabbed content area with CSS and jQuery" />
<title>Simple Tabbed Content Area with CSS and jQuery</title>
    
<!-- css -->
<link href='http://fonts.googleapis.com/css?family=Ubuntu:300,400,700,400italic' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Oswald:400,300,700' rel='stylesheet' type='text/css'>
<link rel="stylesheet" href="Content/base.css" />
<link rel="stylesheet" href="Content/style.css" />
    
<!-- js -->
<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/modernizr.js"></script>
<script src="Scripts/tabs.js"></script>


</head>



<body>

<div id="wrapper">

    <!-- /#top-bar -->

<header>
    <div id="title" class="container">
        <h1>QUETZAL EXPRESS</h1>
        <h2>La mejor experiencia en importacion de paquetes</h2>
    </div>
</header><!-- /header -->


<div id="main">
    <div class="container">
        <ul id="tabs">
            <li >INICIO DE SESION</li>
            <li class="active">COTIZAR PRODUCTO</li>
            <li >REGISTRARSE</li>
        </ul>
        <ul id="tab">
            <li >
                <h2>BIENVENIDO</h2>
                <asp:Login ID="Login1" runat="server">
                    <LayoutTemplate>
                        <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                            <tr>
                                <td>
                                    <table cellpadding="0">
                                        <tr>
                                            <td align="center" colspan="2">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:CheckBox ID="RememberMe" runat="server" Text="Recordármelo la próxima vez." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2" style="color:Red;">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" colspan="2">
                                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" OnClick="LoginButton_Click" Text="Inicio de sesión" ValidationGroup="Login1" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                </asp:Login>
                <br />
            </li>
            <li class="active">
                <h2>PRECIO DE PRODUCTO</h2>
                <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label>
                &nbsp;
                <asp:TextBox ID="costo" runat="server"></asp:TextBox>
&nbsp;US $<br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Peso"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="peso" runat="server"></asp:TextBox>
                Libras<br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Tipo"></asp:Label>
            &nbsp;&nbsp; &nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="cotizar" runat="server" Text="Cotizar" OnClick="cotizar_Click" />
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="El precio del producto es: " Visible="False"></asp:Label>
&nbsp;<asp:Label ID="lblprecio" runat="server" Visible="False"></asp:Label>
            </li>
            <li class="active">
                <h2>Usuario Nuevo</h2>
                Nombre&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
                <asp:Label ID="Label6" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                <br />
                <br />
                Apellido&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                <br />
                <br />
                 DPI&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                <br />
                 <br />
                NIT&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                Telefono&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <br />
                Direccion&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                <br />
                Tarjeta&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                <br />
                <br />
                Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                 <br />
                <br />
                Contraseña<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
                 <br />
                <center>
                <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />
                </center>
                 </li>
          
        </ul>
    </div>
</div><!-- #main -->


<footer>
    <p> &copy; <%: DateTime.Now.Year %> -[IPC2]FASE2_JDBR</p>
</footer><!-- /footer -->



</div><!-- /#wrapper -->



</body>  
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>

