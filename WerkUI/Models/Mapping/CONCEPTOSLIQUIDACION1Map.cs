using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CONCEPTOSLIQUIDACION1Map : EntityTypeConfiguration<CONCEPTOSLIQUIDACION1>
    {
        public CONCEPTOSLIQUIDACION1Map()
        {
            // Primary Key
            this.HasKey(t => t.CODCONLIQUIDACION);

            // Properties
            this.Property(t => t.CODCONLIQUIDACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCONLIQUIDACION)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCONLIQUIDACION)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CONCEPTOSLIQUIDACION");
            this.Property(t => t.CODCONLIQUIDACION).HasColumnName("CODCONLIQUIDACION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCONLIQUIDACION).HasColumnName("NUMCONLIQUIDACION");
            this.Property(t => t.DESCONLIQUIDACION).HasColumnName("DESCONLIQUIDACION");
            this.Property(t => t.GRUPOIMPRESION).HasColumnName("GRUPOIMPRESION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
        }
    }
}
