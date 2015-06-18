<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_IPC2_JDBR._Default" %>

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
            <li>INICIO DE SESION</li>
            <li>COTIZAR PRODUCTO</li>
            <li>REGISTRARSE</li>
        </ul>
        <ul id="tab">
            <li class="active">
                <h2>BIENVENIDO</h2>
                <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="us" runat="server"></asp:TextBox>
                <br />
                <br />
                Contraseña&nbsp; <asp:TextBox ID="con" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="login" runat="server" Text="Iniciar Sesion" />
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
                <asp:TextBox ID="peso" runat="server" TextMode="Number"></asp:TextBox>
                Libras<br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Tipo"></asp:Label>
            &nbsp;&nbsp;&nbsp;
                <asp:ListBox ID="ListBox1" runat="server" Height="25px" Width="201px" AutoPostBack="True">
                    <asp:ListItem Value="0">celulares</asp:ListItem>
                    <asp:ListItem Value="0.10">cables</asp:ListItem>
                    <asp:ListItem Value="0.15">consola de video juegos</asp:ListItem>
                </asp:ListBox>
                <br />
                <br />
                <asp:Button ID="cotizar" runat="server" Text="Cotizar" OnClick="cotizar_Click" />
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="El precio del producto es: " Visible="False"></asp:Label>
&nbsp;<asp:Label ID="lblprecio" runat="server" Visible="False"></asp:Label>
            </li>
            <li >
                <h2>Usuario Nuevo</h2>
                <asp:Label ID="Label6" runat="server" Text="Nombre"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Apellido"></asp:Label>
                 <br />
                <br />
                 </li>
            <li>
                <h2>Fourth tab not bad</h2>
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Distinctio, fugit nobis qui temporibus culpa inventore consectetur aliquam. Unde, itaque, quos, laboriosam, reprehenderit ipsa deleniti sequi animi eveniet dolorem maiores alias. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquam, repellendus explicabo recusandae dicta tempore nam perspiciatis atque vero praesentium hic. Laudantium tempore quas consequatur exercitationem eveniet voluptatem reiciendis quidem tenetur! Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vel, repudiandae, natus odio minus voluptates culpa sapiente vitae nulla ad? Distinctio, laboriosam assumenda facilis aspernatur consequuntur praesentium inventore id earum hic!
            </li>
            <li>
                <h2>Tab number five here we go!</h2>
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Distinctio, fugit nobis qui temporibus culpa inventore consectetur aliquam. Unde, itaque, quos, laboriosam, reprehenderit ipsa deleniti sequi animi eveniet dolorem maiores alias. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Neque, a, reprehenderit, quod at quae numquam quaerat delectus eius ex eligendi dolorum sapiente id saepe. Possimus provident porro neque ut pariatur. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rem, velit, unde, pariatur, illo quis tenetur eaque harum similique quos deserunt laborum dolor molestias sint cumque facere consectetur neque! Deleniti, aliquid.
            </li>
        </ul>
    </div>
</div><!-- #main -->


<footer>
</footer><!-- /footer -->



</div><!-- /#wrapper -->



</body>  
</asp:Content>
