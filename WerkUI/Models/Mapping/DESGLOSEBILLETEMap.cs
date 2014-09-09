using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESGLOSEBILLETEMap : EntityTypeConfiguration<DESGLOSEBILLETE>
    {
        public DESGLOSEBILLETEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDESGLOSE);

            // Properties
            this.Property(t => t.CODDESGLOSE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDESGLOSE)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.NUMCUENTA)
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DESGLOSEBILLETE");
            this.Property(t => t.CODDESGLOSE).HasColumnName("CODDESGLOSE");
            this.Property(t => t.NUMDESGLOSE).HasColumnName("NUMDESGLOSE");
            this.Property(t => t.CODBANCO).HasColumnName("CODBANCO");
            this.Property(t => t.NUMCUENTA).HasColumnName("NUMCUENTA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CUENTABANCARIA)
                .WithMany(t => t.DESGLOSEBILLETEs)
                .HasForeignKey(d => new { d.NUMCUENTA, d.CODBANCO });
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DESGLOSEBILLETEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
