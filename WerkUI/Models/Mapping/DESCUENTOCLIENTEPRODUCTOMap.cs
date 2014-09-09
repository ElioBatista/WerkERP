using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESCUENTOCLIENTEPRODUCTOMap : EntityTypeConfiguration<DESCUENTOCLIENTEPRODUCTO>
    {
        public DESCUENTOCLIENTEPRODUCTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCLIENTE, t.CODPRODUCTO, t.CODDESCUENTO });

            // Properties
            this.Property(t => t.CODCLIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODDESCUENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DESCUENTOCLIENTEPRODUCTO");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODDESCUENTO).HasColumnName("CODDESCUENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasRequired(t => t.CLIENTE)
                .WithMany(t => t.DESCUENTOCLIENTEPRODUCTOes)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasRequired(t => t.DESCUENTOPRODUCTO)
                .WithMany(t => t.DESCUENTOCLIENTEPRODUCTOes)
                .HasForeignKey(d => d.CODDESCUENTO);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.DESCUENTOCLIENTEPRODUCTOes)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DESCUENTOCLIENTEPRODUCTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
