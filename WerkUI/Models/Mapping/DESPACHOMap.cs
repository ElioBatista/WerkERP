using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESPACHOMap : EntityTypeConfiguration<DESPACHO>
    {
        public DESPACHOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDESPACHO);

            // Properties
            this.Property(t => t.CODDESPACHO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDESPACHO)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.NUMEROEXPEDIENTE)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.CONSIGNADOA)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.NUMEROORDENPEDIDO)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.REGISTRO)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.NOTADEPOSITOFISCAL)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.COMPANIASEGURO)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.AGENTEDELSEGURO)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("DESPACHO");
            this.Property(t => t.CODDESPACHO).HasColumnName("CODDESPACHO");
            this.Property(t => t.CODDESPACHOINTERNO).HasColumnName("CODDESPACHOINTERNO");
            this.Property(t => t.NUMDESPACHO).HasColumnName("NUMDESPACHO");
            this.Property(t => t.NUMEROEXPEDIENTE).HasColumnName("NUMEROEXPEDIENTE");
            this.Property(t => t.FECHADEINGRESO).HasColumnName("FECHADEINGRESO");
            this.Property(t => t.CONSIGNADOA).HasColumnName("CONSIGNADOA");
            this.Property(t => t.NUMEROPROFORMA).HasColumnName("NUMEROPROFORMA");
            this.Property(t => t.CODCLASE).HasColumnName("CODCLASE");
            this.Property(t => t.CODPROCEDENCIA).HasColumnName("CODPROCEDENCIA");
            this.Property(t => t.NUMEROORDENPEDIDO).HasColumnName("NUMEROORDENPEDIDO");
            this.Property(t => t.REGISTRO).HasColumnName("REGISTRO");
            this.Property(t => t.FECHAREGISTRO).HasColumnName("FECHAREGISTRO");
            this.Property(t => t.NOTADEPOSITOFISCAL).HasColumnName("NOTADEPOSITOFISCAL");
            this.Property(t => t.CODADUANA).HasColumnName("CODADUANA");
            this.Property(t => t.COMPANIASEGURO).HasColumnName("COMPANIASEGURO");
            this.Property(t => t.CODORIGENMER).HasColumnName("CODORIGENMER");
            this.Property(t => t.FECHADESPACHO).HasColumnName("FECHADESPACHO");
            this.Property(t => t.CODDESTINO).HasColumnName("CODDESTINO");
            this.Property(t => t.AGENTEDELSEGURO).HasColumnName("AGENTEDELSEGURO");
            this.Property(t => t.FECHAPAGODESPACHO).HasColumnName("FECHAPAGODESPACHO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODTRANSPORTE).HasColumnName("CODTRANSPORTE");
            this.Property(t => t.CODDEPOSITO).HasColumnName("CODDEPOSITO");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.CODORIGENMER1).HasColumnName("CODORIGENMER1");
            this.Property(t => t.CODORIGENMER2).HasColumnName("CODORIGENMER2");
        }
    }
}
