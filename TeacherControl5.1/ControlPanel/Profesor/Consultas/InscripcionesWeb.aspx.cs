using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherControl5._1.ControlPanel.Profesor.Consultas
{
    public partial class InscripcionesWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = 0;
                int.TryParse(Session["IdUsuario"].ToString(), out id);

                InscripcionGridView.DataSource = Inscripciones.Listar("i.IdInscripcion as Codigo,i.IdEstudiante, i.IdGrupo, i.Estatus", " i join Grupos g on i.IdGrupo=g.IdGrupo join Profesores p on p.IdProfesor=g.IdProfesor where G.IdProfesor='"+id+"'");
                InscripcionGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);
            string filtro = "";
            if (FiltarDropDownList.SelectedIndex == 0)
            {
                filtro = "and IdInscripcion='" + FiltarTextBox.Text + "'";
            }
            else if (FiltarDropDownList.SelectedIndex == 2)
            {
                filtro = "and IdEstudiante='" + FiltarTextBox.Text + "'";
            }
            else if (FiltarDropDownList.SelectedIndex == 1)
            {
                filtro = "and IdGrupo='" + FiltarTextBox.Text + "'";
            }
            if (FiltarTextBox.Text == string.Empty)
            {
                filtro = " ";
            }
            InscripcionGridView.DataSource = Inscripciones.Listar("i.IdInscripcion as Codigo,i.IdEstudiante, i.IdGrupo, i.Estatus", " i join Grupos g on i.IdGrupo=g.IdGrupo join Profesores p on p.IdProfesor=g.IdProfesor where G.IdProfesor='" + id + "' "+filtro);
            InscripcionGridView.DataBind();
        }
    }
}