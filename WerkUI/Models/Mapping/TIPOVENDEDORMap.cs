using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOVENDEDORMap : EntityTypeConfiguration<TIPOVENDEDOR>
    {
        public TIPOVENDEDORMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOVENDEDOR);

            // Properties
            this.Property(t => t.CODTIPOVENDEDOR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOVENDEDOR)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOVENDEDOR)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TIPOVENDEDOR");
            this.Property(t => t.CODTIPOVENDEDOR).HasColumnName("CODTIPOVENDEDOR");
            this.Property(t => t.NUMTIPOVENDEDOR).HasColumnName("NUMTIPOVENDEDOR");
            this.Property(t => t.DESTIPOVENDEDOR).HasColumnName("DESTIPOVENDEDOR");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOVENDEDORs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
