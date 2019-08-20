using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPromart.Models
{
    public class Servicio
    {
        [Key]
        public int NIdS { get; set; }
        public string SkuManual { get; set; }
        public string Descripcion { get; set; }

    }

}
