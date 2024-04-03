using EvoJiuJitsu.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Data.Mapping
{
    public class AtletaMapping : IEntityTypeConfiguration<Atleta>
    {
        public void Configure(EntityTypeBuilder<Atleta> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.Property(a => a.Idade)
                .IsRequired()
                .HasColumnType("nchar(2)");

            builder.Property(a => a.Peso)
                .IsRequired()
                .HasColumnType("nvarchar(10)");

            builder.Property(a => a.Cpf)
                .IsRequired()
                .HasColumnType("nvarchar(15)");

            builder.ToTable("Atletas");
        }
    }
}
