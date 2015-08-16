using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Web.Security;
namespace TeacherControl5._1
{
    public partial class Registrarse : System.Web.UI.Page
    {
        private Usuarios usuario;
        private BLL.Profesores profesor;
        private BLL.Estudiantes estudiante;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PFinalizarButton_Click(object sender, EventArgs e)
        {
            usuario = new Usuarios();
            profesor = new BLL.Profesores();

            usuario.Nombre = NombreUsuariioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.IdTipoUsuario = 2;

            profesor.Nombres = PNombreTextBox.Text;
            profesor.Apellidos = PApellidoTextBox.Text;
            profesor.Documento = PDocTextBox.Text;
            profesor.Email = PEmailTextBox.Text;
            profesor.Telefono = PTelefonoTextBox.Text;
            profesor.Genero = PGeneroDropDownList.SelectedIndex;
            profesor.IdTipoDocumento = PTipoDocDropDownList.SelectedIndex;
            if (usuario.Insertar())
            {
                usuario.BuscarIdUsuario();
                profesor.IdProfesor = usuario.IdUsuario;
                if (profesor.Insertar())
                {
                    if (usuario.Autenticar(NombreUsuariioTextBox.Text, ClaveTextBox.Text))
                    {
                        FormsAuthentication.RedirectFromLoginPage(NombreUsuariioTextBox.Text, false);
                        Session["IdUsuario"] = usuario.IdUsuario;
                        if (usuario.IdTipoUsuario == 1)
                        {
                            Response.Redirect("~/ControlPanel/Administrador/InicioWeb.aspx");
                        }
                        else if (usuario.IdTipoUsuario == 2)
                        {
                            Response.Redirect("~/ControlPanel/Profesor/InicioWeb.aspx");
                        }
                        else if (usuario.IdTipoUsuario == 3)
                        {
                            Response.Redirect("~/ControlPanel/Estudiante/InicioWeb.aspx");
                        }

                    }
                }

            }
        }
        protected void EFinalizarButton_Click(object sender, EventArgs e)
        {
            usuario = new Usuarios();
            estudiante = new BLL.Estudiantes();

            usuario.Nombre = NombreUsuariioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.IdTipoUsuario = 3;

            estudiante.Nombres = ENombreTextBox.Text;
            estudiante.Apellidos = EApellidoTextBox.Text;
            estudiante.Matricula = MatriculaTextBox.Text;
            estudiante.Telefono = ETelefonoTextBox.Text;
            estudiante.Email = EEmaeilTextBox.Text;
            estudiante.Genero = EGeneroDropDownList.SelectedIndex;
            estudiante.IdTipoDocumento = ETipoDocDropDownList.SelectedIndex;
            estudiante.Documento = EDocumentoTextBox.Text;
            if (usuario.Insertar())
            {
                usuario.BuscarIdUsuario();
                estudiante.IdEstudiante = usuario.IdUsuario;
                if (estudiante.Insertar())
                {
                    if (usuario.Autenticar(NombreUsuariioTextBox.Text, ClaveTextBox.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(NombreUsuariioTextBox.Text, false);
                Session["IdUsuario"] = usuario.IdUsuario;
                if (usuario.IdTipoUsuario == 1)
                {
                    Response.Redirect("~/ControlPanel/Administrador/InicioWeb.aspx");
                }
                else if (usuario.IdTipoUsuario == 2)
                {
                    Response.Redirect("~/ControlPanel/Profesor/InicioWeb.aspx");
                }
                else if (usuario.IdTipoUsuario == 3)
                {
                    Response.Redirect("~/ControlPanel/Estudiante/InicioWeb.aspx");
                }
                }
                }
            }
            
        }
    }
}