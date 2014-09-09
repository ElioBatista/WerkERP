using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class UNIDADMEDIDAMap : EntityTypeConfiguration<UNIDADMEDIDA>
    {
        public UNIDADMEDIDAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODMEDIDA);

            // Properties
            this.Property(t => t.CODMEDIDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMMEDIDA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESMEDIDA)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("UNIDADMEDIDA");
            this.Property(t => t.CODMEDIDA).HasColumnName("CODMEDIDA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMMEDIDA).HasColumnName("NUMMEDIDA");
            this.Property(t => t.DESMEDIDA).HasColumnName("DESMEDIDA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.UNIDADMEDIDAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
