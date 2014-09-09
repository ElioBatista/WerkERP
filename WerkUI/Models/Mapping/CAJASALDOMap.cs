using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJASALDOMap : EntityTypeConfiguration<CAJASALDO>
    {
        public CAJASALDOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NUMCIERRE, t.CODMONEDA });

            // Properties
            this.Property(t => t.NUMCIERRE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CAJASALDO");
            this.Property(t => t.NUMCIERRE).HasColumnName("NUMCIERRE");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.SALDOINICIAL).HasColumnName("SALDOINICIAL");
            this.Property(t => t.SALDOCIERRE).HasColumnName("SALDOCIERRE");

            // Relationships
            this.HasRequired(t => t.CAJACIERRE)
                .WithMany(t => t.CAJASALDOes)
                .HasForeignKey(d => d.NUMCIERRE);
            this.HasRequired(t => t.MONEDA)
                .WithMany(t => t.CAJASALDOes)
                .HasForeignKey(d => d.CODMONEDA);

        }
    }
}
