using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ADUANAMap : EntityTypeConfiguration<ADUANA>
    {
        public ADUANAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODADUANA);

            // Properties
            this.Property(t => t.CODADUANA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMADUANA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESADUANA)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("ADUANA");
            this.Property(t => t.CODADUANA).HasColumnName("CODADUANA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMADUANA).HasColumnName("NUMADUANA");
            this.Property(t => t.DESADUANA).HasColumnName("DESADUANA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ADUANAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
