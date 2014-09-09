using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CHEQUERAMap : EntityTypeConfiguration<CHEQUERA>
    {
        public CHEQUERAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODTIPOCHEQUE, t.CODEMPRESA, t.NUMCUENTA, t.CODBANCO });

            // Properties
            this.Property(t => t.CODTIPOCHEQUE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCUENTA)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.NOMREPORT)
                .HasMaxLength(30);

            this.Property(t => t.CODBANCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CHEQUERA");
            this.Property(t => t.CODTIPOCHEQUE).HasColumnName("CODTIPOCHEQUE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCUENTA).HasColumnName("NUMCUENTA");
            this.Property(t => t.RANGO1).HasColumnName("RANGO1");
            this.Property(t => t.RANGO2).HasColumnName("RANGO2");
            this.Property(t => t.ULTIMONUMERO).HasColumnName("ULTIMONUMERO");
            this.Property(t => t.NOMREPORT).HasColumnName("NOMREPORT");
            this.Property(t => t.CODBANCO).HasColumnName("CODBANCO");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");

            // Relationships
            this.HasRequired(t => t.CUENTABANCARIA)
                .WithMany(t => t.CHEQUERAs)
                .HasForeignKey(d => new { d.NUMCUENTA, d.CODBANCO });
            this.HasRequired(t => t.TIPOCHEQUE)
                .WithMany(t => t.CHEQUERAs)
                .HasForeignKey(d => d.CODTIPOCHEQUE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CHEQUERAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.CHEQUERAs)
                .HasForeignKey(d => d.CODCOMPROBANTE);

        }
    }
}
