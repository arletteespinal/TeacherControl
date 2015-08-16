using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherControl5._1.ControlPanel.Profesor.Consultas
{
    public partial class SemestresWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);
            
            if (!IsPostBack)
            {
                SemestresGridView.DataSource = Semestres.Listar("IdSemestre as Codigo, Periodo, Descripcion, FechaInicio,FechaFin,IdProfesor", "IdProfesor='" + id + "'");
                SemestresGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string filtro = " ";
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);

            if (FiltarDropDownList.SelectedIndex == 0)
            {
                filtro = "IdSemestre='" + FiltarTextBox.Text + "' and ";
            }
            else if (FiltarDropDownList.SelectedIndex == 1)
            {
                filtro = "Periodo='" + FiltarTextBox.Text + "' and ";
            }
            else if (FiltarDropDownList.SelectedIndex == 2)
            {
                filtro = "Descripcion like'%" + FiltarTextBox.Text + "%' and ";
            }
            if (FiltarTextBox.Text == string.Empty)
            {
                filtro = "";
            }
            SemestresGridView.DataSource = Semestres.Listar("IdSemestre as Codigo, Periodo, Descripcion, FechaInicio,FechaFin,IdProfesor", filtro + " IdProfesor='" + id + "'");
            SemestresGridView.DataBind();
        }
    }
}