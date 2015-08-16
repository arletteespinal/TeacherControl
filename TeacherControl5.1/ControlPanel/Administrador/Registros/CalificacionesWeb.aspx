<%@ Page Title="" Language="C#" MasterPageFile="~/AdministradoresSite.Master" AutoEventWireup="true" CodeBehind="CalificacionesWeb.aspx.cs" Inherits="TeacherControl5._1.ControlPanel.Administrador.Registros.CalificacionesWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Código:"></asp:Label>
    <asp:TextBox ID="CodigoTextBox" runat="server" Enabled="False"></asp:TextBox>
    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" CausesValidation="false" />
    <br />
     <asp:Label ID="Label3" runat="server" Text="Grupo"></asp:Label>
    <asp:DropDownList ID="GruposDropDownList" runat="server"></asp:DropDownList>
     <br />
     <asp:Label ID="Label4" runat="server" Text="Asignación:"></asp:Label>
    <asp:DropDownList ID="EvaluacionDropDownList" runat="server"></asp:DropDownList>
     <br />
    <asp:Label ID="Label5" runat="server" Text="Estudiante:"></asp:Label>
    <asp:DropDownList ID="EstudianteDropDownList" runat="server"></asp:DropDownList>
     <br />
    <asp:Label ID="Label2" runat="server" Text="Calificación:"></asp:Label>
    <asp:TextBox ID="CalificacionTextBox" runat="server"></asp:TextBox>
</asp:Content>
