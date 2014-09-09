using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CONCEPTOTIPOMOVIMIENTOMap : EntityTypeConfiguration<CONCEPTOTIPOMOVIMIENTO>
    {
        public CONCEPTOTIPOMOVIMIENTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODTIPOMOVDET, t.CODTIPOMOVCABECERA, t.CODTIPOMOV });

            // Properties
            this.Property(t => t.CODTIPOMOVDET)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTIPOMOVCABECERA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OPERACION)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CODTIPOMOV)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CONCEPTOTIPOMOVIMIENTOS");
            this.Property(t => t.CODTIPOMOVDET).HasColumnName("CODTIPOMOVDET");
            this.Property(t => t.CODTIPOMOVCABECERA).HasColumnName("CODTIPOMOVCABECERA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.OPERACION).HasColumnName("OPERACION");
            this.Property(t => t.CODTIPOMOV).HasColumnName("CODTIPOMOV");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.TIPOMOVIMIENTOSUELDODETALLE)
                .WithMany(t => t.CONCEPTOTIPOMOVIMIENTOS)
                .HasForeignKey(d => new { d.CODTIPOMOVDET, d.CODTIPOMOVCABECERA });
            this.HasRequired(t => t.TIPOMOVIMIENTOSUELDO)
                .WithMany(t => t.CONCEPTOTIPOMOVIMIENTOS)
                .HasForeignKey(d => d.CODTIPOMOV);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CONCEPTOTIPOMOVIMIENTOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
