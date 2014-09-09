using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ConceptosMarcadoMap : EntityTypeConfiguration<ConceptosMarcado>
    {
        public ConceptosMarcadoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Cod__Liquidación, t.Cod__Concepto });

            // Properties
            this.Property(t => t.Cod__Liquidación)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cod__Concepto)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Concepto)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Comentario)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ConceptosMarcados", "Facturacion");
            this.Property(t => t.Cod__Liquidación).HasColumnName("Cod. Liquidación");
            this.Property(t => t.Cod__Concepto).HasColumnName("Cod. Concepto");
            this.Property(t => t.Grupo).HasColumnName("Grupo");
            this.Property(t => t.Secuencia).HasColumnName("Secuencia");
            this.Property(t => t.Concepto).HasColumnName("Concepto");
            this.Property(t => t.Importe).HasColumnName("Importe");
            this.Property(t => t.Comentario).HasColumnName("Comentario");
        }
    }
}
