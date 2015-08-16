using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl5._1.ControlPanel.Estudiante.Registros
{
    public partial class InscribirGrupo : System.Web.UI.Page
    {
        private BLL.Inscripciones inscripcion = new BLL.Inscripciones();
        private Grupos grupos = new Grupos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(CodigoGrupoTextBox.Text, out id);
            if (grupos.Buscar(id))
            {
                Buscar(id);
            }
            
        }
        private void Buscar(int id)
        {
            GuardarButton.Enabled = true;
            
            DetalleGridView.DataSource = Horarios.Listar("*"," IdGrupo='"+id+"'");
            DetalleGridView.DataBind();

            AsignaturaDropDownList.DataSource = Grupos.Listar("g.IdAsignatura, a.Descripcion", " g join Asignaturas a on g.IdAsignatura = a.IdAsignatura where IdGrupo='"+id+"'");
            AsignaturaDropDownList.DataValueField = "IdAsignatura";
            AsignaturaDropDownList.DataTextField = "Descripcion";
            AsignaturaDropDownList.DataBind();
            AsignaturaDropDownList.Visible = true;
            AsignaturaLabel.Visible = true;


            SemestreDropDownList.DataSource = Grupos.Listar("g.IdSemestre, s.Descripcion", " g join Semestres s on g.IdSemestre = s.IdSemestre where IdGrupo='" + id + "'");
            SemestreDropDownList.DataValueField = "IdSemestre";
            SemestreDropDownList.DataTextField = "Descripcion";
            SemestreDropDownList.DataBind();
            SemestreDropDownList.Visible = true;
            SemestreLabel.Visible = true;

            ProfesoresDropDownList.DataSource = Grupos.Listar("g.IdProfesor, p.Nombres+' '+p.Apellidos as NombreCompleto", " g join Profesores p on g.IdProfesor = p.IdProfesor where IdGrupo='" + id + "'");
            ProfesoresDropDownList.DataValueField = "IdProfesor";
            ProfesoresDropDownList.DataTextField = "NombreCompleto";
            ProfesoresDropDownList.DataBind();
            ProfesoresDropDownList.Visible = true;
            ProfesorLabel.Visible = true;
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(Session["IdUsuario"].ToString(),out id);
            inscripcion.IdEstudiante = id;
            inscripcion.IdGrupo = Convert.ToInt32(CodigoGrupoTextBox.Text);
            if (EstatusDropDownList.SelectedIndex == 0)
            {
                inscripcion.Estatus = 0;
            }
            else if (EstatusDropDownList.SelectedIndex == 1)
            {
                inscripcion.Estatus = 1;
            }

            if (CodigoTextBox.Text == string.Empty)
            {
                if (inscripcion.Insertar())
                {
                    LimpiarComponentes();
                }
            }
            else
            {
                inscripcion.IdInscripcion = Convert.ToInt32(CodigoTextBox.Text);
                if (inscripcion.Modificar())
                {
                    LimpiarComponentes();
                }
            }
        }

        private void LimpiarComponentes()
        {
            AsignaturaDropDownList.Visible = false;
            SemestreDropDownList.Visible = false;
            ProfesoresDropDownList.Visible = false;
            CodigoGrupoTextBox.Text = " ";
            DetalleGridView.DataSource = null;
            DetalleGridView.DataBind();
            SemestreLabel.Visible = false;
            AsignaturaLabel.Visible = false;
            ProfesorLabel.Visible = false;
            GuardarButton.Enabled = false;
        }

        protected void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }
        
    }
}