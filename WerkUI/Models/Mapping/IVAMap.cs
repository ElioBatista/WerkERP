using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class IVAMap : EntityTypeConfiguration<IVA>
    {
        public IVAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIVA);

            // Properties
            this.Property(t => t.CODIVA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMIVA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESIVA)
                .IsFixedLength()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("IVA");
            this.Property(t => t.CODIVA).HasColumnName("CODIVA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMIVA).HasColumnName("NUMIVA");
            this.Property(t => t.DESIVA).HasColumnName("DESIVA");
            this.Property(t => t.PORCENTAJEIVA).HasColumnName("PORCENTAJEIVA");
            this.Property(t => t.COHEFICIENTE).HasColumnName("COHEFICIENTE");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CUENTADEBE).HasColumnName("CUENTADEBE");
            this.Property(t => t.CUENTAHABER).HasColumnName("CUENTAHABER");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.IVAs)
                .HasForeignKey(d => d.CUENTAHABER);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.IVAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.PLANCUENTA1)
                .WithMany(t => t.IVAs1)
                .HasForeignKey(d => d.CUENTADEBE);

        }
    }
}
