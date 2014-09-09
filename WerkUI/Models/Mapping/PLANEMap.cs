using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PLANEMap : EntityTypeConfiguration<PLANE>
    {
        public PLANEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPLANCUENTAMOD);

            // Properties
            this.Property(t => t.CODPLANCUENTAMOD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESPLANCUENTAMOD)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.DESSUBCUENTAMOD)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("PLANES");
            this.Property(t => t.CODPLANCUENTAMOD).HasColumnName("CODPLANCUENTAMOD");
            this.Property(t => t.CODMODELO).HasColumnName("CODMODELO");
            this.Property(t => t.NUMPLANCUENTAMOD).HasColumnName("NUMPLANCUENTAMOD");
            this.Property(t => t.DESPLANCUENTAMOD).HasColumnName("DESPLANCUENTAMOD");
            this.Property(t => t.TIPOCUENTAMOD).HasColumnName("TIPOCUENTAMOD");
            this.Property(t => t.ASENTABLEMOD).HasColumnName("ASENTABLEMOD");
            this.Property(t => t.NIVELCUENTAMOD).HasColumnName("NIVELCUENTAMOD");
            this.Property(t => t.SUBCUENTAMOD).HasColumnName("SUBCUENTAMOD");
            this.Property(t => t.USUGRA).HasColumnName("USUGRA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.DESSUBCUENTAMOD).HasColumnName("DESSUBCUENTAMOD");

            // Relationships
            this.HasOptional(t => t.MODELO)
                .WithMany(t => t.PLANES)
                .HasForeignKey(d => d.CODMODELO);

        }
    }
}
