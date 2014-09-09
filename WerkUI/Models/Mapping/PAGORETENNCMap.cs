using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGORETENNCMap : EntityTypeConfiguration<PAGORETENNC>
    {
        public PAGORETENNCMap()
        {
            // Primary Key
            this.HasKey(t => t.CODAFECTADA);

            // Properties
            this.Property(t => t.CODAFECTADA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PAGORETENNC");
            this.Property(t => t.CODAFECTADA).HasColumnName("CODAFECTADA");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODNCREDITO).HasColumnName("CODNCREDITO");
            this.Property(t => t.CODRETEN).HasColumnName("CODRETEN");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.PAGORETENNCs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.PAGONOTACREDITO)
                .WithMany(t => t.PAGORETENNCs)
                .HasForeignKey(d => d.CODNCREDITO);
            this.HasOptional(t => t.PAGORETENCION)
                .WithMany(t => t.PAGORETENNCs)
                .HasForeignKey(d => d.CODRETEN);

        }
    }
}
