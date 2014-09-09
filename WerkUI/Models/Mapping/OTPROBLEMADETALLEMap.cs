using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OTPROBLEMADETALLEMap : EntityTypeConfiguration<OTPROBLEMADETALLE>
    {
        public OTPROBLEMADETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDETALLE, t.CODOT });

            // Properties
            this.Property(t => t.CODDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODOT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRIPCION)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OTPROBLEMADETALLE");
            this.Property(t => t.CODDETALLE).HasColumnName("CODDETALLE");
            this.Property(t => t.CODOT).HasColumnName("CODOT");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasRequired(t => t.OTCABECERA)
                .WithMany(t => t.OTPROBLEMADETALLEs)
                .HasForeignKey(d => d.CODOT);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.OTPROBLEMADETALLEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
