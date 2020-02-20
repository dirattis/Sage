
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sage.Pessoas.Domain;

namespace Sage.Pessoas.Infra.Data.Configurations
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CPF).HasColumnType("char(11)");
            builder.Property(x => x.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(50)");

            builder.HasOne(x => x.Endereco)
                .WithOne(x => x.Pessoa)
                .HasForeignKey<Endereco>(x => x.Id);
        }
    }
}
