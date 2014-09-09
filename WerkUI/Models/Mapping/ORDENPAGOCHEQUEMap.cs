using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPAGOCHEQUEMap : EntityTypeConfiguration<ORDENPAGOCHEQUE>
    {
        public ORDENPAGOCHEQUEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODAFECTADA);

            // Properties
            this.Property(t => t.CODAFECTADA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ORDENPAGOCHEQUE");
            this.Property(t => t.CODAFECTADA).HasColumnName("CODAFECTADA");
            this.Property(t => t.CODDEBITO).HasColumnName("CODDEBITO");
            this.Property(t => t.NROORDEN).HasColumnName("NROORDEN");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.NUMEROCUOTA).HasColumnName("NUMEROCUOTA");
            this.Property(t => t.IMPORTEPAGO).HasColumnName("IMPORTEPAGO");

            // Relationships
            this.HasOptional(t => t.DEBITO)
                .WithMany(t => t.ORDENPAGOCHEQUEs)
                .HasForeignKey(d => d.CODDEBITO);
            this.HasOptional(t => t.FACTURAPAGAR)
                .WithMany(t => t.ORDENPAGOCHEQUEs)
                .HasForeignKey(d => new { d.NUMEROCUOTA, d.CODCOMPRA });
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.ORDENPAGOCHEQUEs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.ORDENPAGO)
                .WithMany(t => t.ORDENPAGOCHEQUEs)
                .HasForeignKey(d => new { d.NROORDEN, d.CODEMPRESA });

        }
    }
}
