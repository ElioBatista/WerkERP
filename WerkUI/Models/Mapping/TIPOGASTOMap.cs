using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOGASTOMap : EntityTypeConfiguration<TIPOGASTO>
    {
        public TIPOGASTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOGASTO);

            // Properties
            this.Property(t => t.CODTIPOGASTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOGASTO)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DESTIPOGASTO)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("TIPOGASTO");
            this.Property(t => t.CODTIPOGASTO).HasColumnName("CODTIPOGASTO");
            this.Property(t => t.NUMTIPOGASTO).HasColumnName("NUMTIPOGASTO");
            this.Property(t => t.DESTIPOGASTO).HasColumnName("DESTIPOGASTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOGASTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
