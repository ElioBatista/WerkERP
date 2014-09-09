using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COTIZACIONMap : EntityTypeConfiguration<COTIZACION>
    {
        public COTIZACIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FECHAMOVIMIENTO, t.CODMONEDA, t.CODEMPRESA });

            // Properties
            this.Property(t => t.CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COTIZACION");
            this.Property(t => t.FECHAMOVIMIENTO).HasColumnName("FECHAMOVIMIENTO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FACTORVENTA).HasColumnName("FACTORVENTA");
            this.Property(t => t.FACTORCOBRO).HasColumnName("FACTORCOBRO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.MONEDA)
                .WithMany(t => t.COTIZACIONs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.COTIZACIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
