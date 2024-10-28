using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayaBOL
{
    public class Alumnos
    {
        public int IdAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoPatAlumno { get; set; }
        public string ApellidoMatAlumno { get; set; }
        public string Email { get; set; }

        public int NumeroMatricula { get; set; }

    }
    public class Asignatura
    {
        public int CodAsignatura { get; set; }
        public string NombreAsignatura { get; set; }
        public int Creditos { get; set; }
    }


}


