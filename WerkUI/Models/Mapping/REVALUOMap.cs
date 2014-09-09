using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class REVALUOMap : EntityTypeConfiguration<REVALUO>
    {
        public REVALUOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODREVALUO);

            // Properties
            this.Property(t => t.CODREVALUO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INICIO)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.FIN)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("REVALUO");
            this.Property(t => t.CODREVALUO).HasColumnName("CODREVALUO");
            this.Property(t => t.CODACTIVO).HasColumnName("CODACTIVO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODASIENTO).HasColumnName("CODASIENTO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODASIDEP).HasColumnName("CODASIDEP");
            this.Property(t => t.RAVALUOANTERIOR).HasColumnName("RAVALUOANTERIOR");
            this.Property(t => t.DEPRECIAACUMULADA).HasColumnName("DEPRECIAACUMULADA");
            this.Property(t => t.COHEFICIENTE).HasColumnName("COHEFICIENTE");
            this.Property(t => t.VALORREVALUO).HasColumnName("VALORREVALUO");
            this.Property(t => t.MONTOEJERCICIO).HasColumnName("MONTOEJERCICIO");
            this.Property(t => t.DIFERENCIA).HasColumnName("DIFERENCIA");
            this.Property(t => t.CUOTADEPRE).HasColumnName("CUOTADEPRE");
            this.Property(t => t.DEPREACU).HasColumnName("DEPREACU");
            this.Property(t => t.NETO).HasColumnName("NETO");
            this.Property(t => t.DEPREACUANTERIOR).HasColumnName("DEPREACUANTERIOR");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.INICIO).HasColumnName("INICIO");
            this.Property(t => t.FIN).HasColumnName("FIN");
            this.Property(t => t.ACCION).HasColumnName("ACCION");

            // Relationships
            this.HasOptional(t => t.ACTIVOFIJO)
                .WithMany(t => t.REVALUOs)
                .HasForeignKey(d => d.CODACTIVO);
            this.HasOptional(t => t.ASIENTO)
                .WithMany(t => t.REVALUOs)
                .HasForeignKey(d => d.CODASIENTO);
            this.HasOptional(t => t.ASIENTO1)
                .WithMany(t => t.REVALUOs1)
                .HasForeignKey(d => d.CODASIDEP);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.REVALUOs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.REVALUOs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.REVALUOs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
