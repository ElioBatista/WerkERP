using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESGLOSEBILLETEDETMap : EntityTypeConfiguration<DESGLOSEBILLETEDET>
    {
        public DESGLOSEBILLETEDETMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDESGLOSE, t.CODBILLETE });

            // Properties
            this.Property(t => t.CODDESGLOSE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODBILLETE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DESGLOSEBILLETEDET");
            this.Property(t => t.CODDESGLOSE).HasColumnName("CODDESGLOSE");
            this.Property(t => t.CODBILLETE).HasColumnName("CODBILLETE");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.BILLETE)
                .WithMany(t => t.DESGLOSEBILLETEDETs)
                .HasForeignKey(d => d.CODBILLETE);
            this.HasRequired(t => t.DESGLOSEBILLETE)
                .WithMany(t => t.DESGLOSEBILLETEDETs)
                .HasForeignKey(d => d.CODDESGLOSE);

        }
    }
}
