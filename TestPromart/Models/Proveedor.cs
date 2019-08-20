using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestPromart.Models
{
    public class Proveedor
    {
        [Key]
        public int NId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(11)")]
        public string Ruc { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string RazonSocial { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }
    }
}
