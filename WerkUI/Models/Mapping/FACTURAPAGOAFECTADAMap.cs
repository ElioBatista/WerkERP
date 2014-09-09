using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FACTURAPAGOAFECTADAMap : EntityTypeConfiguration<FACTURAPAGOAFECTADA>
    {
        public FACTURAPAGOAFECTADAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPAGOAFECTADA);

            // Properties
            this.Property(t => t.CODPAGOAFECTADA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FACTURAPAGOAFECTADA");
            this.Property(t => t.CODPAGOAFECTADA).HasColumnName("CODPAGOAFECTADA");
            this.Property(t => t.NUMEROCUOTA).HasColumnName("NUMEROCUOTA");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.FACTURAPAGAR)
                .WithMany(t => t.FACTURAPAGOAFECTADAs)
                .HasForeignKey(d => new { d.NUMEROCUOTA, d.CODCOMPRA });
            this.HasOptional(t => t.PAGANZA)
                .WithMany(t => t.FACTURAPAGOAFECTADAs)
                .HasForeignKey(d => new { d.CODPAGANZAS, d.CODTIPOPAGO, d.CODMONEDA });
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.FACTURAPAGOAFECTADAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
