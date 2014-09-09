using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CONOCIMIENTOMap : EntityTypeConfiguration<CONOCIMIENTO>
    {
        public CONOCIMIENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCONOCIMIENTO);

            // Properties
            this.Property(t => t.CODCONOCIMIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCONOCIMIENTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCONOCIMIENTO)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CONOCIMIENTO");
            this.Property(t => t.CODCONOCIMIENTO).HasColumnName("CODCONOCIMIENTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCONOCIMIENTO).HasColumnName("NUMCONOCIMIENTO");
            this.Property(t => t.DESCONOCIMIENTO).HasColumnName("DESCONOCIMIENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CONOCIMIENTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
