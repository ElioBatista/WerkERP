using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OTTECNICOMap : EntityTypeConfiguration<OTTECNICO>
    {
        public OTTECNICOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTECNICO);

            // Properties
            this.Property(t => t.CODTECNICO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTECNICO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTECNICO)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OTTECNICO");
            this.Property(t => t.CODTECNICO).HasColumnName("CODTECNICO");
            this.Property(t => t.NUMTECNICO).HasColumnName("NUMTECNICO");
            this.Property(t => t.DESTECNICO).HasColumnName("DESTECNICO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.RECEPCION).HasColumnName("RECEPCION");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.OTTECNICOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
