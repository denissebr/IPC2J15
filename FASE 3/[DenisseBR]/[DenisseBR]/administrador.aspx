<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="administrador.aspx.cs" Inherits="_DenisseBR_.administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">
    <div style="text-align:center">
        <asp:Panel ID="Panel1" runat="server" Height="123px" CssClass="panel">
         &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="BIENVENIDO"></asp:Label>
            <br />
            <asp:Label ID="userEmp" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Director de: "></asp:Label>
      
            <asp:Label ID="depto" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
      
            <br />
            <asp:Button ID="logOut" runat="server" CssClass="btn-link" OnClick="logOut_Click" Text="Cerrar Sesion" />
      
    </asp:Panel>
    </div>
   <div style="text-align:center">

       <asp:Button ID="carga" runat="server" Text="CARGA MASIVA" CssClass="btn" OnClick="carga_Click" />
       <asp:Button ID="Button2" runat="server" Text="REPORTE 1" CssClass="btn" OnClick="Button2_Click" />
       <asp:Button ID="Button3" runat="server" Text="REPORTE 2" CssClass="btn" OnClick="Button3_Click" />
       <asp:Button ID="Button4" runat="server" Text="REPORTE 3" CssClass="btn" OnClick="Button4_Click" />
       <asp:Button ID="Button5" runat="server" Text="REPORTE 4" CssClass="btn" />
       <asp:Button ID="Button6" runat="server" Text="REPORTE 5" CssClass="btn" OnClick="Button6_Click" />

       <asp:Button ID="Button7" runat="server" CssClass="btn" Text="REPORTE 6" />

   </div>

    <div>
        <asp:Panel ID="cargaMas" runat="server" Height="322px" Visible="False">
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Seleccione el archivo: "></asp:Label>
            <asp:FileUpload ID="cate" runat="server" />
            <br />
            <asp:Button ID="Button8" runat="server" Text="Cargar Categoria" OnClick="Button8_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Seleccionar Archivo:"></asp:Label>
            <br />
            <asp:FileUpload ID="cntra" runat="server" />
            <br />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Contratacion" />
            <br />

        </asp:Panel>
    </div>
</asp:Content>
