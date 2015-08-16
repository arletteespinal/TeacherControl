using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CalificacionesEstudiantes
    {
        public int IdCalificacion { set; get; }
        public int IdEvaluacionesDetalle { set; get; }
        public int IdEstudiante { set; get; }
        public float Calificacion { set; get; }
        public DateTime FechaEntregada { set; get; }
        public string Enlace1 { set; get; }
        public string Enlace2 { set; get; }
        public int PuedenCalificar { set; get; }
        private Conexion conexion = new Conexion();

        public CalificacionesEstudiantes()
        {
            IdCalificacion = 0;
            IdEvaluacionesDetalle = 0;
            PuedenCalificar = 0;
            Enlace1 = "";
            Enlace2 = "";
            IdEstudiante = 0;
            Calificacion = 0;
           
        }

        public bool Insertar()
        {
            return conexion.EjecutarDB("INSERT INTO CalificacionesEstudiantes (IdEvaluacionesDetalle,IdEstudiante,Calificacion,FechaEntregada,Enlace1,Enlace2,PuedenCalificar)VALUES('" + this.IdEvaluacionesDetalle + "','" + this.IdEstudiante + "','" + this.Calificacion + "','" + this.FechaEntregada.ToString("MM/dd/yyyy") + "','" + this.Enlace1 + "','" + this.Enlace2 + "','" + this.PuedenCalificar + "')");
        }

    

        public bool Modificar()
        {
            return conexion.EjecutarDB("update CalificacionesEstudiantes set Calificacion='" + this.Calificacion + "',PuedenCalificar= '" + this.PuedenCalificar + "'");
        }
        public bool Eliminar()
        {
            return conexion.EjecutarDB("DELETE FROM CalificacionesEstudiantes  WHERE IdCalificacion ='" + this.IdCalificacion + "'");
        }

        public bool Buscar(int id)
        {
            bool Retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * from CalificacionesEstudiantes  where IdCalificacion ='" + id + "'");

            if (dt.Rows.Count > 0)
            {
                Retorno = true;
                IdCalificacion = (int)dt.Rows[0]["IdCalificacion"];
                IdEvaluacionesDetalle = (int)dt.Rows[0]["IdEvaluacionesDetalle"];
            }
            return Retorno;
        }

        public DataTable Listar(string campos, string where)
        {
            return conexion.BuscarDb("Select " + campos + " from  CalificacionesEstudiantes where " + where);
        }
    }
}
