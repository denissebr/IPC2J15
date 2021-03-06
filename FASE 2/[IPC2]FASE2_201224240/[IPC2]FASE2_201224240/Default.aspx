﻿<%@ Page Title="QUTEZAL EXPRESS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_IPC2_FASE2_201224240._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
<!DOCTYPE html>
<html lang="en" class="no-js">

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

<div id="top-bar">
    <div class="container clearfix">
        <span class="all-labs"><a href="http://callmenick.com/">&larr; all labs</a></span>
        <span class="back-to-tutorial"><a href="http://callmenick.com/post/simple-tabbed-content-area-with-css-and-jquery">back to the tutorial</a></span>
    </div>
</div><!-- /#top-bar -->

<header>
    <div id="title" class="container">
        <h1>Tabbed Content with CSS and jQuery</h1>
        <h2>A neat and simple tabbed content area with CSS and jQuery</h2>
    </div>
</header><!-- /header -->


<div id="main">
    <div class="container">
        <ul id="tabs">
            <li class="active">Tab 1</li>
            <li>Tab 2</li>
            <li>Tab 3</li>
            <li>Tab 4</li>
            <li>Tab 5</li>
        </ul>
        <ul id="tab">
            <li class="active">
                <h2>This is the first tab</h2>
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Distinctio, fugit nobis qui temporibus culpa inventore consectetur aliquam. Unde, itaque, quos, laboriosam, reprehenderit ipsa deleniti sequi animi eveniet dolorem maiores alias. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Id, aperiam, optio, magnam sed aliquam harum sunt ad est velit ipsam ratione quo perferendis! Suscipit necessitatibus reiciendis nobis nam non est. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Fugit, quis, iste expedita quo soluta maxime voluptas delectus quod quaerat repudiandae perspiciatis voluptatum tempore natus eum veritatis atque voluptates ea illo?
            </li>
            <li>
                <h2>This is the second tab</h2>
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Distinctio, fugit nobis qui temporibus culpa inventore consectetur aliquam. Unde, itaque, quos, laboriosam, reprehenderit ipsa deleniti sequi animi eveniet dolorem maiores alias. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Alias, pariatur, laborum, sit molestiae eos itaque iste repudiandae eum aperiam ad sapiente dicta reprehenderit. Omnis culpa harum blanditiis voluptates explicabo quis?
            </li>
            <li>
                <h2>Tab number three wee hee</h2>
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Distinctio, fugit nobis qui temporibus culpa inventore consectetur aliquam. Unde, itaque, quos, laboriosam, reprehenderit ipsa deleniti sequi animi eveniet dolorem maiores alias. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vitae, quod mollitia iusto non sapiente ipsa dicta quis perspiciatis voluptates ducimus. Aliquid, voluptatem non necessitatibus dolor nostrum a earum rerum ex. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aspernatur, unde, iusto, consectetur, cumque cum illum eligendi necessitatibus molestiae aut odit nostrum laborum accusantium enim! Minima, delectus porro non consequuntur quos.
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

<script type="text/javascript">
    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-34160351-1']);
    _gaq.push(['_trackPageview']);
    (function () {
        var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
    })();
</script>

<script type="text/javascript" src="//cdn.fusionads.net/fusion.js?zoneid=1332&serve=C6SDP2Y&placement=callmenickcom" id="_fusionads_js"></script>
<script>
    var interval = setInterval(function () {

        // check for when fusionads shows up in DOM
        var fusionad = document.getElementById("fusionads");

        if (fusionad) {

            // clear the interval so we stop looping
            clearInterval(interval);

            // add the close ad button
            var closead = document.createElement("a");
            closead.id = "close-fusionad";
            closead.innerHTML = "x";
            closead.href = "#";
            document.body.appendChild(closead);

            // close the ad
            document.getElementById("close-fusionad").addEventListener("click", function (e) {
                e.preventDefault();
                this.remove();
                fusionad.remove();
            });

        }

    }, 100); // check every 100ms
</script>

</body>
</html>


</asp:Content>
