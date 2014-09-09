using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGORETENCIONMap : EntityTypeConfiguration<PAGORETENCION>
    {
        public PAGORETENCIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRETEN);

            // Properties
            this.Property(t => t.CODRETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMRETEN)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CONCEPTO)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.RESPONSABLE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.RUCCI)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.NUMEROEMISION)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("PAGORETENCION");
            this.Property(t => t.CODRETEN).HasColumnName("CODRETEN");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.NUMRETEN).HasColumnName("NUMRETEN");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.CONCEPTO).HasColumnName("CONCEPTO");
            this.Property(t => t.VALORRENTA).HasColumnName("VALORRENTA");
            this.Property(t => t.VALORRENTA2).HasColumnName("VALORRENTA2");
            this.Property(t => t.VALORIVA).HasColumnName("VALORIVA");
            this.Property(t => t.MONTO).HasColumnName("MONTO");
            this.Property(t => t.BASE).HasColumnName("BASE");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.RESPONSABLE).HasColumnName("RESPONSABLE");
            this.Property(t => t.RUCCI).HasColumnName("RUCCI");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECHAEMISION).HasColumnName("FECHAEMISION");
            this.Property(t => t.NUMEROEMISION).HasColumnName("NUMEROEMISION");

            // Relationships
            this.HasMany(t => t.PAGANZAS)
                .WithMany(t => t.PAGORETENCIONs)
                .Map(m =>
                    {
                        m.ToTable("PAGORETEN");
                        m.MapLeftKey("CODRETEN");
                        m.MapRightKey("CODPAGANZAS", "CODTIPOPAGO", "CODMONEDA");
                    });

            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.PAGORETENCIONs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.PAGORETENCIONs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PAGORETENCIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.PAGORETENCIONs)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.PROVEEDOR1)
                .WithMany(t => t.PAGORETENCIONs1)
                .HasForeignKey(d => d.CODPROVEEDOR);

        }
    }
}
