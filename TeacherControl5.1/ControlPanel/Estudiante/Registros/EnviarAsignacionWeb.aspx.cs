using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TeacherControl5._1.ControlPanel.Estudiante.Registros
{
    public partial class EnviarAsignacionWeb : System.Web.UI.Page
    {
        private CalificacionesEstudiantes tarea;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void EnviarButton_Click(object sender, EventArgs e)
        {
            tarea = new CalificacionesEstudiantes();
            int idU = 0;
            int.TryParse(Session["IdUsuario"].ToString(), out idU);
            int id = 0;
            int.TryParse(Request.QueryString["Codigo"], out id);

            if (FileUpload.HasFile)
            {
                string camino = Server.MapPath("/ControlPanel/Estudiante/Tareas/");
                string nombre = FileUpload.FileName;
                string extension = System.IO.Path.GetExtension(nombre).ToLower();
                if ((extension == ".docx") || (extension == ".doc") || (extension == ".rtf") || (extension == ".txt"))
                {
                    try
                    {
                        if (!System.IO.Directory.Exists(camino + User.Identity.Name))
                            System.IO.Directory.CreateDirectory(camino + User.Identity.Name);
                        FileUpload.SaveAs(camino + User.Identity.Name + "\\" + nombre);
                        tarea.IdEvaluacionesDetalle = id;
                        tarea.IdEstudiante = idU;
                        tarea.FechaEntregada = DateTime.Now;
                        tarea.Enlace1 = camino + User.Identity.Name + "\\" + nombre;
                        tarea.Insertar();
                    }
                    catch (Exception)
                    {

                        //throw;
                    }
                }
            }
            Response.Redirect("~/ControlPanel/Estudiante/Consultas/AsignacionesWeb.aspx");
            }
        
    }
}