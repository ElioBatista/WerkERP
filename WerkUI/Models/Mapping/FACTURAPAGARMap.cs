using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FACTURAPAGARMap : EntityTypeConfiguration<FACTURAPAGAR>
    {
        public FACTURAPAGARMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NUMEROCUOTA, t.CODCOMPRA });

            // Properties
            this.Property(t => t.NUMEROCUOTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FACTURAPAGAR");
            this.Property(t => t.NUMEROCUOTA).HasColumnName("NUMEROCUOTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.FECHAVCTO).HasColumnName("FECHAVCTO");
            this.Property(t => t.SALDOCUOTA).HasColumnName("SALDOCUOTA");
            this.Property(t => t.IMPORTECUOTA).HasColumnName("IMPORTECUOTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.COMPRA)
                .WithMany(t => t.FACTURAPAGARs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.FACTURAPAGARs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
