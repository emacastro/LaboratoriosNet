using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            DataColumn ColIdAlumno = new DataColumn("IdAlumno", typeof(int));
            ColIdAlumno.ReadOnly = true;
            ColIdAlumno.AutoIncrement = true;
            ColIdAlumno.AutoIncrementSeed = 0;
            ColIdAlumno.AutoIncrementStep = 1;
            DataColumn ColNombre = new DataColumn("Nombre", typeof(System.Data.SqlTypes.SqlString));
            DataColumn ColApellido = new DataColumn("Apellido", typeof(System.Data.SqlTypes.SqlString));
            dtAlumnos.Columns.Add(ColNombre);
            dtAlumnos.Columns.Add(ColApellido);
            dtAlumnos.Columns.Add(ColIdAlumno);
            dtAlumnos.PrimaryKey = new DataColumn[] { ColIdAlumno };
            DataRow drAlumno = dtAlumnos.NewRow();
            drAlumno[ColApellido] = "Perez";
            drAlumno[ColNombre] = "Juan";
            dtAlumnos.Rows.Add(drAlumno);

            /*Console.WriteLine("Listado de alumnos:");
            foreach (DataRow row in dtAlumnos.Rows)
            {
                Console.WriteLine(row[ColApellido].ToString() + ", " + row[ColNombre].ToString());
            
            Console.ReadLine();*/

            DataRow drAlumno2 = dtAlumnos.NewRow();
            drAlumno2[ColApellido] = "Perez";
            drAlumno2[ColNombre] = "Marcelo";
            dtAlumnos.Rows.Add(drAlumno2);

            DataTable dtCursos = new DataTable("Cursos");
            DataColumn ColIdCurso = new DataColumn("IdCurso", typeof(int));
            ColIdCurso.ReadOnly = true;
            ColIdCurso.AutoIncrement = true;
            ColIdCurso.AutoIncrementSeed = 1;
            ColIdCurso.AutoIncrementStep = 1;
            DataColumn ColCurso = new DataColumn("Curso", typeof(string));
            dtCursos.Columns.Add(ColIdCurso);
            dtCursos.Columns.Add(ColCurso);
            dtCursos.PrimaryKey = new DataColumn[] { ColIdCurso };

            DataRow rwCurso = dtCursos.NewRow();
            rwCurso[ColCurso] = "Informatica";
            dtCursos.Rows.Add(rwCurso);

            DataSet dsUniversidad = new DataSet();
            dsUniversidad.Tables.Add(dtAlumnos);
            dsUniversidad.Tables.Add(dtCursos);

            DataTable dtAlumnos_Cursos = new DataTable("Alumnos_Cursos");
            DataColumn col_ac_IdAlumno = new DataColumn("IdAlumno", typeof(int));
            DataColumn col_ac_IdCurso = new DataColumn("IdCurso", typeof(int));
            dtAlumnos_Cursos.Columns.Add(col_ac_IdAlumno);
            dtAlumnos_Cursos.Columns.Add(col_ac_IdCurso);

            dsUniversidad.Tables.Add(dtAlumnos_Cursos);

            DataRelation relAlumno_ac = new DataRelation("Alumno_Cursos", ColIdAlumno, col_ac_IdAlumno);
            DataRelation relCurso_ac = new DataRelation("Curso_Alumnos", ColIdCurso, col_ac_IdCurso);
            dsUniversidad.Relations.Add(relAlumno_ac);
            dsUniversidad.Relations.Add(relCurso_ac);

            DataRow rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[col_ac_IdAlumno] = 0;
            rwAlumnosCursos[col_ac_IdCurso] = 1;
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

            rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[col_ac_IdAlumno] = 1;
            rwAlumnosCursos[col_ac_IdCurso] = 1;
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

            Console.Write("Por favor ingrese el nombre del curso: ");
            string materia = Console.ReadLine();
            Console.WriteLine("Listado de alumnos del curso " + materia);
            DataRow[] rowCursoinf = dtCursos.Select("Curso = '" + materia + "'");
            foreach (DataRow rowCu in rowCursoinf)
            {
                DataRow[] row_AlumnosInf = rowCu.GetChildRows(relCurso_ac);
                foreach (DataRow rowAl in row_AlumnosInf)
	            {
		            Console.WriteLine(rowAl.GetParentRow(relAlumno_ac)[ColApellido].ToString() + ", " + rowAl.GetParentRow(relAlumno_ac)[ColNombre].ToString());
	            }
            }
            Console.ReadLine();
        }
    }
}
