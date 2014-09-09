using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CONCOMPRASDETALLEMap : EntityTypeConfiguration<CONCOMPRASDETALLE>
    {
        public CONCOMPRASDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCONCOMPRA, t.CONLINEA });

            // Properties
            this.Property(t => t.CODCONCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CONLINEA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.COMENTARIO)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("CONCOMPRASDETALLE");
            this.Property(t => t.CODCONCOMPRA).HasColumnName("CODCONCOMPRA");
            this.Property(t => t.CONLINEA).HasColumnName("CONLINEA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.IMPORTEEXENTO).HasColumnName("IMPORTEEXENTO");
            this.Property(t => t.IMPORTENETOGRAVADO).HasColumnName("IMPORTENETOGRAVADO");
            this.Property(t => t.TIPOMOVIMIENTO).HasColumnName("TIPOMOVIMIENTO");
            this.Property(t => t.COMENTARIO).HasColumnName("COMENTARIO");

            // Relationships
            this.HasRequired(t => t.CONCOMPRA)
                .WithMany(t => t.CONCOMPRASDETALLEs)
                .HasForeignKey(d => d.CODCONCOMPRA);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.CONCOMPRASDETALLEs)
                .HasForeignKey(d => d.CODPLANCUENTA);

        }
    }
}
