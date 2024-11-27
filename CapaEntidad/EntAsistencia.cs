using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntAsistencia
    {
        public int IdAsistencia { get; set; } // Identificador único de la asistencia
        public int IdEmpleado { get; set; } // Clave foránea que relaciona al empleado
        public int IdGrupo { get; set; } // Identificador del grupo al que pertenece
        public DateTime Fecha { get; set; } // Fecha de la asistencia
        public bool Presente { get; set; } // Indica si el empleado estuvo presente (true) o ausente (false)

    }
}
