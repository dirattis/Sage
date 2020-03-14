
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sage.Pessoas.Domain;

namespace Sage.Pessoas.Infra.Data.Configurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Logradouro).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Numero).HasColumnType("varchar(10)").IsRequired();
            builder.Property(x => x.Complemento).HasColumnType("varchar(50)");
            builder.Property(x => x.Bairro).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Cidade).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Estado).HasColumnType("char(2)").IsRequired();

            builder.HasOne(x => x.Pessoa)
                .WithOne(x => x.Endereco)
                .HasForeignKey<Pessoa>(x => x.EnderecoId);
        }
    }
}

