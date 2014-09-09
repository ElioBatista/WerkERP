using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CENTROCOSTOMap : EntityTypeConfiguration<CENTROCOSTO>
    {
        public CENTROCOSTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCENTRO);

            // Properties
            this.Property(t => t.CODCENTRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCENTRO)
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.DESCENTRO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("CENTROCOSTO");
            this.Property(t => t.CODCENTRO).HasColumnName("CODCENTRO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.NUMCENTRO).HasColumnName("NUMCENTRO");
            this.Property(t => t.DESCENTRO).HasColumnName("DESCENTRO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.CENTROCOSTOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CENTROCOSTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
