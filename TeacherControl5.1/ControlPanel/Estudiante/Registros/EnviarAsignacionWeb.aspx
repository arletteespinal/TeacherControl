<%@ Page Title="" Language="C#" MasterPageFile="~/EstudiantesSite.Master" AutoEventWireup="true" CodeBehind="EnviarAsignacionWeb.aspx.cs" Inherits="TeacherControl5._1.ControlPanel.Estudiante.Registros.EnviarAsignacionWeb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FileUpload ID="FileUpload" runat="server" /><br />
    <asp:Button ID="EnviarButton" runat="server" Text="Enviar" OnClick="EnviarButton_Click" />
</asp:Content>
