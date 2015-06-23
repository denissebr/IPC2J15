<%@ Page Title="" Language="C#" MasterPageFile="~/masterP.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_denissebr201224240_.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/base.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
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
            <li class="active">INICIO DE SESION</li>
            <li >REGISTRARSE</li>
        </ul>
        <ul id="tab">
            <li class="active">
                <h2>BIENVENIDO</h2>
                <br />
                <br />
               
                <left>
                   <asp:Label ID="Label10" runat="server" Text="Usuario"></asp:Label>  
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; </left>
                <asp:TextBox ID="user" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" Text="Contraseña"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="passw" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <center>
                <asp:Button ID="login" runat="server" Text="Iniciar Sesion" OnClick="Button2_Click" />
                    </center>
                <br />
                <asp:Label ID="error" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red" Text="DATOS INVALIDOS" Visible="False"></asp:Label>
                <br />
                <br />
            </li>
            <li >
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
    <p> &copy; <%: DateTime.Now.Year %>-[IPC2]FASE2_JDBR</p>
</footer><!-- /footer -->



</div><!-- /#wrapper -->



</body>  

</asp:Content>
