using Dqc.Infraestructure.EFCore.EntityConfigurations;
using EstudioAbogados.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudioAbogados.Infraestructure.EFCore.EntityConfigurations
{
    public class AbogadoEntityTypeConfiguration : FullAuditableEntityTypeConfiguration<Abogado>
    {
        public override void Configure(EntityTypeBuilder<Abogado> builder)
        {
            builder.ToTable("TB_ABOGADO");

            builder.Property(a => a.ApPaterno)
                .HasColumnName("APPATERNO")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.ApMaterno)
                .HasColumnName("APMATERNO")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Nombres)
                .HasColumnName("NOMBRES")
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(a => a.NroDocumento)
                .HasColumnName("NRODOCUMENTO")
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(a => a.CodColegioAB)
                .HasColumnName("COD_COLEGIOAB")
                .HasMaxLength(50);

            base.Configure(builder);
        }
    }
}
