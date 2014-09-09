using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class INVENTARIODIFERENCIAMap : EntityTypeConfiguration<INVENTARIODIFERENCIA>
    {
        public INVENTARIODIFERENCIAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDIFERENCIA);

            // Properties
            this.Property(t => t.CODDIFERENCIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("INVENTARIODIFERENCIA");
            this.Property(t => t.CODDIFERENCIA).HasColumnName("CODDIFERENCIA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.FECHACIERRE).HasColumnName("FECHACIERRE");
            this.Property(t => t.CANTIDADENCONTRADA).HasColumnName("CANTIDADENCONTRADA");
            this.Property(t => t.STOCKACTUAL).HasColumnName("STOCKACTUAL");
            this.Property(t => t.COSTOPPALCIERRE).HasColumnName("COSTOPPALCIERRE");
            this.Property(t => t.TIPOINVENTARIO).HasColumnName("TIPOINVENTARIO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.INVENTARIODIFERENCIAs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.INVENTARIODIFERENCIAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.INVENTARIODIFERENCIAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
