using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGOERETENNCMap : EntityTypeConfiguration<PAGOERETENNC>
    {
        public PAGOERETENNCMap()
        {
            // Primary Key
            this.HasKey(t => t.CODAFECTADA);

            // Properties
            this.Property(t => t.CODAFECTADA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PAGOERETENNC");
            this.Property(t => t.CODAFECTADA).HasColumnName("CODAFECTADA");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODNCREDITO).HasColumnName("CODNCREDITO");
            this.Property(t => t.CODRETEN).HasColumnName("CODRETEN");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.PAGOERETENNCs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.PAGONOTACREDITO)
                .WithMany(t => t.PAGOERETENNCs)
                .HasForeignKey(d => d.CODNCREDITO);
            this.HasOptional(t => t.PAGORETENCION)
                .WithMany(t => t.PAGOERETENNCs)
                .HasForeignKey(d => d.CODRETEN);

        }
    }
}
