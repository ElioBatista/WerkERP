using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SUCURSALLIMITEPRODMap : EntityTypeConfiguration<SUCURSALLIMITEPROD>
    {
        public SUCURSALLIMITEPRODMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODSUCURSAL, t.CODPRODUCTO });

            // Properties
            this.Property(t => t.CODSUCURSAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SUCURSALLIMITEPROD");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDADMAXIMA).HasColumnName("CANTIDADMAXIMA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.SUCURSALLIMITEPRODs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasRequired(t => t.SUCURSAL)
                .WithMany(t => t.SUCURSALLIMITEPRODs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SUCURSALLIMITEPRODs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
