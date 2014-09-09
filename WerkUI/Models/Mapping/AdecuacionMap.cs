using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class AdecuacionMap : EntityTypeConfiguration<Adecuacion>
    {
        public AdecuacionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CodAdecuacion, t.ColAdecuacion });

            // Properties
            this.Property(t => t.CodAdecuacion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DesAdecuacion)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.DesColumna)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Adecuacion");
            this.Property(t => t.CodAdecuacion).HasColumnName("CodAdecuacion");
            this.Property(t => t.DesAdecuacion).HasColumnName("DesAdecuacion");
            this.Property(t => t.ColAdecuacion).HasColumnName("ColAdecuacion");
            this.Property(t => t.DesColumna).HasColumnName("DesColumna");
            this.Property(t => t.CodUsuario).HasColumnName("CodUsuario");
            this.Property(t => t.CodEmpresa).HasColumnName("CodEmpresa");

            // Relationships
            this.HasRequired(t => t.USUARIO)
                .WithMany(t => t.Adecuacions)
                .HasForeignKey(d => new { d.CodUsuario, d.CodEmpresa });

        }
    }
}
