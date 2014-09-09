using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PROPOSITOCHEQUEMap : EntityTypeConfiguration<PROPOSITOCHEQUE>
    {
        public PROPOSITOCHEQUEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPROPOSITO);

            // Properties
            this.Property(t => t.CODPROPOSITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMPROPOSITO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESPROPOSITO)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("PROPOSITOCHEQUE");
            this.Property(t => t.CODPROPOSITO).HasColumnName("CODPROPOSITO");
            this.Property(t => t.CODCONLIQUIDACION).HasColumnName("CODCONLIQUIDACION");
            this.Property(t => t.CODRUBRO1).HasColumnName("CODRUBRO1");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMPROPOSITO).HasColumnName("NUMPROPOSITO");
            this.Property(t => t.DESPROPOSITO).HasColumnName("DESPROPOSITO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");

            // Relationships
            this.HasOptional(t => t.CONCEPTOSLIQUIDACION)
                .WithMany(t => t.PROPOSITOCHEQUEs)
                .HasForeignKey(d => d.CODCONLIQUIDACION);
            this.HasOptional(t => t.RUBRO1)
                .WithMany(t => t.PROPOSITOCHEQUEs)
                .HasForeignKey(d => d.CODRUBRO1);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PROPOSITOCHEQUEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
