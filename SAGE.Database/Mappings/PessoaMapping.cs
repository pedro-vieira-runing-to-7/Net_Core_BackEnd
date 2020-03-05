using SAGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SAGE.Database.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> entity)
        {
            //entity.HasKey(o => o.Id);
            entity.Property(o => o.Id)
                  .HasColumnName("Id")
                  .HasColumnType("uniqueidentifier")
                  .HasDefaultValueSql("(newid())");

            entity.Property(o => o.CpfCnpj)
                  .HasColumnName("CpfCnpj")
                  .HasColumnType("varchar(20)")
                  .HasMaxLength(20)
                  .IsUnicode(false)
                  .IsRequired();

            entity.Property(o => o.DataCadastro)
                  .HasColumnName("DataCadastro")
                  .HasColumnType("Datetime")
                  .IsRequired();

            entity.Property(o => o.DataAtualizacao)
                  .HasColumnName("DataAtualizacao")
                  .HasColumnType("Datetime")
                  .IsRequired();

            entity.Property(o => o.DataNascimentoAbertura)
                  .HasColumnName("DataNascimentoAbertura")
                  .HasColumnType("Date");

            //entity.Property(o => o.IdStatus)
            //      .HasColumnName("IdStatus")
            //      .HasColumnType("int")
            //      .IsRequired();

            //entity.Property(o => o.IdTipoPessoa)
            //   .HasColumnName("IdTipoPessoa")
            //   .HasColumnType("int")
            //   .IsRequired();

            entity.Property(e => e.IdStatus).HasColumnName("IdStatus");

            entity.Property(e => e.IdTipoPessoa).HasColumnName("IdTipoPessoa");

            entity.Property(o => o.Nome)
                  .HasColumnName("Nome")
                  .HasColumnType("varchar(70)")
                  .HasMaxLength(70)
                  .IsUnicode(false)
                  .IsRequired();

            entity.Property(o => o.NomeSocial)
                  .HasColumnName("NomeSocial")
                  .HasColumnType("varchar(100)")
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .IsRequired();           

            entity.Property(o => o.Sexo)
                  .HasColumnName("Sexo")
                  .HasColumnType("varchar(1)")
                  .HasMaxLength(1)
                  .IsUnicode(false);

            entity.Property(o => o.Email)
                  .HasColumnName("Email")
                  .HasColumnType("varchar(100)")
                  .HasMaxLength(100)
                  .IsUnicode(false);

            entity.Property(o => o.NumeroTelefoneFixo)
                  .HasColumnName("NumeroTelefoneFixo")
                  .HasColumnType("varchar(20)")
                  .HasMaxLength(20)
                  .IsUnicode(false);

            entity.Property(o => o.NumeroCelular)
                  .HasColumnName("NumeroCelular")
                  .HasColumnType("varchar(20)")
                  .HasMaxLength(20)
                  .IsUnicode(false);
        }
    }
}
