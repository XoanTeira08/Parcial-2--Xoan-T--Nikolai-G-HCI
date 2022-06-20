<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AdministrarConsulta.aspx.vb" Inherits="Parcial_2__Xoan_T__Nikolai_G_HCI.Editar_consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Administrar consultas</title>
    <link rel="icon" href="Img/LogoEmpresaSinFondo.png" />
    <link href="Estilos/EstiloSideBar.css" rel="stylesheet" />
    <link href="Estilos/EstiloAdministrarConsulta.css" rel="stylesheet" />
</head>
<body>
    <!--SIDE BAR-->
    <form id="form1" runat="server">
         <div id="sidebar">
            <div class="toggle-btn">
                <span>&#9776</span>
            </div>

            <ul>
                <li>
                    <img src="Img/Logo%20empresa%20ABC%202.PNG" alt="Logotipo" class="logo" />
                </li>
                <li><a href="VerConsultaAdmin.aspx">Ver Consultas</a> </li>
                <li><asp:Button ID="Button1" CssClass="cerrarSesion" runat="server" Text="Cerrar Sesion" BorderStyle="None" /></li>
                <li><a href="mailto: xoanteira08@gmail.com">Soporte</a></li>

            </ul>
            
        </div>
        <!--BUSCADOR-->
        <h1 class="titulo">Administrar Consulta</h1>
        <div class="buscador">
            <asp:Label ID="Label1" runat="server" Text="Ingrese el ID de la consulta"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="btnIngresar" class="btn btn-primary btn-large btn-block" runat="server" Text="Buscar" Height="43px" Width="161px" />
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>
       
        <div class="tabla">

            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                 <AlternatingRowStyle BackColor="White" />
                 <FooterStyle BackColor="#CCCC99" />
                 <HeaderStyle 
                BackColor="#8E4470" 
                ForeColor="White" Font-Bold="True" 
                />
                 <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                 <RowStyle BackColor="#F7F7DE" />
                 <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#FBFBF2" />
                 <SortedAscendingHeaderStyle BackColor="#848384" />
                 <SortedDescendingCellStyle BackColor="#EAEAD3" />
                 <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>

        </div>
        <!--MODIFICAR-->
        <div class="actualizar">
            <asp:Label ID="Label3" runat="server" Text="Tipo de Servicio"></asp:Label>
           
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Preventivo</asp:ListItem>
                <asp:ListItem>Correctivo</asp:ListItem>
                <asp:ListItem>Predictivo</asp:ListItem>
            </asp:DropDownList>

            <br />
             <br />

            <br />
            Estado<asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>En Reparacion</asp:ListItem>
                <asp:ListItem>En Observacion</asp:ListItem>
                <asp:ListItem>Finalizado</asp:ListItem>
                <asp:ListItem>En entrega</asp:ListItem>
            </asp:DropDownList>
            <br />
             <br />
             <br />

            <asp:Label ID="Label4" runat="server" Text="Observacion"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="41px" Width="195px"></asp:TextBox>

            <br />
            <br />
            <br />

            <asp:Label ID="Label5" runat="server" Text="Costo"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" step="any"></asp:TextBox>

        </div>
        <!--BOTONES-->
        <div class="botones">
            <asp:Label ID="Label6" runat="server"  ForeColor="Red" Text=""></asp:Label>
            <div class="boton1">
            <asp:Button ID="Button2" class="btn btn-primary btn-large btn-block" runat="server" Text="Borrar" Height="43px" Width="161px" />
                </div>
            <div class="boton1">
            <asp:Button ID="Button3" class="btn btn-primary btn-large btn-block" runat="server" Text="Modificar" Height="43px" Width="161px" />
                </div>
            <div class="boton1">
            <asp:Button ID="Button4" class="btn btn-primary btn-large btn-block" runat="server" Text="Exportar a Excel" Height="43px" Width="161px" />
                </div>
        </div>
    </form>
    <script src="Estilos/SideBar.js"></script>
</body>
</html>
