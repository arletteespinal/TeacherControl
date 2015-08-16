<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="TeacherControl5._1.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    <title>Teacher's Control | Registrarse</title>
   
    <link href="/Resource/css/estilo_index_signin.css" rel="stylesheet" />
    <link href="/Resource/css/fonts.css" rel="stylesheet" />
    <script src="/Resource/js/jquery-latest.js"></script>
    <script src="/Resource/js/queryRegistro.js"></script>
    <script src="/Resource/js/menu_profesores.js"></script>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
   <header>
        <div id="bar">
    	</div>
    </header>
<div id="contenido">
  <div class="form1">
        	<label class="userName">Nombre: </label><asp:TextBox ID="NombreUsuariioTextBox" runat="server" CssClass="nombre"></asp:TextBox><br/>
            <label class="pass">Contraseña: </label><asp:TextBox ID="ClaveTextBox" runat="server" CssClass="contraseña" TextMode="Password"></asp:TextBox>
      <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" Text="*" ControlToCompare="ClaveTextBox" ControlToValidate="ConfirmarClaveTextBox" ForeColor="Red"></asp:CompareValidator>
           <br/> <label class="confirmPass">Confirmar Contraseña: </label><asp:TextBox ID="ConfirmarClaveTextBox" runat="server" CssClass="confirmContraseña" TextMode="Password"></asp:TextBox><br/>
            <label class="user-type">Tipo de Usuario: </label>
      <asp:DropDownList ID="combo" runat="server" CssClass="user-type-component" placeholder="Tipo de Usuario">
          <asp:ListItem Value="0">Profesor</asp:ListItem>
          <asp:ListItem Value="1">Estudiante</asp:ListItem>
            </asp:DropDownList>
 			   <input type="button" value="Siguiente" class="btn-siguiente"/>     
  </div>
  <div class="formProfesor">
  		<label class="name-label">Nombre: </label><asp:TextBox ID="PNombreTextBox" runat="server" CssClass="name-component"></asp:TextBox>
            <label class="last-name-label">Apellidos: </label><asp:TextBox ID="PApellidoTextBox" runat="server" CssClass="last-name-component"></asp:TextBox><br/>
             <label class="gender-label">Genero: </label>
      <asp:DropDownList ID="PGeneroDropDownList" runat="server" CssClass="gender-component">
          <asp:ListItem>Femenino</asp:ListItem>
          <asp:ListItem>Masculino</asp:ListItem>
        </asp:DropDownList>
            <label class="phone-label">Telefono: </label><asp:TextBox ID="PTelefonoTextBox" runat="server"  CssClass="phone-component"></asp:TextBox><br/>
             <label class="document-type-label">Tipo de Documento:</label>
      <asp:DropDownList ID="PTipoDocDropDownList" runat="server" CssClass="document-type-component" >
          <asp:ListItem>Cedula</asp:ListItem>
          <asp:ListItem>Pasaporte</asp:ListItem>
          <asp:ListItem>Ninguno</asp:ListItem>
        </asp:DropDownList>
            <asp:TextBox ID="PDocTextBox" runat="server" CssClass="document-component"></asp:TextBox><br/>
            <label class="email-label">E-mail: </label>
      <asp:TextBox ID="PEmailTextBox" runat="server" CssClass="email-component"></asp:TextBox><br/>
          <input type="button" value="Atras" class="btn-Atras-Profe"/>
            <asp:Button ID="PFinalizarButton" runat="server" Text="Finalizar" CssClass="btn-finalizar" OnClick="PFinalizarButton_Click"/>
  </div>
  <div class="formEstudiante">
      <label class="name-est-label">Nombre: </label><asp:TextBox ID="ENombreTextBox" runat="server" CssClass="name-est-component"></asp:TextBox>
            <label class="last-est-name-label">Apellidos: </label><asp:TextBox ID="EApellidoTextBox" runat="server" CssClass="last-est-name-component"></asp:TextBox>
            <br/>
  		<label class="registration-number-label">Marticula: </label><asp:TextBox ID="MatriculaTextBox" runat="server" CssClass="registration-number-component"></asp:TextBox>
  		 <label class="gender-est-label">Genero: </label>
      <asp:DropDownList ID="EGeneroDropDownList" runat="server" CssClass="gender-est-component">
          <asp:ListItem>Femenino</asp:ListItem>
          <asp:ListItem>Masculino</asp:ListItem> 
        </asp:DropDownList>
            <label class="phone-est-label">Telefono: </label><asp:TextBox ID="ETelefonoTextBox" runat="server" CssClass="phone-est-component"></asp:TextBox><br/>
             <label class="document-est-type-label">Tipo de Documento:</label>
      <asp:DropDownList ID="ETipoDocDropDownList" runat="server" CssClass="document-est-type-component">
          <asp:ListItem>Cedula</asp:ListItem>
          <asp:ListItem>Pasaporte</asp:ListItem>
          <asp:ListItem>Ninguno</asp:ListItem>
        </asp:DropDownList>
            <asp:TextBox ID="EDocumentoTextBox" runat="server" CssClass="document-est-component"></asp:TextBox><br/>
            <label class="email-est-label">E-mail: </label>
           <asp:TextBox ID="EEmaeilTextBox" runat="server" CssClass="email-est-component"></asp:TextBox><br/>
            <input type="button" value="Atras" class="btn-Atras-Est"/>
            <asp:Button ID="EFinalizarButton" runat="server" Text="Finalizar" CssClass="btn-est-finalizar" OnClick="EFinalizarButton_Click" />
  </div>
</div>
    <footer>
    </footer>
    </form>
</body>
</html>
