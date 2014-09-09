using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VENDEDORMap : EntityTypeConfiguration<VENDEDOR>
    {
        public VENDEDORMap()
        {
            // Primary Key
            this.HasKey(t => t.CODVENDEDOR);

            // Properties
            this.Property(t => t.CODVENDEDOR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMVENDEDOR)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESVENDEDOR)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.DIRECCION)
                .HasMaxLength(60);

            this.Property(t => t.TELEFONO)
                .HasMaxLength(35);

            this.Property(t => t.CELULAR)
                .HasMaxLength(35);

            this.Property(t => t.CEDULA)
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VENDEDOR");
            this.Property(t => t.CODVENDEDOR).HasColumnName("CODVENDEDOR");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMVENDEDOR).HasColumnName("NUMVENDEDOR");
            this.Property(t => t.USUARIO).HasColumnName("USUARIO");
            this.Property(t => t.DESVENDEDOR).HasColumnName("DESVENDEDOR");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
            this.Property(t => t.CELULAR).HasColumnName("CELULAR");
            this.Property(t => t.CODTIPOVENDEDOR).HasColumnName("CODTIPOVENDEDOR");
            this.Property(t => t.CODSUCURSALPERTENECE).HasColumnName("CODSUCURSALPERTENECE");
            this.Property(t => t.CODSUCURSALPRODUCTO).HasColumnName("CODSUCURSALPRODUCTO");
            this.Property(t => t.CODSUPERVISOR).HasColumnName("CODSUPERVISOR");
            this.Property(t => t.CEDULA).HasColumnName("CEDULA");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.MAXIMO).HasColumnName("MAXIMO");
            this.Property(t => t.MINIMO).HasColumnName("MINIMO");
        }
    }
}
