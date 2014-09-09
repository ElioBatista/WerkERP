using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VIDAUTILMap : EntityTypeConfiguration<VIDAUTIL>
    {
        public VIDAUTILMap()
        {
            // Primary Key
            this.HasKey(t => t.CODVIDAUTIL);

            // Properties
            this.Property(t => t.CODVIDAUTIL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESVIDAUTIL)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("VIDAUTIL");
            this.Property(t => t.CODVIDAUTIL).HasColumnName("CODVIDAUTIL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.DESVIDAUTIL).HasColumnName("DESVIDAUTIL");
            this.Property(t => t.CANTIDADANHO).HasColumnName("CANTIDADANHO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.VIDAUTILs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
