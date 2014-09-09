using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ZONAMap : EntityTypeConfiguration<ZONA>
    {
        public ZONAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODZONA);

            // Properties
            this.Property(t => t.CODZONA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMZONA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESZONA)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ZONA");
            this.Property(t => t.CODZONA).HasColumnName("CODZONA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCIUDAD).HasColumnName("CODCIUDAD");
            this.Property(t => t.NUMZONA).HasColumnName("NUMZONA");
            this.Property(t => t.DESZONA).HasColumnName("DESZONA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CIUDAD)
                .WithMany(t => t.ZONAs)
                .HasForeignKey(d => d.CODCIUDAD);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ZONAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ZONAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
