using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGONCCONCEPTOMap : EntityTypeConfiguration<PAGONCCONCEPTO>
    {
        public PAGONCCONCEPTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCONCEPTO);

            // Properties
            this.Property(t => t.CODCONCEPTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCONCEPTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCONCEPTO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("PAGONCCONCEPTO");
            this.Property(t => t.CODCONCEPTO).HasColumnName("CODCONCEPTO");
            this.Property(t => t.NUMCONCEPTO).HasColumnName("NUMCONCEPTO");
            this.Property(t => t.DESCONCEPTO).HasColumnName("DESCONCEPTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PAGONCCONCEPTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
