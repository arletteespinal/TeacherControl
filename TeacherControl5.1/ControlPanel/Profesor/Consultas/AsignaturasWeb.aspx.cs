using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TeacherControl5._1.ControlPanel.Profesor.Consultas
{
    public partial class AsignaturasWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);
            
            
            if (!IsPostBack)
            {
                AsignaturasGridView.DataSource = Asignaturas.Listar("IdAsignatura as Codigo, CodigoAsignatura, Descripcion, Creditos", "IdProfesor='"+id+"'");
                AsignaturasGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            string filtro=" ";
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);
            
            if (FiltarDropDownList.SelectedIndex == 0)
            {
                filtro = "IdAsignatura='" + FiltarTextBox.Text + "' and";
            }
            else if (FiltarDropDownList.SelectedIndex == 1)
            {
                filtro = "CodigoAsignatura='" + FiltarTextBox.Text + "' and";
            }
            else if (FiltarDropDownList.SelectedIndex == 2)
            {
                filtro = "Descripcion like'%" + FiltarTextBox.Text + "%' and";
            }

            if (FiltarTextBox.Text == string.Empty)
            {
                filtro = "";
            }
            AsignaturasGridView.DataSource = Asignaturas.Listar("IdAsignatura as Codigo, CodigoAsignatura, Descripcion, Creditos,IdProfesor", filtro+"  IdProfesor='"+id+"'");
            AsignaturasGridView.DataBind();
        }
    }
}