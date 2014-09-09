using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class GASTOCOMPRAMap : EntityTypeConfiguration<GASTOCOMPRA>
    {
        public GASTOCOMPRAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODGASTO);

            // Properties
            this.Property(t => t.CODGASTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMGASTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESGASTO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("GASTOCOMPRA");
            this.Property(t => t.CODGASTO).HasColumnName("CODGASTO");
            this.Property(t => t.NUMGASTO).HasColumnName("NUMGASTO");
            this.Property(t => t.DESGASTO).HasColumnName("DESGASTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.GASTOCOMPRAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
