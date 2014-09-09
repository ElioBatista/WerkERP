using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class EJECUTIVOCTAMap : EntityTypeConfiguration<EJECUTIVOCTA>
    {
        public EJECUTIVOCTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODEJECUTIVOCTA);

            // Properties
            this.Property(t => t.CODEJECUTIVOCTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEJECUTIVO)
                .HasMaxLength(5);

            this.Property(t => t.DESEJECUTIVO)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("EJECUTIVOCTA");
            this.Property(t => t.CODEJECUTIVOCTA).HasColumnName("CODEJECUTIVOCTA");
            this.Property(t => t.NUMEJECUTIVO).HasColumnName("NUMEJECUTIVO");
            this.Property(t => t.DESEJECUTIVO).HasColumnName("DESEJECUTIVO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.EJECUTIVOCTAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
