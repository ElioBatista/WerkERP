using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class NOTACONCEPTOMap : EntityTypeConfiguration<NOTACONCEPTO>
    {
        public NOTACONCEPTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODNOTACONCEPTO);

            // Properties
            this.Property(t => t.CODNOTACONCEPTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMNOTACONCEPTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESNOTACONCEPTO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("NOTACONCEPTO");
            this.Property(t => t.CODNOTACONCEPTO).HasColumnName("CODNOTACONCEPTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMNOTACONCEPTO).HasColumnName("NUMNOTACONCEPTO");
            this.Property(t => t.DESNOTACONCEPTO).HasColumnName("DESNOTACONCEPTO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.DEBITO).HasColumnName("DEBITO");
            this.Property(t => t.CREDITO).HasColumnName("CREDITO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.NOTACONCEPTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
