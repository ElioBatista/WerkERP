using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CONVENTASDETALLEMap : EntityTypeConfiguration<CONVENTASDETALLE>
    {
        public CONVENTASDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCONVENTAS, t.CONLINEA });

            // Properties
            this.Property(t => t.CODCONVENTAS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CONLINEA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.COMENTARIO)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("CONVENTASDETALLE");
            this.Property(t => t.CODCONVENTAS).HasColumnName("CODCONVENTAS");
            this.Property(t => t.CONLINEA).HasColumnName("CONLINEA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.IMPORTEEXENTO).HasColumnName("IMPORTEEXENTO");
            this.Property(t => t.IMPORTENETOGRAVADO).HasColumnName("IMPORTENETOGRAVADO");
            this.Property(t => t.TIPOMOVIMIENTO).HasColumnName("TIPOMOVIMIENTO");
            this.Property(t => t.COMENTARIO).HasColumnName("COMENTARIO");

            // Relationships
            this.HasRequired(t => t.CONVENTA)
                .WithMany(t => t.CONVENTASDETALLEs)
                .HasForeignKey(d => d.CODCONVENTAS);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.CONVENTASDETALLEs)
                .HasForeignKey(d => d.CODPLANCUENTA);

        }
    }
}
