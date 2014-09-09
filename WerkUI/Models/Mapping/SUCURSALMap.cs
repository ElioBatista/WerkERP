using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SUCURSALMap : EntityTypeConfiguration<SUCURSAL>
    {
        public SUCURSALMap()
        {
            // Primary Key
            this.HasKey(t => t.CODSUCURSAL);

            // Properties
            this.Property(t => t.CODSUCURSAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMSUCURSAL)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESSUCURSAL)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.DIRECCION)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.TELEFONO)
                .IsFixedLength()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("SUCURSAL");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODZONA).HasColumnName("CODZONA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMSUCURSAL).HasColumnName("NUMSUCURSAL");
            this.Property(t => t.DESSUCURSAL).HasColumnName("DESSUCURSAL");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SUCURSALs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.ZONA)
                .WithMany(t => t.SUCURSALs)
                .HasForeignKey(d => d.CODZONA);

        }
    }
}
