using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEPOSITADOMap : EntityTypeConfiguration<DEPOSITADO>
    {
        public DEPOSITADOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDEPOSITO);

            // Properties
            this.Property(t => t.CODDEPOSITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESDEPOSITO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("DEPOSITADO");
            this.Property(t => t.CODDEPOSITO).HasColumnName("CODDEPOSITO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.DESDEPOSITO).HasColumnName("DESDEPOSITO");
            this.Property(t => t.FECDEPOSITO).HasColumnName("FECDEPOSITO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DEPOSITADOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
