using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SALARIOSMINIMOMap : EntityTypeConfiguration<SALARIOSMINIMO>
    {
        public SALARIOSMINIMOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODSALARIO);

            // Properties
            this.Property(t => t.CODSALARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SALARIOSMINIMOS");
            this.Property(t => t.CODSALARIO).HasColumnName("CODSALARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.FECHADESDE).HasColumnName("FECHADESDE");
            this.Property(t => t.FECHAHASTA).HasColumnName("FECHAHASTA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.SALARIOSMINIMOS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SALARIOSMINIMOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
