using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class USUARIO1Map : EntityTypeConfiguration<USUARIO1>
    {
        public USUARIO1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.CODUSUARIO, t.CODEMPRESA });

            // Properties
            this.Property(t => t.CODUSUARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESUSUARIO)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.PASSUSUARIO)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("USUARIO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.DESUSUARIO).HasColumnName("DESUSUARIO");
            this.Property(t => t.PASSUSUARIO).HasColumnName("PASSUSUARIO");
            this.Property(t => t.NIVELCUENTA).HasColumnName("NIVELCUENTA");
            this.Property(t => t.USUGRA).HasColumnName("USUGRA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
        }
    }
}
