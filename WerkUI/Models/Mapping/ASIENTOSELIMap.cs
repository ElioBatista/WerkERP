using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ASIENTOSELIMap : EntityTypeConfiguration<ASIENTOSELI>
    {
        public ASIENTOSELIMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODASIENTOELI, t.CODASIENTO });

            // Properties
            this.Property(t => t.CODASIENTOELI)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODASIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ASIENTOSELI");
            this.Property(t => t.CODASIENTOELI).HasColumnName("CODASIENTOELI");
            this.Property(t => t.CODASIENTO).HasColumnName("CODASIENTO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCENTRO).HasColumnName("CODCENTRO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.NUMASIENTO).HasColumnName("NUMASIENTO");
            this.Property(t => t.FECHAASIENTO).HasColumnName("FECHAASIENTO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.MARCACIERRE).HasColumnName("MARCACIERRE");
            this.Property(t => t.GENERADO).HasColumnName("GENERADO");
            this.Property(t => t.HISTORICO).HasColumnName("HISTORICO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.FECELIMINADO).HasColumnName("FECELIMINADO");
            this.Property(t => t.USUELIMINADO).HasColumnName("USUELIMINADO");
            this.Property(t => t.ELIMINADO).HasColumnName("ELIMINADO");

            // Relationships
            this.HasOptional(t => t.CENTROCOSTO)
                .WithMany(t => t.ASIENTOSELIs)
                .HasForeignKey(d => d.CODCENTRO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.ASIENTOSELIs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ASIENTOSELIs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ASIENTOSELIs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
