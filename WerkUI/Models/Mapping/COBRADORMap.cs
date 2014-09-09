using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COBRADORMap : EntityTypeConfiguration<COBRADOR>
    {
        public COBRADORMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCOBRADOR);

            // Properties
            this.Property(t => t.CODCOBRADOR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOBRADOR)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCOBRADOR)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("COBRADOR");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCOBRADOR).HasColumnName("NUMCOBRADOR");
            this.Property(t => t.USUARIO).HasColumnName("USUARIO");
            this.Property(t => t.DESCOBRADOR).HasColumnName("DESCOBRADOR");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO1)
                .WithMany(t => t.COBRADORs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
