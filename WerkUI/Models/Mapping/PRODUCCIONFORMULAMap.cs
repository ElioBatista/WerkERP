using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRODUCCIONFORMULAMap : EntityTypeConfiguration<PRODUCCIONFORMULA>
    {
        public PRODUCCIONFORMULAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODFORMULA);

            // Properties
            this.Property(t => t.CODFORMULA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PRODUCCIONFORMULA");
            this.Property(t => t.CODFORMULA).HasColumnName("CODFORMULA");
            this.Property(t => t.CODPRODUCTOTERMINADO).HasColumnName("CODPRODUCTOTERMINADO");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.PRODUCCIONFORMULAs)
                .HasForeignKey(d => d.CODPRODUCTOTERMINADO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PRODUCCIONFORMULAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
