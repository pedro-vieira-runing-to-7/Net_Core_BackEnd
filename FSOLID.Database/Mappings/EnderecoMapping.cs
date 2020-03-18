using FSOLID.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSOLID.Database.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> entity)
        {
            entity.HasKey(o => o.Id);
            entity.Property(o => o.Id)
                  .HasColumnName("Id")
                  .HasColumnType("uniqueidentifier")
                  .HasDefaultValueSql("(newid())");

            entity.Property(o => o.IdStatus)
                  .HasColumnName("IdStatus")
                  .HasColumnType("int")
                  .IsRequired();

            //entity.Property(o => o.IdPessoa)
            //      .HasColumnName("IdPessoa")
            //      .HasColumnType("int")
            //      .IsRequired();

            //entity.Property(o => o.IdEstado)
            //      .HasColumnName("IdEstado")
            //      .HasColumnType("int")
            //      .IsRequired();

            entity.Property(e => e.IdPessoa).HasColumnName("IdPessoa");

            entity.Property(e => e.IdEstado).HasColumnName("IdEstado");

            entity.Property(o => o.IdTipoEndereco)
                 .HasColumnName("IdTipoEndereco")
                 .HasColumnType("int")
                 .IsRequired();

            entity.Property(o => o.Logradouro)
                  .HasColumnName("Logradouro")
                  .HasColumnType("varchar(100)")
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .IsRequired();

            entity.Property(o => o.Numero)
                  .HasColumnName("Numero")
                  .HasColumnType("varchar(10)")
                  .HasMaxLength(10)
                  .IsUnicode(false)
                  .IsRequired();

            entity.Property(o => o.Bairro)
                  .HasColumnName("Bairro")
                  .HasColumnType("varchar(70)")
                  .HasMaxLength(70)
                  .IsUnicode(false)
                  .IsRequired();

            entity.Property(o => o.Cidade)
                  .HasColumnName("Cidade")
                  .HasColumnType("varchar(70)")
                  .HasMaxLength(70)
                  .IsUnicode(false)
                  .IsRequired();

            entity.Property(o => o.Cep)
                  .HasColumnName("Cep")
                  .HasColumnType("varchar(10)")
                  .HasMaxLength(10)
                  .IsUnicode(false)
                  .IsRequired();

            entity.HasOne(d => d.IdPessoaNavigation)
                  .WithMany(p => p.Endereco)
                  .HasForeignKey(d => d.IdPessoa)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Endereco_Pessoa");

            entity.HasOne(d => d.IdEstadoNavigation)
                  .WithMany(p => p.Endereco)
                  .HasForeignKey(d => d.IdEstado)
                  .HasConstraintName("FK_Endereco_Estado");
        }
    }
}
