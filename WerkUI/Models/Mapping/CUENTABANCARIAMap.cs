using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CUENTABANCARIAMap : EntityTypeConfiguration<CUENTABANCARIA>
    {
        public CUENTABANCARIAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NUMCUENTA, t.CODBANCO });

            // Properties
            this.Property(t => t.NUMCUENTA)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.CODBANCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRIPCION)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CUENTABANCARIA");
            this.Property(t => t.NUMCUENTA).HasColumnName("NUMCUENTA");
            this.Property(t => t.CODTIPOCUENTA).HasColumnName("CODTIPOCUENTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODBANCO).HasColumnName("CODBANCO");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.FECHAAPERTURA).HasColumnName("FECHAAPERTURA");
            this.Property(t => t.SALDOMINIMO).HasColumnName("SALDOMINIMO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.BANCO)
                .WithMany(t => t.CUENTABANCARIAs)
                .HasForeignKey(d => d.CODBANCO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CUENTABANCARIAs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.CUENTABANCARIAs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.TIPOCUENTA)
                .WithMany(t => t.CUENTABANCARIAs)
                .HasForeignKey(d => d.CODTIPOCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CUENTABANCARIAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
