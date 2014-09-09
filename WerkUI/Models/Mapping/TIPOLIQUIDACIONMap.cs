using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOLIQUIDACIONMap : EntityTypeConfiguration<TIPOLIQUIDACION>
    {
        public TIPOLIQUIDACIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODLIQUIDACION);

            // Properties
            this.Property(t => t.CODLIQUIDACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMLIQUIDACION)
                .HasMaxLength(5);

            this.Property(t => t.DESLIQUIDACION)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("TIPOLIQUIDACION");
            this.Property(t => t.CODLIQUIDACION).HasColumnName("CODLIQUIDACION");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.NUMLIQUIDACION).HasColumnName("NUMLIQUIDACION");
            this.Property(t => t.DESLIQUIDACION).HasColumnName("DESLIQUIDACION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOLIQUIDACIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
