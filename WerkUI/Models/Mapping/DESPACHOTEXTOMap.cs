using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESPACHOTEXTOMap : EntityTypeConfiguration<DESPACHOTEXTO>
    {
        public DESPACHOTEXTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDESPACHO, t.LINEADETALLE, t.SECUENCIAINTERNA });

            // Properties
            this.Property(t => t.CODDESPACHO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LINEADETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SECUENCIAINTERNA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRIPCION)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("DESPACHOTEXTO");
            this.Property(t => t.CODDESPACHO).HasColumnName("CODDESPACHO");
            this.Property(t => t.LINEADETALLE).HasColumnName("LINEADETALLE");
            this.Property(t => t.SECUENCIAINTERNA).HasColumnName("SECUENCIAINTERNA");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");

            // Relationships
            this.HasRequired(t => t.DESPACHODETALLE)
                .WithMany(t => t.DESPACHOTEXTOes)
                .HasForeignKey(d => new { d.CODDESPACHO, d.LINEADETALLE });

        }
    }
}
