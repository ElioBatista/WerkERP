using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRECIOMap : EntityTypeConfiguration<PRECIO>
    {
        public PRECIOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODTIPOCLIENTE, t.CODSUCURSAL, t.CODPRIORIDAD, t.CODPRODUCTO, t.CODMONEDA, t.CODEMPRESA });

            // Properties
            this.Property(t => t.CODTIPOCLIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUCURSAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRIORIDAD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PRECIO");
            this.Property(t => t.CODTIPOCLIENTE).HasColumnName("CODTIPOCLIENTE");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPRIORIDAD).HasColumnName("CODPRIORIDAD");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.PRECIOVENTA).HasColumnName("PRECIOVENTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.MONEDA)
                .WithMany(t => t.PRECIOs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.PRECIOPRIORIDAD)
                .WithMany(t => t.PRECIOs)
                .HasForeignKey(d => d.CODPRIORIDAD);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.PRECIOs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasRequired(t => t.SUCURSAL)
                .WithMany(t => t.PRECIOs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasRequired(t => t.TIPOCLIENTE)
                .WithMany(t => t.PRECIOs)
                .HasForeignKey(d => d.CODTIPOCLIENTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PRECIOs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
