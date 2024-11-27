using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class EntEmpleado
    {
        public int IdEmpleado { get; set; } // Identificador único
        public string Nombre { get; set; } // Nombre del empleado
        public string Apellido { get; set; } // Apellido del empleado
        public bool Activo { get; set; } = true; // Estado del empleado, activo o inhabilitado
        public DateTime FechaContrato { get; set; } // Fecha de contratación
        public decimal SueldoBase { get; set; } // Sueldo base del empleado
        public decimal SueldoFinal { get; set; } // Sueldo final del empleado
        public string TipoPago { get; set; } = "Mensual"; // Tipo de pago: 'Mensual' o 'Quincenal'
        public int IdCargo { get; set; } // ID del cargo, clave foránea
    }
}
