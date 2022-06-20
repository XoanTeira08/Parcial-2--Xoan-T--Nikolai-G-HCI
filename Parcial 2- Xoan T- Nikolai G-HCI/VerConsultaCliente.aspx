<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VerConsultaCliente.aspx.vb" Inherits="Parcial_2__Xoan_T__Nikolai_G_HCI.VerConsultaCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mis consultas</title>
    <link rel="icon" href="Img/LogoEmpresaSinFondo.png" />
    <link href="Estilos/EstiloSideBar.css" rel="stylesheet" />
    <link href="Estilos/EstiloMisConsutlas.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <!--SIDEBAR-->
        <div id="sidebar">
            <div class="toggle-btn">
                <span>&#9776</span>
            </div>
            <ul>
                <li>
                    <img src="Img/Logo%20empresa%20ABC%202.PNG" alt="Logotipo" class="logo" />
                </li>
                <li><a href="ConsultasCliente.aspx"> Hacer una consulta</a>  </li>
                <li><asp:Button ID="Button1" CssClass="cerrarSesion" runat="server" Text="Cerrar Sesion" BorderStyle="None" /></li>
                <li><a href="mailto: xoanteira08@gmail.com">Contactenos</a></li>

            </ul>
        </div>
        <h1 class="titulo">Ver mis Consultas</h1>
        <!--DATAGRID-->
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
                 <SortedDescendingHeaderStyle BackColor="#575357" /></asp:GridView>
        </div>
        
    </form>
    <script src="Estilos/SideBar.js"></script>
</body>
</html>
