using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Banco.Domain.Models;

namespace Banco.Infraestructure.Configs
{
    public class ProductoConfig : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("productos");
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Categoria);
        }
    }
}
