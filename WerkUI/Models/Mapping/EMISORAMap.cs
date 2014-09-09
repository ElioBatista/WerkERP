using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class EMISORAMap : EntityTypeConfiguration<EMISORA>
    {
        public EMISORAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODEMISORA);

            // Properties
            this.Property(t => t.CODEMISORA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEMISORA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESEMISORA)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("EMISORA");
            this.Property(t => t.CODEMISORA).HasColumnName("CODEMISORA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMEMISORA).HasColumnName("NUMEMISORA");
            this.Property(t => t.DESEMISORA).HasColumnName("DESEMISORA");
            this.Property(t => t.COMISION).HasColumnName("COMISION");
            this.Property(t => t.IVA).HasColumnName("IVA");
            this.Property(t => t.RETENCIONRENTA).HasColumnName("RETENCIONRENTA");
            this.Property(t => t.RETENCIONIVA).HasColumnName("RETENCIONIVA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.EMISORAs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.EMISORAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
