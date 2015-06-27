<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="actualizar.aspx.cs" Inherits="_DenisseBR_.actualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">
    <div style="text-align:center">
    <asp:Panel ID="Panel3" runat="server">
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="btn" OnClick="Button1_Click" Text="Obtener datos" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" Text="Apellido:"></asp:Label>
        &nbsp;<asp:TextBox ID="apellido" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="DPI: "></asp:Label>
        <asp:TextBox ID="DPI" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Medium" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="telefono" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Medium" Text="NIT: "></asp:Label>
        <asp:TextBox ID="nit" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Medium" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="direccion" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="txtuser" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="Medium" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sucursal: "></asp:Label>
        <asp:DropDownList ID="dds" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="update" runat="server" CssClass="btn" OnClick="regitrarUs_Click" Text="Actualizar Datos" />
        <br />
        <br />
        <asp:Label ID="msjerrus" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300"></asp:Label>
        <asp:Label ID="msjsi" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CCFF33"></asp:Label>
        <br />
        <br />
        <br />
        </asp:Panel>
        </div>


</asp:Content>
