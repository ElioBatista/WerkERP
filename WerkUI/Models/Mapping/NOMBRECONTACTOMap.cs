using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class NOMBRECONTACTOMap : EntityTypeConfiguration<NOMBRECONTACTO>
    {
        public NOMBRECONTACTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODNOMBRECONTACTO);

            // Properties
            this.Property(t => t.NUMCONTACTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESNOMBRECONTACTO)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("NOMBRECONTACTO");
            this.Property(t => t.CODNOMBRECONTACTO).HasColumnName("CODNOMBRECONTACTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.CODCARGO).HasColumnName("CODCARGO");
            this.Property(t => t.NUMCONTACTO).HasColumnName("NUMCONTACTO");
            this.Property(t => t.DESNOMBRECONTACTO).HasColumnName("DESNOMBRECONTACTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CARGOCONTACTO)
                .WithMany(t => t.NOMBRECONTACTOes)
                .HasForeignKey(d => d.CODCARGO);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.NOMBRECONTACTOes)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.NOMBRECONTACTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
