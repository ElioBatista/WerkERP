using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEPARTAMENTOMap : EntityTypeConfiguration<DEPARTAMENTO>
    {
        public DEPARTAMENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDEPARTAMENTO);

            // Properties
            this.Property(t => t.CODDEPARTAMENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDEPARTAMENTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESDEPARTAMENTO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("DEPARTAMENTO");
            this.Property(t => t.CODDEPARTAMENTO).HasColumnName("CODDEPARTAMENTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPAIS).HasColumnName("CODPAIS");
            this.Property(t => t.NUMDEPARTAMENTO).HasColumnName("NUMDEPARTAMENTO");
            this.Property(t => t.DESDEPARTAMENTO).HasColumnName("DESDEPARTAMENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PAI)
                .WithMany(t => t.DEPARTAMENTOes)
                .HasForeignKey(d => d.CODPAIS);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DEPARTAMENTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
