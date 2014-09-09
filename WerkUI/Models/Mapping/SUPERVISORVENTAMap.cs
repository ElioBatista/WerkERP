using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SUPERVISORVENTAMap : EntityTypeConfiguration<SUPERVISORVENTA>
    {
        public SUPERVISORVENTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODSUPERVISOR);

            // Properties
            this.Property(t => t.CODSUPERVISOR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMSUPERVISOR)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCRIPCION)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.TELEFONO)
                .HasMaxLength(30);

            this.Property(t => t.CELULAR)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("SUPERVISORVENTA");
            this.Property(t => t.CODSUPERVISOR).HasColumnName("CODSUPERVISOR");
            this.Property(t => t.NUMSUPERVISOR).HasColumnName("NUMSUPERVISOR");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.CODZONA).HasColumnName("CODZONA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
            this.Property(t => t.CELULAR).HasColumnName("CELULAR");
            this.Property(t => t.MAXIMO).HasColumnName("MAXIMO");
            this.Property(t => t.MINIMO).HasColumnName("MINIMO");

            // Relationships
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.SUPERVISORVENTAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SUPERVISORVENTAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.ZONA)
                .WithMany(t => t.SUPERVISORVENTAs)
                .HasForeignKey(d => d.CODZONA);

        }
    }
}
