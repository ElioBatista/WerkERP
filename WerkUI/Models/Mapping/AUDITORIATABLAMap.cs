using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class AUDITORIATABLAMap : EntityTypeConfiguration<AUDITORIATABLA>
    {
        public AUDITORIATABLAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO);

            // Properties
            this.Property(t => t.CODIGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TABLA)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NUMCODIGO)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.DESCRIPCION)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.USUARIO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NIVEL)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AUDITORIATABLAS");
            this.Property(t => t.CODIGO).HasColumnName("CODIGO");
            this.Property(t => t.EMPRESA).HasColumnName("EMPRESA");
            this.Property(t => t.TABLA).HasColumnName("TABLA");
            this.Property(t => t.NUMCODIGO).HasColumnName("NUMCODIGO");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.USUARIO).HasColumnName("USUARIO");
            this.Property(t => t.NIVEL).HasColumnName("NIVEL");
            this.Property(t => t.INSERTAR).HasColumnName("INSERTAR");
            this.Property(t => t.MODIFICAR).HasColumnName("MODIFICAR");
            this.Property(t => t.ELIMINAR).HasColumnName("ELIMINAR");

            // Relationships
            this.HasRequired(t => t.EMPRESA1)
                .WithMany(t => t.AUDITORIATABLAS)
                .HasForeignKey(d => d.EMPRESA);

        }
    }
}
