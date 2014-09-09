using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class NOMBRECONTACTO2Map : EntityTypeConfiguration<NOMBRECONTACTO2>
    {
        public NOMBRECONTACTO2Map()
        {
            // Primary Key
            this.HasKey(t => t.CODNOMBRECONTACTO2);

            // Properties
            this.Property(t => t.NUMCONTACTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESNOMBRECONTACTO2)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("NOMBRECONTACTO2");
            this.Property(t => t.CODNOMBRECONTACTO2).HasColumnName("CODNOMBRECONTACTO2");
            this.Property(t => t.CODCARGO).HasColumnName("CODCARGO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.NUMCONTACTO).HasColumnName("NUMCONTACTO");
            this.Property(t => t.DESNOMBRECONTACTO2).HasColumnName("DESNOMBRECONTACTO2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CARGOCONTACTO)
                .WithMany(t => t.NOMBRECONTACTO2)
                .HasForeignKey(d => d.CODCARGO);
            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.NOMBRECONTACTO2)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.NOMBRECONTACTO2)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
