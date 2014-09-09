using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MOVISUELDODETALLEMap : EntityTypeConfiguration<MOVISUELDODETALLE>
    {
        public MOVISUELDODETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODMOVIDETALLE, t.CODMOVI });

            // Properties
            this.Property(t => t.CODMOVIDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMOVI)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("MOVISUELDODETALLE");
            this.Property(t => t.CODMOVIDETALLE).HasColumnName("CODMOVIDETALLE");
            this.Property(t => t.CODMOVI).HasColumnName("CODMOVI");
            this.Property(t => t.CODEMPLEADO).HasColumnName("CODEMPLEADO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.DIAS).HasColumnName("DIAS");
            this.Property(t => t.HORAS).HasColumnName("HORAS");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.FECHADESDE).HasColumnName("FECHADESDE");
            this.Property(t => t.FECHAHASTA).HasColumnName("FECHAHASTA");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.CODIVA).HasColumnName("CODIVA");

            // Relationships
            this.HasOptional(t => t.EMPLEADO)
                .WithMany(t => t.MOVISUELDODETALLEs)
                .HasForeignKey(d => d.CODEMPLEADO);
            this.HasOptional(t => t.IVA)
                .WithMany(t => t.MOVISUELDODETALLEs)
                .HasForeignKey(d => d.CODIVA);
            this.HasRequired(t => t.MOVISUELDO)
                .WithMany(t => t.MOVISUELDODETALLEs)
                .HasForeignKey(d => d.CODMOVI);

        }
    }
}
