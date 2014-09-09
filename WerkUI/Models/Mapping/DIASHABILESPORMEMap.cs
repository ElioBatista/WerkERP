using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DIASHABILESPORMEMap : EntityTypeConfiguration<DIASHABILESPORME>
    {
        public DIASHABILESPORMEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MES, t.ANUAL });

            // Properties
            this.Property(t => t.MES)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ANUAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DIASHABILESPORMES");
            this.Property(t => t.CODDIAS).HasColumnName("CODDIAS");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.MES).HasColumnName("MES");
            this.Property(t => t.ANUAL).HasColumnName("ANUAL");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DIASHABILESPORMES)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
