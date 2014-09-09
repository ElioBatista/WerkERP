using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ESCALAVACACIONEMap : EntityTypeConfiguration<ESCALAVACACIONE>
    {
        public ESCALAVACACIONEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODVACACION);

            // Properties
            this.Property(t => t.CODVACACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ESCALAVACACIONES");
            this.Property(t => t.CODVACACION).HasColumnName("CODVACACION");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.DESDE).HasColumnName("DESDE");
            this.Property(t => t.HASTA).HasColumnName("HASTA");
            this.Property(t => t.CANTIDADDIAS).HasColumnName("CANTIDADDIAS");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ESCALAVACACIONES)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
