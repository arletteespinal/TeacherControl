using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherControl5._1.ControlPanel.Profesor.Consultas
{
    public partial class TiposEvaluacionesWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);
            if (!IsPostBack)
            {
                TiposGridView.DataSource = TiposEvaluaciones.Listar("IdTipoEvaluacion as Codigo, Descripcion,IdProfesor,(CASE  WHEN Estatus=0 then 'Desactivado' when Estatus=1 then 'Activado' end) as Estatus", "IdProfesor='" + id + "'");
                TiposGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string filtro = " ";
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);

            if (FiltarDropDownList.SelectedIndex == 0)
            {

                filtro = "and IdTipoEvaluacion='" + FiltarTextBox.Text + "'";
            }
            else if (FiltarDropDownList.SelectedIndex == 1)
            {

                filtro = " and Descripcion like'%" + FiltarTextBox.Text + "%'";
            }
            if (FiltarTextBox.Text == string.Empty)
            {
                filtro = "";
            }
            if (EstatusCheckBox.Checked == false)
            {
                filtro += "and Estatus = '0'";
            }
            else if (EstatusCheckBox.Checked == true)
            {
                filtro += "and Estatus = '1'";
            }

            TiposGridView.DataSource = TiposEvaluaciones.Listar("IdTipoEvaluacion as Codigo, Descripcion,IdProfesor,(CASE  WHEN Estatus=0 then 'Desactivado' when Estatus=1 then 'Activado' end) as Estatus", " IdProfesor='" + id + "'" + filtro);
            TiposGridView.DataBind();
        }
    }
}