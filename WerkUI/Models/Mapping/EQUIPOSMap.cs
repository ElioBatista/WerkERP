using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class EQUIPOSMap : EntityTypeConfiguration<EQUIPOS>
    {
        public EQUIPOSMap()
        {
            // Primary Key
            this.HasKey(t => t.CODEQUIPO);

            // Properties
            this.Property(t => t.CODEQUIPO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ESN)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("EQUIPOS");
            this.Property(t => t.CODEQUIPO).HasColumnName("CODEQUIPO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.ESN).HasColumnName("ESN");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECHACOMPRA).HasColumnName("FECHACOMPRA");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.EQUIPOS)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.EQUIPOS)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.EQUIPOS)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.EQUIPOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
