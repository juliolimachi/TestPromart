using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPromart.Models
{
   

        public class OrdenServicioContext : DbContext
        {
            public OrdenServicioContext(DbContextOptions<OrdenServicioContext> options) : base(options)
            {

            }
            public DbSet<OrdenServicio> OrdenServicios { get; set; }
            public DbSet<OrdenServicioDet> OrdenServicioDet { get; set; }
            public DbSet<Producto> Productos { get; set; }
            public DbSet<Proveedor> Proveedores { get; set; }
            public DbSet<Servicio> Servicios { get; set; }

        }


    
}
