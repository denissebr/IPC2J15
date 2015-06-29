<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="empleado.aspx.cs" Inherits="_DenisseBR_.empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">
    <div style="text-align:center">
    <asp:Panel ID="servicioCliente" runat="server" BorderColor="#99FF99" BorderStyle="Solid" Height="1241px" ScrollBars="Auto">
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCFFCC" CssClass="panel-heading" Height="95px">
            &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="BIENVENIDO"></asp:Label>
            <br />
            <asp:Label ID="userEmp" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Servicio al Cliente"></asp:Label>
        </asp:Panel>
        <br />
        <div>

            <asp:Button ID="facturar" runat="server" CssClass="btn" Text="Entrega &amp; Devolucion" OnClick="facturar_Click" />
            <asp:Button ID="devolucion" runat="server" CssClass="btn" Text="Devolucion" OnClick="devolucion_Click" />
            <asp:Button ID="buscar" runat="server" CssClass="btn" Text="Buscar" OnClick="buscar_Click" />

            <asp:Button ID="aprc" runat="server" CssClass="btn" Text="Aprobar Cliente" OnClick="aprc_Click" />

        </div>
        <br />
        <asp:Panel ID="eyf" runat="server" Height="240px">
            <br />
            Numero de casilla:
            <asp:TextBox ID="casilla" runat="server" Width="144px"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="factura" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
            <br />
            <asp:Button ID="deliver" runat="server" Text="Entregar" />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="dev" runat="server">
            <br />
            <asp:Label ID="Label4" runat="server" Text="Numero de paquete: "></asp:Label>
            <asp:TextBox ID="paqueteNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="devolver" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" HorizontalAlign="Center">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
                <br />
            <asp:Button ID="devolverBtn" runat="server" OnClick="Button1_Click" Text="Devolver" />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="bus" runat="server" Height="228px">
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Ingrese datos del cliente: "></asp:Label>
            <asp:TextBox ID="datosc" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="buscarC" runat="server" Text="Buscar" OnClick="buscarC_Click" />
            <br />
            <br />
            
            <asp:GridView ID="buscarcliente" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
          
        </asp:Panel>
        <asp:Panel ID="aprovar" runat="server" Height="578px">
            <br />
            <br />
            &nbsp;
            <br />
            <asp:GridView ID="inactivos" runat="server" CellPadding="2" ForeColor="Black" GridLines="None" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CssClass="table-condensed" OnSelectedIndexChanged="inactivos_SelectedIndexChanged" HorizontalAlign="Center" >
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                </Columns>
                <EmptyDataTemplate>
                    NO HAY DATOS QUE MOSTRAR
                </EmptyDataTemplate>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" ForeColor="Black" BorderColor="Black" BorderStyle="Solid" CssClass="table" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
            <br />
            <asp:Label ID="msjAcc" runat="server" Font-Bold="True" Font-Size="Large" Visible="False"></asp:Label>
        </asp:Panel>
        </asp:Panel>
</div>

    <div style="text-align:center">

            
    <asp:Panel ID="bodega" runat="server" BorderColor="#CCCCFF" BorderStyle="Solid" Height="597px">
        <asp:Panel ID="Panel3" runat="server" BackColor="#CCCCFF" CssClass="panel-heading" Height="64px">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Bodegas"></asp:Label>
            <br />
        </asp:Panel>
        <br />
        
        <br />
    </asp:Panel>


        <asp:Panel ID="paquetes" runat="server" BorderColor="#CCFF33" BorderStyle="Solid" Height="149px">
            <asp:Panel ID="Panel4" runat="server" BackColor="#CCFF33" Height="71px" style="margin-right: 0px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Paquetes"></asp:Label>
            </asp:Panel>
            <br />
            <div>

            <asp:Button ID="rp" runat="server" CssClass="btn" Text="Registrar Paquete" />
            <asp:Button ID="ap" runat="server" CssClass="btn" Text="Añadir Paquete" />
            <asp:Button ID="ep" runat="server" CssClass="btn" Text="Estados de Paquete" />

            </div>
            <br />
            <br />
            <br />
        </asp:Panel>


    </div>



</asp:Content>
