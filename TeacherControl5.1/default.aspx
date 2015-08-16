<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TeacherControl5._1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    <meta charset="utf-8"/>
        <title>Teacher's Control | LogIn</title>
    <link href="Resource/css/estilo.css" rel="stylesheet" />
</head>
<body>
    <%--<a href="ControlPanel/Estudiante/Tareas/hola.txt" download >hue</a>--%>
    <form id="form1" runat="server" >
      <header>
        	<div class="titulo">
                    Bienvenidos a Teacher's Control
                </div>
        </header>
        <div id="contenido">
               	<div id="logo">
                	<img src="/Resource/img/logo.jpg" />
                </div>
                <div id="form">
                	<div class="signin-link"><div><asp:HyperLink ID="RegistrarseHyperLink" runat="server" NavigateUrl="~/Registrarse.aspx" class="signin-link">Registrate Aqui</asp:HyperLink></div></div>
                	<asp:TextBox ID="UsuarioTextBox" runat="server" CssClass="entradaA"></asp:TextBox>
                    <asp:TextBox ID="ClaveTextBox" runat="server" CssClass="entradaB" TextMode="Password"></asp:TextBox>
                    <div id="check">
                   <asp:CheckBox runat="server" Text="Recuerdame" ID="RecuerdameCheckBox" />
                    </div>
                    <asp:Button ID="IniciarButton" runat="server" Text="Iniciar Sesión" class="boton" OnClick="IniciarButton_Click" />
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="reg">¿Olvidaste tu contraseña?</asp:HyperLink>
                </div>
                 
                	
    	</div>
        <footer>
        	<div class="pie">
            	<div class="pie-label">Powered by Arlette Espinal Romero<br/>Designed by Santiago Enm. Suárez<br/>© All Rights Reserved 2015</div>
            </div>
        </footer>
    </form>
</body>
</html>
