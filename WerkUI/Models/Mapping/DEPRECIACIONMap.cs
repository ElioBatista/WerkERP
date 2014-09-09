using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEPRECIACIONMap : EntityTypeConfiguration<DEPRECIACION>
    {
        public DEPRECIACIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ANHODEPRE, t.MESDEPRE });

            // Properties
            this.Property(t => t.ANHODEPRE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MESDEPRE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DEPRECIACION");
            this.Property(t => t.ANHODEPRE).HasColumnName("ANHODEPRE");
            this.Property(t => t.MESDEPRE).HasColumnName("MESDEPRE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.TASADEPRE).HasColumnName("TASADEPRE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DEPRECIACIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
