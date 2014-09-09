using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class AUTORIZACIONMap : EntityTypeConfiguration<AUTORIZACION>
    {
        public AUTORIZACIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IP, t.CODEMPRESA, t.CODSUCURSAL });

            // Properties
            this.Property(t => t.IP)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUCURSAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AUTORIZACION");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.USUFAC).HasColumnName("USUFAC");
            this.Property(t => t.USUAUT).HasColumnName("USUAUT");
            this.Property(t => t.FECAUT).HasColumnName("FECAUT");
            this.Property(t => t.TOTALFACTURA).HasColumnName("TOTALFACTURA");
            this.Property(t => t.SOLICITAVENCIMIENTO).HasColumnName("SOLICITAVENCIMIENTO");
            this.Property(t => t.SOLICITALIMITE).HasColumnName("SOLICITALIMITE");
            this.Property(t => t.AUTORIZAVENCIMIENTO).HasColumnName("AUTORIZAVENCIMIENTO");
            this.Property(t => t.AUTORIZALIMITE).HasColumnName("AUTORIZALIMITE");
        }
    }
}
