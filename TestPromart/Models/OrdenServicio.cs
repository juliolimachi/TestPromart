using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestPromart.Models
{
    public class OrdenServicio
    {
        [Key]
        public int NIdSo { get; set; }
        public string Turno { get; set; }
        public DateTime FechaEstimada { get; set; }
        public string Observacion { get; set; }
        public int FechaRegistro { get; set; }

        [ForeignKey("Proveedor")]
        public int IdProveedor{ get; set; }
        public Proveedor NIdProv { get; set; }


        public List<OrdenServicioDet> OrdenDetail { get; set; }

    }
}
