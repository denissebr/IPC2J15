<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="empleado.aspx.cs" Inherits="_DenisseBR_.empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
            background-color: #FFFFFF;
        }
        .auto-style3 {
        }
        .auto-style4 {
            width: 462px;
        }
        .auto-style5 {
            width: 228px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="x" runat="server">
    <div style="text-align: center">
         <asp:Panel ID="Panel1" runat="server" CssClass="panel" Height="143px" >
            &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="BIENVENIDO"></asp:Label>
            <br />
            <asp:Label ID="userEmp" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Departamento: "></asp:Label>
             <asp:Label ID="dept" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
             <br />
             <asp:Button ID="logOut" runat="server" CssClass="btn-link" OnClick="logOut_Click" Text="Cerrar Sesion" />
        </asp:Panel>
    </div>
    <div style="text-align:center">
    <asp:Panel ID="servicioCliente" runat="server" Height="1332px" ScrollBars="Auto" style="margin-top: 0px">
       
        <br />
        <div>

            <asp:Button ID="facturar" runat="server" CssClass="btn" Text="Entrega &amp; Facturacion" OnClick="facturar_Click" />
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
            &nbsp;<asp:Button ID="btncasdev" runat="server" CssClass="btn" Text="Buscar casilla" />
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
            <asp:Button ID="devolverBtn" runat="server" OnClick="devolverBtn_Click" Text="Devolver" />
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
            
            <asp:GridView ID="buscarcliente" runat="server" CellPadding="4" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
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
          
        </asp:Panel>
        <asp:Panel ID="aprovar" runat="server" Height="646px">
            <br />
            <br />
            &nbsp;
            <br />
            <asp:GridView ID="inactivos" runat="server" CellPadding="2" ForeColor="Black" GridLines="None" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CssClass="table-condensed" OnSelectedIndexChanged="inactivos_SelectedIndexChanged" HorizontalAlign="Center"  >
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="Aprobar" />
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

            
    <asp:Panel ID="bodega" runat="server" Height="1115px" ScrollBars="Auto">
        
        <br />
        <div>
            <asp:Button ID="btnprecarga" runat="server" CssClass="btn" OnClick="Button1_Click1" Text="Precio de Precarga" />
            <asp:Button ID="Button2" runat="server" Text="Button" />
            <asp:Button ID="Button3" runat="server" Text="Button" />
            <asp:Panel ID="pnlprecar" runat="server" Height="405px" Visible="False">
                <br />
                <asp:GridView ID="precargaGV" runat="server" CellPadding="4" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="IdPaquete" DataSourceID="precarga" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="IdPaquete" HeaderText="IdPaquete" InsertVisible="False" ReadOnly="True" SortExpression="IdPaquete" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                        <asp:ImageField DataImageUrlField="PrecioF" HeaderText="Precio Foto">
                        </asp:ImageField>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    </Columns>
                    <EmptyDataTemplate>
                        NO HAY PAQUETES PARA PRECARGAR EL PRECIO.
                    </EmptyDataTemplate>
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
                <asp:SqlDataSource ID="precarga" runat="server" ConnectionString="<%$ ConnectionStrings:Fase3V1ConnectionString %>" SelectCommand="SELECT [IdPaquete], [Nombre], [Descripcion], [PrecioF], [Precio] FROM [Paquete] WHERE ([IdEstado] = @IdEstado)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="2" Name="IdEstado" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:Label ID="Label8" runat="server" Text="IdPaquete: " Visible="False"></asp:Label>
                <asp:TextBox ID="idpa" runat="server" ReadOnly="True" Visible="False" Width="87px" AutoCompleteType="Disabled"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="Precio: " Visible="False"></asp:Label>
                <asp:TextBox ID="precio" runat="server" Visible="False"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="apr" runat="server" OnClick="apr_Click" Text="Ingresar Precio" Visible="False" Height="29px" />
                <br />
                <br />
                <br />
                               
            </asp:Panel>
        </div>       
    </asp:Panel>
               <div>
                <asp:Panel ID="paquetes" runat="server" Height="754px">
                    <br />
                    <div style="text-align:center">
                        <asp:Button ID="rp" runat="server" CssClass="btn" Text="Registrar Paquete" OnClick="rp_Click" />
                        <asp:Button ID="ap" runat="server" CssClass="btn" Text="Crear Lote" OnClick="ap_Click" />
                        <asp:Button ID="ep" runat="server" CssClass="btn" Text="Estados de Paquete" />
                    </div>
                    <br />
                    <br />
                    <br />
                    <asp:Panel ID="registro" runat="server" Visible="False">
                        <table align="center" cellpadding="2" cellspacing="3" class="auto-style1">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#666666" Text="REGISTRO DE PAQUETES"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="Label11" runat="server" ForeColor="#666666" Text="Seleccionar Archivos"></asp:Label>
                            </td>
                            <td class="auto-style4">
                                <asp:FileUpload ID="regisF" runat="server" ForeColor="#666666" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3" colspan="2">
                                <asp:Button ID="btnC" runat="server" Text="Cargar" Font-Bold="True" ForeColor="#666666" OnClick="btnC_Click" />
                            </td>
                        </tr>
                    </table>

                    </asp:Panel>
                     <br />
                    <br />
                    <br />
                        <div>
                            <asp:Panel ID="lote" runat="server" Height="220px">
                                <br />
                                <asp:TextBox ID="fechatxt" runat="server" AutoCompleteType="Disabled" TextMode="Date"></asp:TextBox>
                                <br />
                                <br />
                                <asp:DropDownList ID="ddsucr" runat="server">
                                </asp:DropDownList>
                                <br />
                                <br />
                                <asp:Button ID="crearLot" runat="server" BorderColor="#FFCC99" BorderStyle="Solid" CssClass="btn" OnClick="crearLot_Click" Text="Button" />
                            </asp:Panel>
                        </div>
                </asp:Panel>
           </div>

    </div>



</asp:Content>
