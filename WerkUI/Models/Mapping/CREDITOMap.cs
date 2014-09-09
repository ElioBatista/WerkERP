using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CREDITOMap : EntityTypeConfiguration<CREDITO>
    {
        public CREDITOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCREDITO);

            // Properties
            this.Property(t => t.CODCREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCUENTA)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.NUMCEDULA)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.DETALLE)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("CREDITOS");
            this.Property(t => t.CODCREDITO).HasColumnName("CODCREDITO");
            this.Property(t => t.NUMCUENTA).HasColumnName("NUMCUENTA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODTIPOCREDITO).HasColumnName("CODTIPOCREDITO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMDEPOSITO).HasColumnName("NUMDEPOSITO");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.NUMCEDULA).HasColumnName("NUMCEDULA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.EFECTIVO).HasColumnName("EFECTIVO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.FECHACONCILIACION).HasColumnName("FECHACONCILIACION");
            this.Property(t => t.CODBANCO).HasColumnName("CODBANCO");
            this.Property(t => t.DETALLE).HasColumnName("DETALLE");
            this.Property(t => t.FECHAVENTA).HasColumnName("FECHAVENTA");

            // Relationships
            this.HasOptional(t => t.CUENTABANCARIA)
                .WithMany(t => t.CREDITOS)
                .HasForeignKey(d => new { d.NUMCUENTA, d.CODBANCO });
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CREDITOS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.TIPOCREDITO)
                .WithMany(t => t.CREDITOS)
                .HasForeignKey(d => d.CODTIPOCREDITO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CREDITOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
