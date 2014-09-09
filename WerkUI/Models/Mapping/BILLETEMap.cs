using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class BILLETEMap : EntityTypeConfiguration<BILLETE>
    {
        public BILLETEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODBILLETE);

            // Properties
            this.Property(t => t.CODBILLETE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMBILLETE)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DESCRIPCION)
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BILLETES");
            this.Property(t => t.CODBILLETE).HasColumnName("CODBILLETE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMBILLETE).HasColumnName("NUMBILLETE");
            this.Property(t => t.MONTO).HasColumnName("MONTO");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.BILLETES)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.BILLETES)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
