using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestPromart.Models
{
    public class OrdenServicioDet
    {
        [Key]
        public int NIdSo { get; set; }


        [ForeignKey("OrdenServicioDetalle")]
        public int IdServicioDetalle { get; set; }
        public OrdenServicio OrdServicio { get; set; }

     
        [ForeignKey("OrdenServicio")]
        public int IdServicio { get; set; }
        public Servicio Servicios { get; set; }

        [ForeignKey("OrdenProducto")]
        public int IdProducto{ get; set; }
        public Producto Productos { get; set; }


    }
}
