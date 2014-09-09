using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OTCABECERAMap : EntityTypeConfiguration<OTCABECERA>
    {
        public OTCABECERAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODOT);

            // Properties
            this.Property(t => t.CODOT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(200);

            this.Property(t => t.MARCA)
                .HasMaxLength(35);

            this.Property(t => t.MODELO)
                .HasMaxLength(35);

            this.Property(t => t.ESN)
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("OTCABECERA");
            this.Property(t => t.CODOT).HasColumnName("CODOT");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODTECNICO).HasColumnName("CODTECNICO");
            this.Property(t => t.NUMOT).HasColumnName("NUMOT");
            this.Property(t => t.FECHAMOVIMIENTO).HasColumnName("FECHAMOVIMIENTO");
            this.Property(t => t.FECHAPROCESO).HasColumnName("FECHAPROCESO");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.FECHAAUTORI).HasColumnName("FECHAAUTORI");
            this.Property(t => t.FECHACIERRE).HasColumnName("FECHACIERRE");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.MARCA).HasColumnName("MARCA");
            this.Property(t => t.MODELO).HasColumnName("MODELO");
            this.Property(t => t.ESN).HasColumnName("ESN");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.TOTALOT).HasColumnName("TOTALOT");

            // Relationships
            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.OTCABECERAs)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.OTCABECERAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.OTCABECERAs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.OTCABECERAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
