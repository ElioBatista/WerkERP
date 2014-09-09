using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class BANCOMap : EntityTypeConfiguration<BANCO>
    {
        public BANCOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODBANCO);

            // Properties
            this.Property(t => t.CODBANCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMBANCO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESBANCO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.DIRECCION)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.TELEFONO)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.WEB)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.EMAIL)
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BANCO");
            this.Property(t => t.CODBANCO).HasColumnName("CODBANCO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMBANCO).HasColumnName("NUMBANCO");
            this.Property(t => t.DESBANCO).HasColumnName("DESBANCO");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
            this.Property(t => t.WEB).HasColumnName("WEB");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.BANCOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
