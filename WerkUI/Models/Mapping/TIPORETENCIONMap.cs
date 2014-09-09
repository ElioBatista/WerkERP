using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPORETENCIONMap : EntityTypeConfiguration<TIPORETENCION>
    {
        public TIPORETENCIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPORETEN);

            // Properties
            this.Property(t => t.CODTIPORETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPORETEN)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPORETEN)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPORETENCION");
            this.Property(t => t.CODTIPORETEN).HasColumnName("CODTIPORETEN");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPORETEN).HasColumnName("NUMTIPORETEN");
            this.Property(t => t.DESTIPORETEN).HasColumnName("DESTIPORETEN");
            this.Property(t => t.PORCENTAJE).HasColumnName("PORCENTAJE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.TIPORETENCIONs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPORETENCIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
