using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRODUCTOSUCURSALMap : EntityTypeConfiguration<PRODUCTOSUCURSAL>
    {
        public PRODUCTOSUCURSALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPRODUCTO, t.CODSUCURSAL });

            // Properties
            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUCURSAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UBICACION)
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("PRODUCTOSUCURSAL");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.STOCKINICIAL).HasColumnName("STOCKINICIAL");
            this.Property(t => t.ULTIMOINVENTARIO).HasColumnName("ULTIMOINVENTARIO");
            this.Property(t => t.UBICACION).HasColumnName("UBICACION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.COSTOPPALCIERRE).HasColumnName("COSTOPPALCIERRE");
            this.Property(t => t.CANTIDADLIMITE).HasColumnName("CANTIDADLIMITE");

            // Relationships
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.PRODUCTOSUCURSALs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasRequired(t => t.SUCURSAL)
                .WithMany(t => t.PRODUCTOSUCURSALs)
                .HasForeignKey(d => d.CODSUCURSAL);

        }
    }
}
