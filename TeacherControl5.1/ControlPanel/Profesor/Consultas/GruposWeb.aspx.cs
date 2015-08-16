using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherControl5._1.ControlPanel.Profesor.Consultas
{
    public partial class GruposWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);
            
            if (!IsPostBack)
            {
                GruposGridView.DataSource = Grupos.Listar("IdGrupo as Codigo, IdSemestre, IdAsignatura, IdProfesor, Estatus", " where IdProfesor='" + id + "'");
                GruposGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string filtro = " ";
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);

            if (FiltarDropDownList.SelectedIndex == 0)
            {
                filtro = " IdGrupo='" + FiltarTextBox.Text + "'  and";
            }
            else if (FiltarDropDownList.SelectedIndex == 1)
            {
                filtro = " IdAsignatura='" + FiltarTextBox.Text + "'  and";
            }
            else if (FiltarDropDownList.SelectedIndex == 2)
            {
                filtro = "IdSemestre='" + FiltarTextBox.Text + "'  and";
            }
            if (FiltarTextBox.Text == string.Empty)
            {
                filtro = "";
            }
            GruposGridView.DataSource = Grupos.Listar("IdGrupo as Codigo, IdSemestre, IdAsignatura, IdProfesor, Estatus", "where " + filtro + " IdProfesor='" + id + "'");
            GruposGridView.DataBind();
        }
    }
}