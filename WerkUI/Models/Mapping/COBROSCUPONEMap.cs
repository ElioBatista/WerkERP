using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COBROSCUPONEMap : EntityTypeConfiguration<COBROSCUPONE>
    {
        public COBROSCUPONEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPAGOS);

            // Properties
            this.Property(t => t.CODPAGOS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOMPROBANTE)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("COBROSCUPONES");
            this.Property(t => t.CODPAGOS).HasColumnName("CODPAGOS");
            this.Property(t => t.CODDEPOSITO).HasColumnName("CODDEPOSITO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCOBRO).HasColumnName("CODCOBRO");
            this.Property(t => t.CODEMISORA).HasColumnName("CODEMISORA");
            this.Property(t => t.NUMCOMPROBANTE).HasColumnName("NUMCOMPROBANTE");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.IMPORTEIVA).HasColumnName("IMPORTEIVA");
            this.Property(t => t.IMPORTECOMI).HasColumnName("IMPORTECOMI");
            this.Property(t => t.IMPORTERENTA).HasColumnName("IMPORTERENTA");
            this.Property(t => t.RETENCIONIVA).HasColumnName("RETENCIONIVA");
            this.Property(t => t.FECHACOBRO).HasColumnName("FECHACOBRO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasMany(t => t.CUPONES)
                .WithMany(t => t.COBROSCUPONES)
                .Map(m =>
                    {
                        m.ToTable("COBROCUPON");
                        m.MapLeftKey("CODPAGOS");
                        m.MapRightKey("CODCUPON", "CODEMPRESA", "CODEMISORA");
                    });

            this.HasOptional(t => t.DEPOSITADO)
                .WithMany(t => t.COBROSCUPONES)
                .HasForeignKey(d => d.CODDEPOSITO);
            this.HasOptional(t => t.EMISORA)
                .WithMany(t => t.COBROSCUPONES)
                .HasForeignKey(d => d.CODEMISORA);
            this.HasOptional(t => t.TIPOCOBRO)
                .WithMany(t => t.COBROSCUPONES)
                .HasForeignKey(d => d.CODCOBRO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.COBROSCUPONES)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
