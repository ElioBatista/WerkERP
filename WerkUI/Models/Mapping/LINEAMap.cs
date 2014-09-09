using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class LINEAMap : EntityTypeConfiguration<LINEA>
    {
        public LINEAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODLINEA);

            // Properties
            this.Property(t => t.CODLINEA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMLINEA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESLINEA)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("LINEA");
            this.Property(t => t.CODLINEA).HasColumnName("CODLINEA");
            this.Property(t => t.CODFAMILIA).HasColumnName("CODFAMILIA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMLINEA).HasColumnName("NUMLINEA");
            this.Property(t => t.DESLINEA).HasColumnName("DESLINEA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.FAMILIA)
                .WithMany(t => t.LINEAs)
                .HasForeignKey(d => d.CODFAMILIA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.LINEAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
