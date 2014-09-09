using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPAGOMap : EntityTypeConfiguration<ORDENPAGO>
    {
        public ORDENPAGOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NROORDEN, t.CODEMPRESA });

            // Properties
            this.Property(t => t.NROORDEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CONCEPTO)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("ORDENPAGO");
            this.Property(t => t.NROORDEN).HasColumnName("NROORDEN");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.FECORDEN).HasColumnName("FECORDEN");
            this.Property(t => t.CONCEPTO).HasColumnName("CONCEPTO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.NUMEROCUOTA).HasColumnName("NUMEROCUOTA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.ORDENPAGOes)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.ORDENPAGOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ORDENPAGOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ORDENPAGOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.ORDENPAGOes)
                .HasForeignKey(d => d.CODPROVEEDOR);

        }
    }
}
