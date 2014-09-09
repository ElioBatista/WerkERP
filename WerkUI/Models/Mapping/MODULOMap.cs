using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MODULOMap : EntityTypeConfiguration<MODULO>
    {
        public MODULOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODMODULO);

            // Properties
            this.Property(t => t.CODMODULO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESMODULO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("MODULOS");
            this.Property(t => t.CODMODULO).HasColumnName("CODMODULO");
            this.Property(t => t.CODSISTEMAS).HasColumnName("CODSISTEMAS");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.DESMODULO).HasColumnName("DESMODULO");
            this.Property(t => t.USUARIO).HasColumnName("USUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.EMPRESA)
                .WithMany(t => t.MODULOS)
                .HasForeignKey(d => d.CODEMPRESA);
            this.HasOptional(t => t.SISTEMA)
                .WithMany(t => t.MODULOS)
                .HasForeignKey(d => d.CODSISTEMAS);
            this.HasOptional(t => t.SISTEMA1)
                .WithMany(t => t.MODULOS1)
                .HasForeignKey(d => d.CODSISTEMAS);

        }
    }
}
