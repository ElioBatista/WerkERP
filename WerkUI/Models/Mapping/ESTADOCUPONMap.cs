using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ESTADOCUPONMap : EntityTypeConfiguration<ESTADOCUPON>
    {
        public ESTADOCUPONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODESTADOCUPON);

            // Properties
            this.Property(t => t.CODESTADOCUPON)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMESTADOCUPON)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESESTADOCUPON)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ESTADOCUPON");
            this.Property(t => t.CODESTADOCUPON).HasColumnName("CODESTADOCUPON");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMESTADOCUPON).HasColumnName("NUMESTADOCUPON");
            this.Property(t => t.DESESTADOCUPON).HasColumnName("DESESTADOCUPON");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ESTADOCUPONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
