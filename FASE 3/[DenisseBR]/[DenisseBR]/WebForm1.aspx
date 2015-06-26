<%@ Page Title="[INICIO]" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true"  CodeBehind="WebForm1.aspx.cs" Inherits="_DenisseBR_.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="x" runat="server" >
    <link href="Content/bootstrap.css" rel="stylesheet" />
<div style="text-align:center" >
      <br />
      <br />
      <br />
      <br />
      <br />
    <asp:Button ID="log" runat="server" CssClass="btn-info active" Font-Bold="True" Font-Size="X-Large" OnClick="Button1_Click" Text="INICIAR SESION" />
    <asp:Button ID="regis" runat="server" CssClass="btn-info disabled focus" Font-Bold="True" Font-Size="X-Large" OnClick="Button2_Click" Text="REGISTRAR" />

    
    <asp:Button ID="cot" runat="server" CssClass="btn-info disabled active" Font-Bold="True" Font-Size="X-Large" OnClick="cot_Click" Text="COTIZAR" />

    
</div>
<div style="text-align:center">
    <asp:Panel ID="Panel1" runat="server">
         <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Precio  " Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="precio" runat="server" Width="129px"></asp:TextBox>
        &nbsp;US $<br />
        <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Peso"></asp:Label>
&nbsp;
         <asp:TextBox ID="peso" runat="server" Width="129px"></asp:TextBox>
         &nbsp;Libras<br />
         <br />
         <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Tipo"></asp:Label>
         &nbsp;
        <asp:DropDownList ID="ddt" runat="server" Width="131px" Height="30px" Font-Size="Medium">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="cotizar" runat="server" CssClass="btn-success" Height="46px" Text="Cotizar" Width="105px" OnClick="cotizar_Click" />


        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
       
        <br />
        </asp:Panel>

    
    </div>
    <div style="text-align:center">
        <asp:Panel ID="Panel2" runat="server">
            <br />
            <asp:Label ID="Label6" runat="server" Font-Size="X-Large" Text="Bienvenido!"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Usuario: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="usuario" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Contraseña: "></asp:Label>
            <asp:TextBox ID="passw" runat="server" CssClass="text-info" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="msj" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300"></asp:Label>
            <br />
            <br />
            <asp:Button ID="logIn" runat="server" CssClass="btn" ForeColor="Black" Text="Iniciar Sesion" OnClick="logIn_Click" />
         
            <br />
         
            <br />
         
    </asp:Panel>

<div style="text-align:center">
    <asp:Panel ID="Panel3" runat="server">
        <br />
        <br />
        <br />


    </asp:Panel>
</div>
    </div>
</asp:Content>
