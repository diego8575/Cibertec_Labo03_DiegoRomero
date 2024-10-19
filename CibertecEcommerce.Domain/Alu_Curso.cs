using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Domain
{
    [Table("T_Curso")]
    public class Alu_Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public int CantidadHoras { get; set; }
        public decimal Precio { get; set; }
        public string Silabo { get; set; }
    }
}
