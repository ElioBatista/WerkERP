using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PEDIDOAJUSTEMap : EntityTypeConfiguration<PEDIDOAJUSTE>
    {
        public PEDIDOAJUSTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPEDIDOAJUSTE);

            // Properties
            this.Property(t => t.CODPEDIDOAJUSTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMPEDIDOAJUSTE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("PEDIDOAJUSTE");
            this.Property(t => t.CODPEDIDOAJUSTE).HasColumnName("CODPEDIDOAJUSTE");
            this.Property(t => t.NUMPEDIDOAJUSTE).HasColumnName("NUMPEDIDOAJUSTE");
            this.Property(t => t.IMPORTEPEDIDO).HasColumnName("IMPORTEPEDIDO");
            this.Property(t => t.CODDESPACHOINTERNO).HasColumnName("CODDESPACHOINTERNO");
            this.Property(t => t.CODPROPOSITO).HasColumnName("CODPROPOSITO");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.FECHADEPEDIDO).HasColumnName("FECHADEPEDIDO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.DESPACHOINTERNO)
                .WithMany(t => t.PEDIDOAJUSTEs)
                .HasForeignKey(d => d.CODDESPACHOINTERNO);
            this.HasOptional(t => t.PROPOSITOCHEQUE)
                .WithMany(t => t.PEDIDOAJUSTEs)
                .HasForeignKey(d => d.CODPROPOSITO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PEDIDOAJUSTEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
