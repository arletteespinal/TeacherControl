using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
   public class Semestres
    {
        public int IdSemestre { set; get; }
        public string Periodo { set; get; }
        public string Descripcion { set; get; }
        public string Fechainicio { set; get; }
        public string Fechafin { set; get; }
        public int IdProfesor { set; get; }
        private Conexion conexion = new Conexion();

        public Semestres()
        {
            IdSemestre = 0;
            Periodo = null;
            Descripcion = null;
        }

        public bool Insertar()
        {
            return conexion.EjecutarDB("INSERT INTO Semestres(Periodo,Descripcion,Fechainicio,Fechafin,IdProfesor)VALUES('" + this.Periodo + "','" + this.Descripcion + "','" + this.Fechainicio + "','" + this.Fechafin + "','" + IdProfesor.ToString() + "')");
        }
        public bool Modificar()
        {
            return conexion.EjecutarDB("UPDATE Semestres SET Periodo='" + this.Periodo + "', Descripcion='" + this.Descripcion + "', Fechainicio='" + this.Fechainicio + "', Fechafin='" + this.Fechafin + "' WHERE IdSemestre='" + this.IdSemestre + "'");
        }
        public bool Eliminar()
        {
            return conexion.EjecutarDB("DELETE FROM Semestres WHERE IdSemestre='" + this.IdSemestre + "'");
        }

        public bool Buscar(int id)
        {
            bool Retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("Select * from Semestres where IdSemestre='" + id + "'");

            if (dt.Rows.Count > 0)
            {
                Retorno = true;
                IdSemestre = (int)dt.Rows[0]["IdSemestre"];
                Descripcion = dt.Rows[0]["Descripcion"].ToString();
                Periodo = dt.Rows[0]["Periodo"].ToString();
                Fechafin = dt.Rows[0]["Fechafin"].ToString();
                Fechainicio = dt.Rows[0]["Fechainicio"].ToString();
                IdProfesor = (int)dt.Rows[0]["IdProfesor"];
            }
            return Retorno;
        }

        public static DataTable Listar(string campos, string where)
        {
            Conexion conexion = new Conexion();
            return conexion.BuscarDb("Select " + campos + " from Semestres where " + where);
        }
    }
}
