using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGOTIPORETENMap : EntityTypeConfiguration<PAGOTIPORETEN>
    {
        public PAGOTIPORETENMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODRETEN, t.CODTIPORETEN });

            // Properties
            this.Property(t => t.CODRETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTIPORETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PAGOTIPORETEN");
            this.Property(t => t.CODRETEN).HasColumnName("CODRETEN");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODTIPORETEN).HasColumnName("CODTIPORETEN");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.PORCENTAJE).HasColumnName("PORCENTAJE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.PAGORETENCION)
                .WithMany(t => t.PAGOTIPORETENs)
                .HasForeignKey(d => d.CODRETEN);
            this.HasRequired(t => t.TIPORETENCION)
                .WithMany(t => t.PAGOTIPORETENs)
                .HasForeignKey(d => d.CODTIPORETEN);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PAGOTIPORETENs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
