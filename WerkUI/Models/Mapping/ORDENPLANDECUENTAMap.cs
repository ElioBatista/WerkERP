using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPLANDECUENTAMap : EntityTypeConfiguration<ORDENPLANDECUENTA>
    {
        public ORDENPLANDECUENTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODEMPRESA);

            // Properties
            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ORDENPLANDECUENTAS");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.ACTIVO).HasColumnName("ACTIVO");
            this.Property(t => t.PASIVO).HasColumnName("PASIVO");
            this.Property(t => t.INGRESOS).HasColumnName("INGRESOS");
            this.Property(t => t.EGRESOS).HasColumnName("EGRESOS");
            this.Property(t => t.RESULTADO).HasColumnName("RESULTADO");
            this.Property(t => t.PATRIMONIO).HasColumnName("PATRIMONIO");
            this.Property(t => t.FUTURO1).HasColumnName("FUTURO1");
            this.Property(t => t.FUTURO2).HasColumnName("FUTURO2");
            this.Property(t => t.FUTURO3).HasColumnName("FUTURO3");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ORDENPLANDECUENTAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
