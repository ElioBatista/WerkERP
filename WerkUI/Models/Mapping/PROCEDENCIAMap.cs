using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PROCEDENCIAMap : EntityTypeConfiguration<PROCEDENCIA>
    {
        public PROCEDENCIAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPROCEDENCIA);

            // Properties
            this.Property(t => t.CODPROCEDENCIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMPROCEDENCIA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESPROCEDENCIA)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("PROCEDENCIA");
            this.Property(t => t.CODPROCEDENCIA).HasColumnName("CODPROCEDENCIA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMPROCEDENCIA).HasColumnName("NUMPROCEDENCIA");
            this.Property(t => t.DESPROCEDENCIA).HasColumnName("DESPROCEDENCIA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PROCEDENCIAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
