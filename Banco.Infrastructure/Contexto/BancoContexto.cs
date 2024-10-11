using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Banco.Domain.Models;
using Banco.Infraestructure.Configs;
using Banco.Infrastructure.Configs;

namespace Banco.Infrastruture.Contexto
{
    public partial class BancoContexto : DbContext
    {
        public BancoContexto() { }
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options) {}

        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=CARLOS-KERLLY; Initial Catalog=BancoDB;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductoConfig());
            modelBuilder.ApplyConfiguration(new CategoriaConfig());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
