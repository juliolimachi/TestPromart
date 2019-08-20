using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPromart.Models
{
    public class Producto
    {
        [Key]
        public int NIdP { get; set; }
        public string Sku { get; set; }
        public string Descripcion { get; set; }

    }
}
