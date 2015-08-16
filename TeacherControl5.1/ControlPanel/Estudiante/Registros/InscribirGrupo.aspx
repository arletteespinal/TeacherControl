<%@ Page Title="" Language="C#" MasterPageFile="~/EstudiantesSite.Master" AutoEventWireup="true" CodeBehind="InscribirGrupo.aspx.cs" Inherits="TeacherControl5._1.ControlPanel.Estudiante.Registros.InscribirGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="Label1" runat="server" Text="Código:"></asp:Label>
    <asp:TextBox ID="CodigoTextBox" runat="server" Enabled="False"></asp:TextBox>
     <br />
     <asp:Label ID="Label3" runat="server" Text="Grupo"></asp:Label>
     <asp:TextBox ID="CodigoGrupoTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" CausesValidation="false" OnClick="BuscarButton_Click"/>
     <br />
    <asp:Label ID="SemestreLabel" runat="server" Text="Semestre:" Visible="False"></asp:Label>
     <asp:DropDownList ID="SemestreDropDownList" runat="server" Enabled="False" Visible="False">
     </asp:DropDownList>
     <br />
     <asp:Label ID="AsignaturaLabel" runat="server" Text="Asignatura:" Visible="False"></asp:Label>
     <asp:DropDownList ID="AsignaturaDropDownList" runat="server" Enabled="False" Visible="False">
     </asp:DropDownList>
    <br />
     <asp:Label ID="ProfesorLabel" runat="server" Text="Profesor:" Visible="False"></asp:Label>
    <asp:DropDownList ID="ProfesoresDropDownList" runat="server" Enabled="False" Visible="False">
    </asp:DropDownList>
     <br />
     <asp:Label ID="EstatusLabel" runat="server" Text="Estatus:" Visible="False"></asp:Label>
     <asp:DropDownList ID="DropDownList1" runat="server" Enabled="False" Visible="False">
         <asp:ListItem Value="0">Abierto</asp:ListItem>
         <asp:ListItem Value="1">Cerrado</asp:ListItem>
         <asp:ListItem Value="2">Terminado</asp:ListItem>
     </asp:DropDownList>
     <br />
    <asp:GridView ID="DetalleGridView" runat="server" Enabled="False"></asp:GridView>
      <br />
    <asp:Label ID="Label4" runat="server" Text="Estatus:"></asp:Label>
    <asp:DropDownList ID="EstatusDropDownList" runat="server">
        <asp:ListItem Value="0">Inscrito</asp:ListItem>
        <asp:ListItem Value="1">Retirado</asp:ListItem>
     </asp:DropDownList>
     <br />
    <asp:Button ID="GuardarButton" runat="server" Text="Inscribir" OnClick="GuardarButton_Click" Enabled="False"    />
     <asp:Button ID="CancelarButton" runat="server" Text="Cancelar" OnClick="CancelarButton_Click" />
    <br />
</asp:Content>
