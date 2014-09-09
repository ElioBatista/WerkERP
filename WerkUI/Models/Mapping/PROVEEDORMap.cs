using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PROVEEDORMap : EntityTypeConfiguration<PROVEEDOR>
    {
        public PROVEEDORMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPROVEEDOR);

            // Properties
            this.Property(t => t.CODPROVEEDOR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMPROVEEDOR)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.NOMBRE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.APELLIDO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.NUMCEDULA)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.RUC)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.DIRECCION)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.TELEFONO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.CELULAR)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.FAX)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.EMAIL)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.WEB)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.observacion)
                .IsFixedLength()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("PROVEEDOR");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODZONA).HasColumnName("CODZONA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.NUMPROVEEDOR).HasColumnName("NUMPROVEEDOR");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.NUMCEDULA).HasColumnName("NUMCEDULA");
            this.Property(t => t.RUC).HasColumnName("RUC");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
            this.Property(t => t.CELULAR).HasColumnName("CELULAR");
            this.Property(t => t.FAX).HasColumnName("FAX");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.WEB).HasColumnName("WEB");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.observacion).HasColumnName("observacion");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.PROVEEDORs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PROVEEDORs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.ZONA)
                .WithMany(t => t.PROVEEDORs)
                .HasForeignKey(d => d.CODZONA);

        }
    }
}
