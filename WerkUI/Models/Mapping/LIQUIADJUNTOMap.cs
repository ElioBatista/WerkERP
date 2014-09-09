using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class LIQUIADJUNTOMap : EntityTypeConfiguration<LIQUIADJUNTO>
    {
        public LIQUIADJUNTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDESPACHO, t.SECUENCIAINTERNA });

            // Properties
            this.Property(t => t.CODDESPACHO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SECUENCIAINTERNA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("LIQUIADJUNTO");
            this.Property(t => t.CODDESPACHO).HasColumnName("CODDESPACHO");
            this.Property(t => t.SECUENCIAINTERNA).HasColumnName("SECUENCIAINTERNA");
            this.Property(t => t.CODADJUNTO).HasColumnName("CODADJUNTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.ADJUNTO)
                .WithMany(t => t.LIQUIADJUNTOes)
                .HasForeignKey(d => d.CODADJUNTO);
            this.HasRequired(t => t.DESPACHO)
                .WithMany(t => t.LIQUIADJUNTOes)
                .HasForeignKey(d => d.CODDESPACHO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.LIQUIADJUNTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
