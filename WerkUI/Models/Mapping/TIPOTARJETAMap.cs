using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOTARJETAMap : EntityTypeConfiguration<TIPOTARJETA>
    {
        public TIPOTARJETAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTARJETA);

            // Properties
            this.Property(t => t.CODTARJETA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOTARJE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTARJETA)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOTARJETA");
            this.Property(t => t.CODTARJETA).HasColumnName("CODTARJETA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPOTARJE).HasColumnName("NUMTIPOTARJE");
            this.Property(t => t.DESTARJETA).HasColumnName("DESTARJETA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOTARJETAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
