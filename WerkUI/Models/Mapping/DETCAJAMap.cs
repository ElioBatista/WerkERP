using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DETCAJAMap : EntityTypeConfiguration<DETCAJA>
    {
        public DETCAJAMap()
        {
            // Primary Key
            this.HasKey(t => t.NUMCIERRE);

            // Properties
            this.Property(t => t.NUMCIERRE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DETCAJA");
            this.Property(t => t.NUMCIERRE).HasColumnName("NUMCIERRE");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.NUMCAJA).HasColumnName("NUMCAJA");
            this.Property(t => t.FECAPERTURA).HasColumnName("FECAPERTURA");
            this.Property(t => t.FECCIERRE).HasColumnName("FECCIERRE");
            this.Property(t => t.SALDOINICIAL).HasColumnName("SALDOINICIAL");
            this.Property(t => t.SALDOCIERRE).HasColumnName("SALDOCIERRE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.COBRADOR)
                .WithMany(t => t.DETCAJAs)
                .HasForeignKey(d => d.CODCOBRADOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.DETCAJAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DETCAJAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
