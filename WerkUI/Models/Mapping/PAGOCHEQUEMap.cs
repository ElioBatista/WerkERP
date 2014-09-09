using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGOCHEQUEMap : EntityTypeConfiguration<PAGOCHEQUE>
    {
        public PAGOCHEQUEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPAGANZAS, t.NUMEROCHEQUE, t.NUMCUENTA, t.CODEMPRESA });

            // Properties
            this.Property(t => t.CODPAGANZAS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEROCHEQUE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCUENTA)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PAGOCHEQUE");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
            this.Property(t => t.NUMEROCHEQUE).HasColumnName("NUMEROCHEQUE");
            this.Property(t => t.NUMCUENTA).HasColumnName("NUMCUENTA");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
        }
    }
}
