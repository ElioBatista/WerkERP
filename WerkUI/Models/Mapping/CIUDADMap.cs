using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CIUDADMap : EntityTypeConfiguration<CIUDAD>
    {
        public CIUDADMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCIUDAD);

            // Properties
            this.Property(t => t.CODCIUDAD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCIUDAD)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCIUDAD)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("CIUDAD");
            this.Property(t => t.CODCIUDAD).HasColumnName("CODCIUDAD");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODDEPARTAMENTO).HasColumnName("CODDEPARTAMENTO");
            this.Property(t => t.NUMCIUDAD).HasColumnName("NUMCIUDAD");
            this.Property(t => t.DESCIUDAD).HasColumnName("DESCIUDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.DEPARTAMENTO)
                .WithMany(t => t.CIUDADs)
                .HasForeignKey(d => d.CODDEPARTAMENTO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CIUDADs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
