using SAGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SAGE.Database.Mappings
{
    public class EstadoMapping : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> entity)
        {
            entity.HasKey(o => o.Id);
            entity.Property(o => o.Id)
                  .HasColumnName("Id")
                  .HasColumnType("uniqueidentifier")
                  .HasDefaultValueSql("(newid())");

            entity.Property(o => o.Nome)
                  .HasColumnName("Nome")
                  .HasColumnType("varchar(50)")
                  .HasMaxLength(50)
                  .IsRequired();

            entity.Property(o => o.Sigla)
                  .HasColumnName("Sigla")
                  .HasColumnType("varchar(2)")
                  .HasMaxLength(2)
                  .IsUnicode(false)
                  .IsRequired();
        }
    }
}
