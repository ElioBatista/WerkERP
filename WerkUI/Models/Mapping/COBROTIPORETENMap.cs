using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COBROTIPORETENMap : EntityTypeConfiguration<COBROTIPORETEN>
    {
        public COBROTIPORETENMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCOMPRARETEN, t.CODTIPORETEN });

            // Properties
            this.Property(t => t.CODCOMPRARETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTIPORETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COBROTIPORETEN");
            this.Property(t => t.CODCOMPRARETEN).HasColumnName("CODCOMPRARETEN");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODTIPORETEN).HasColumnName("CODTIPORETEN");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.PORCENTAJE).HasColumnName("PORCENTAJE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.COBRORETENCION)
                .WithMany(t => t.COBROTIPORETENs)
                .HasForeignKey(d => d.CODCOMPRARETEN);
            this.HasRequired(t => t.TIPORETENCION)
                .WithMany(t => t.COBROTIPORETENs)
                .HasForeignKey(d => d.CODTIPORETEN);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.COBROTIPORETENs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
