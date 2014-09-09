using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENCOMPRAPROVEEDORDETALLEMap : EntityTypeConfiguration<ORDENCOMPRAPROVEEDORDETALLE>
    {
        public ORDENCOMPRAPROVEEDORDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODORDENCOMPRA, t.CODLINEA });

            // Properties
            this.Property(t => t.CODORDENCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODLINEA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRIPCION)
                .HasMaxLength(50);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ORDENCOMPRAPROVEEDORDETALLE");
            this.Property(t => t.CODORDENCOMPRA).HasColumnName("CODORDENCOMPRA");
            this.Property(t => t.CODLINEA).HasColumnName("CODLINEA");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.COSTO).HasColumnName("COSTO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.CODIVA).HasColumnName("CODIVA");
            this.Property(t => t.PORCENTAJEIVA).HasColumnName("PORCENTAJEIVA");

            // Relationships
            this.HasOptional(t => t.IVA)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORDETALLEs)
                .HasForeignKey(d => d.CODIVA);
            this.HasRequired(t => t.ORDENCOMPRAPROVEEDOR)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORDETALLEs)
                .HasForeignKey(d => d.CODORDENCOMPRA);

        }
    }
}
