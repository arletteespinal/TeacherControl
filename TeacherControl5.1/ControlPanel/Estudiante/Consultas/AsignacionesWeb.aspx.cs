using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TeacherControl5._1.ControlPanel.Estudiante.Consultas
{
    public partial class AsignacionesWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out id);
            if (!IsPostBack)
            {
                AsignacionesGridView.DataSource = EvaluacionesDetalle.Listar("eg.IdGrupo as CodigoGrupo,ed.IdEvaluacionesDetalle as Codigo ,a.Descripcion,p.Nombres+' '+p.Apellidos as Profesor,ed.Descripcion,ed.TipoAsignacion,ed.FechaEntrega, ed.Estatus", "ed  join EvaluacionesGrupos eg on ed.IdEvaluacionGrupo=eg.IdEvaluacionGrupo join Grupos g on g.IdGrupo=eg.IdGrupo join Inscripciones i on i.IdGrupo=g.IdGrupo join Asignaturas a on a.IdAsignatura=g.IdAsignatura join Profesores p on p.IdProfesor = g.IdProfesor where i.IdEstudiante='" + id + "'");
                AsignacionesGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}