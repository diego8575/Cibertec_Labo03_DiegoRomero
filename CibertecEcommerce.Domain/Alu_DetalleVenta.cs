using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Domain
{
    [Table("T_DetalleVenta")]
    public class Alu_DetalleVenta
    {
        [Key]
        public int IdDetalleVenta { get; set; }
        public int IdCurso { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("IdCurso")]
        public Alu_Curso Curso { get; set; }
        public Alu_Venta Venta { get; set; }

    }
}
