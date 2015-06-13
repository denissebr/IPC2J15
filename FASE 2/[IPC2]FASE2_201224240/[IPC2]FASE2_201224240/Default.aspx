<%@ Page Title="QUTEZAL EXPRESS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_IPC2_FASE2_201224240._Default" %>

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
 <script src="Scripts/tabs.js"></script>
<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/modernizr.js"></script>



</head>



<body>

<div id="wrapper">

<div id="top-bar">
</div><!-- /#top-bar -->

<header>
    <div id="title" class="container">
        <h1>QUETZAL EXPRESS</h1>
    </div>
</header><!-- /header -->


<div id="main">
    <div class="container">
        <ul id="tabs">
            <li class="active">INICIO</li>
            <li >COTIZAR</li>
            <li >INICIAR SESION</li>
            <li>REGISTRAR</li>
        </ul>
        <ul id="tab">
            <li class="active">
                <h2>RESUMEN DE QUETZAL EXPRESS</h2>
                <h3>HOLA</h3>
                <h4>HOLI</h4>
                <h5>Zzz</h5>
                 </li>
            <li >
            <asp:Label ID="Label2" runat="server" Text="PRECIO"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="201px"></asp:TextBox>&nbsp; <asp:Label ID="Label3" runat="server" Text="US $"></asp:Label>
           
            &nbsp;<br />
                <br />
           
            <asp:Label ID="Label1" runat="server" Text="PESO DEL PAQUETE"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="109px"></asp:TextBox>
           
            &nbsp;Libras<br />
                <br />
           
            <asp:Label ID="Label4" runat="server" Text="TIPO"></asp:Label>&nbsp;&nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="28px" Width="216px">
            <asp:ListItem></asp:ListItem>
                </asp:ListBox>
           
                <br />
                <br />
                TOTAL A PAGAR:
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
           
            </li>
            <li>
                <h2>BIENVENIDO! &nbsp;</h2>
                <asp:Label ID="Label6" runat="server" Text="Usuario"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                Contraseña
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="INICIAR SESION" />
            </li>
            <li>
                <h2>USUARIO NUEVO</h2>
            </li>
        </ul>
    </div>
</div><!-- #main -->


<footer>
</footer><!-- /footer -->



</div><!-- /#wrapper -->


</body>
</asp:Content>
