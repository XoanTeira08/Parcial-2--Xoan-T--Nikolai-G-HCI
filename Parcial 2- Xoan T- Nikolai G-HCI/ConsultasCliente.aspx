<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultasCliente.aspx.vb" Inherits="Parcial_2__Xoan_T__Nikolai_G_HCI.ConsultasCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hacer una Consulta</title>
    <link href="Estilos/EstiloSideBar.css" rel="stylesheet" />
    <link href="Estilos/EstiloConsultaCliente.css" rel="stylesheet" />
    <link rel="icon" href="Img/LogoEmpresaSinFondo.png" />
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
                <li><a href="VerConsultaCliente.aspx">Mis consultas</a> </li>
                <li><asp:Button ID="Button1" CssClass="cerrarSesion" runat="server" Text="Cerrar Sesion" BorderStyle="None" /></li>
                <li><a href="mailto: xoanteira08@gmail.com">Contactenos</a></li>

            </ul>
        </div>
        <!--FORM-->
        <div class="consulta_form">
            <div class="consulta_form1">
                <h1 class="titulo">Hacer Consulta</h1>
                <asp:Label ID="Label1" runat="server" Text="Asunto"></asp:Label><br />
                <asp:TextBox ID="TextBox1" runat="server" Width="375px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Urgencia"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Normal</asp:ListItem>
                    <asp:ListItem>Urgente</asp:ListItem>
                    <asp:ListItem>Muy Urgente</asp:ListItem>
                    <asp:ListItem>Emergencia</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Descripción"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" Height="99px" Width="367px" Rows="5"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <asp:Button ID="btnIngresar" class="btn btn-primary btn-large btn-block" runat="server" Text="Ingresar" />
            </div>

        </div>

    </form>
    <script src="Estilos/SideBar.js"></script>
</body>
</html>
