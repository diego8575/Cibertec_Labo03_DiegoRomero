using Cibertec.Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Domain.Infraestructure.Context
{
    public class EcommerceDBContext : DbContext
    {

        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options) : base(options) {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Customer> Sales { get; set; }

        //generacion de tablas Tarea en BD
        public DbSet<Alu_Alumno> Alumnos { get; set; }
        public DbSet<Alu_Curso> Curso { get; set; }
        public DbSet<Alu_Venta> Venta { get; set; }
        public DbSet<Alu_DetalleVenta> DetalleVenta { get; set; }


    }
}
