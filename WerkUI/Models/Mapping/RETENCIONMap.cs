using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class RETENCIONMap : EntityTypeConfiguration<RETENCION>
    {
        public RETENCIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRETENCION);

            // Properties
            this.Property(t => t.CODRETENCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESRETENCION)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("RETENCION");
            this.Property(t => t.CODRETENCION).HasColumnName("CODRETENCION");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.USUGRA).HasColumnName("USUGRA");
            this.Property(t => t.DESRETENCION).HasColumnName("DESRETENCION");
            this.Property(t => t.VALRETENCION).HasColumnName("VALRETENCION");
            this.Property(t => t.CUALRETENCION).HasColumnName("CUALRETENCION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");

            // Relationships
            this.HasOptional(t => t.EMPRESA)
                .WithMany(t => t.RETENCIONs)
                .HasForeignKey(d => d.CODEMPRESA);

        }
    }
}
