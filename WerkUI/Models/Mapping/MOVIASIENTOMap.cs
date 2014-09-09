using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MOVIASIENTOMap : EntityTypeConfiguration<MOVIASIENTO>
    {
        public MOVIASIENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODASIENTO);

            // Properties
            this.Property(t => t.CODASIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MOVIASIENTO");
            this.Property(t => t.CODASIENTO).HasColumnName("CODASIENTO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODSISTEMAS).HasColumnName("CODSISTEMAS");
            this.Property(t => t.CODMODULO).HasColumnName("CODMODULO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCENTRO).HasColumnName("CODCENTRO");
            this.Property(t => t.NUMMOVIMIENTO).HasColumnName("NUMMOVIMIENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.FECHAASIENTO).HasColumnName("FECHAASIENTO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.TIPASIE).HasColumnName("TIPASIE");
            this.Property(t => t.CODASIENTOCONTA).HasColumnName("CODASIENTOCONTA");

            // Relationships
            this.HasOptional(t => t.ASIENTO)
                .WithMany(t => t.MOVIASIENTOes)
                .HasForeignKey(d => d.CODASIENTOCONTA);
            this.HasOptional(t => t.CENTROCOSTO)
                .WithMany(t => t.MOVIASIENTOes)
                .HasForeignKey(d => d.CODCENTRO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.MOVIASIENTOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.MOVIASIENTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.SISTEMA)
                .WithMany(t => t.MOVIASIENTOes)
                .HasForeignKey(d => d.CODSISTEMAS);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.MOVIASIENTOes)
                .HasForeignKey(d => d.CODSUCURSAL);

        }
    }
}
