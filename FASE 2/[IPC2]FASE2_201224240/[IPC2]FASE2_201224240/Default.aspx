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
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Distinctio, fugit nobis qui temporibus culpa inventore consectetur aliquam. Unde, itaque, quos, laboriosam, reprehenderit ipsa deleniti sequi animi eveniet dolorem maiores alias. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Id, aperiam, optio, magnam sed aliquam harum sunt ad est velit ipsam ratione quo perferendis! Suscipit necessitatibus reiciendis nobis nam non est. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Fugit, quis, iste expedita quo soluta maxime voluptas delectus quod quaerat repudiandae perspiciatis voluptatum tempore natus eum veritatis atque voluptates ea illo?
            </li>
            <li>
                <h2>Cotizacion</h2>
                Precio&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                US $<br />
                <br />
                Peso
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
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                Contraseña <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Iniciar Sesion" />
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
