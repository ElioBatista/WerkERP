using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OTMANOOBRAMap : EntityTypeConfiguration<OTMANOOBRA>
    {
        public OTMANOOBRAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODOT, t.CODDETALLE });

            // Properties
            this.Property(t => t.CODOT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRIPCION)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OTMANOOBRA");
            this.Property(t => t.CODOT).HasColumnName("CODOT");
            this.Property(t => t.CODDETALLE).HasColumnName("CODDETALLE");
            this.Property(t => t.CODTECNICO).HasColumnName("CODTECNICO");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.FECHAMOV).HasColumnName("FECHAMOV");
            this.Property(t => t.HORASTRAB).HasColumnName("HORASTRAB");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasRequired(t => t.OTCABECERA)
                .WithMany(t => t.OTMANOOBRAs)
                .HasForeignKey(d => d.CODOT);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.OTMANOOBRAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
