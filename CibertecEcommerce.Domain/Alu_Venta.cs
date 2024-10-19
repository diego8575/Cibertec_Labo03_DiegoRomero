using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Domain
{
    [Table("T_Venta")]
    public class Alu_Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public int IdAlumno { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("IdAlumno")]
        public Alu_Alumno Alumno { get; set; }

    }
}
