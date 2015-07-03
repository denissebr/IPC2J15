<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="director.aspx.cs" Inherits="_DenisseBR_.director" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">

    <div style="text-align:center">
        <asp:Panel ID="Panel1" runat="server" Height="84px" CssClass="panel">
         &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="BIENVENIDO"></asp:Label>
            <br />
            <asp:Label ID="userEmp" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Director de: "></asp:Label>
      
            <asp:Label ID="depto" runat="server"></asp:Label>
      
    </asp:Panel>
        </div>
        <br />
    <div style="text-align:center">

        <asp:Button ID="contratacion" runat="server" CssClass="btn" Text="Contratacion" OnClick="contratacion_Click" />
        <asp:Button ID="equipo" runat="server" CssClass="btn" Text="Consultar Equipo" OnClick="equipo_Click" />
        <asp:Button ID="despedir" runat="server" CssClass="btn" Text="Despedir Empleado" OnClick="despedir_Click" />
        <br />

    </div>
    <br />
    <div style="text-align:center">

        <asp:Panel ID="pnldespedir" runat="server" Height="237px" ScrollBars="Auto">
            <br />
            <asp:GridView ID="despedirGV" runat="server" HorizontalAlign="Center" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" CssClass="tab-content" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="despedirGV_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Despedir" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
            <br />
        </asp:Panel>
        <asp:Panel ID="pnlcontra" runat="server" Height="192px">
            <br />
            <asp:Label ID="Label7" runat="server" Text="Seleccione el archivo:" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <center>
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="btn" ForeColor="Black" />
            </center>
                <br />
            <asp:Button ID="cargar" runat="server" CssClass="btn" Text="Cargar Datos" />
            <br />
            <br />
            <asp:Label ID="msjcs" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CCFF33" Text="Contratacion Exitosa" Visible="False"></asp:Label>
            <asp:Label ID="msjcn" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red" Text="Error en la carga de archivos" Visible="False"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="ConsultarEquipo" runat="server" Height="898px" ScrollBars="Auto">
            <br />
            <asp:GridView ID="generalGV" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" CssClass="table" OnSelectedIndexChanged="generalGV_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Ver Perfil Individual" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle Font-Bold="True" ForeColor="Black" BorderColor="#00FFCC" BorderStyle="Dotted" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
            <br />
            <br />
            <asp:Panel ID="individual" runat="server" Height="498px">
                <br />
                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label18" runat="server" Text="Codigo Empleado: "></asp:Label>
                <asp:TextBox ID="cod" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="Nombre:"></asp:Label>
                &nbsp;<asp:TextBox ID="nom" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Text="Apellido:"></asp:Label>
                &nbsp;
                <asp:TextBox ID="ape" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label12" runat="server" Text="Telefono: "></asp:Label>
                &nbsp;<asp:TextBox ID="tel" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label13" runat="server" Text="Sueldo:"></asp:Label>
                &nbsp;<asp:TextBox ID="sueldo" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label14" runat="server" Text="Direccion: "></asp:Label>
                &nbsp;<asp:TextBox ID="direc" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label15" runat="server" Text="Usuario: "></asp:Label>
                <asp:TextBox ID="usuarioEmp" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label16" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label17" runat="server" Text="Departamento: "></asp:Label>
                <asp:DropDownList ID="ddd" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="btnmod" runat="server" Text="Modificar Contratacion" OnClick="btnmod_Click" />
                <asp:Button ID="btng" runat="server" Text="Guardar Cambios" Visible="False" Enabled="False" OnClick="btng_Click" />
                <br />
                <br />
            </asp:Panel>
        </asp:Panel>
        <br />

    </div>

</asp:Content>
