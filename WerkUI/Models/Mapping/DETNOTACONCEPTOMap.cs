using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DETNOTACONCEPTOMap : EntityTypeConfiguration<DETNOTACONCEPTO>
    {
        public DETNOTACONCEPTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODEMPRESA, t.CODNOTACONCEPTO });

            // Properties
            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODNOTACONCEPTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DETNOTACONCEPTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODNOTACONCEPTO).HasColumnName("CODNOTACONCEPTO");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.NOTACONCEPTO)
                .WithMany(t => t.DETNOTACONCEPTOes)
                .HasForeignKey(d => d.CODNOTACONCEPTO);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.DETNOTACONCEPTOes)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DETNOTACONCEPTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
