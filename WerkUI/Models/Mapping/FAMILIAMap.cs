using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FAMILIAMap : EntityTypeConfiguration<FAMILIA>
    {
        public FAMILIAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODFAMILIA);

            // Properties
            this.Property(t => t.CODFAMILIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMFAMILIA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESFAMILIA)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("FAMILIA");
            this.Property(t => t.CODFAMILIA).HasColumnName("CODFAMILIA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMFAMILIA).HasColumnName("NUMFAMILIA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.DESFAMILIA).HasColumnName("DESFAMILIA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.FAMILIAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
