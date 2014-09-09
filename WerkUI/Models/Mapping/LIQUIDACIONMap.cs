using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class LIQUIDACIONMap : EntityTypeConfiguration<LIQUIDACION>
    {
        public LIQUIDACIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODLIQUIDACION, t.SECUENCIAINTERNA });

            // Properties
            this.Property(t => t.CODLIQUIDACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SECUENCIAINTERNA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.COMENTARIO)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.DESCONLIQUIDACION)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("LIQUIDACION");
            this.Property(t => t.CODLIQUIDACION).HasColumnName("CODLIQUIDACION");
            this.Property(t => t.SECUENCIAINTERNA).HasColumnName("SECUENCIAINTERNA");
            this.Property(t => t.COMENTARIO).HasColumnName("COMENTARIO");
            this.Property(t => t.CODCONLIQUIDACION).HasColumnName("CODCONLIQUIDACION");
            this.Property(t => t.DESCONLIQUIDACION).HasColumnName("DESCONLIQUIDACION");
            this.Property(t => t.GRUPOIMPRESION).HasColumnName("GRUPOIMPRESION");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
        }
    }
}
