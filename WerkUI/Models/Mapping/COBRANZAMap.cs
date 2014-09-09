using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COBRANZAMap : EntityTypeConfiguration<COBRANZA>
    {
        public COBRANZAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCOBRANZA, t.MON_CODMONEDA, t.CODFORCOBRO });

            // Properties
            this.Property(t => t.CODCOBRANZA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MON_CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODFORCOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOMPROBANTE)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(160);

            // Table & Column Mappings
            this.ToTable("COBRANZAS");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.MON_CODMONEDA).HasColumnName("MON_CODMONEDA");
            this.Property(t => t.MONEDARECIBO).HasColumnName("MONEDARECIBO");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.NUMCOMPROBANTE).HasColumnName("NUMCOMPROBANTE");
            this.Property(t => t.TIPCOBRO).HasColumnName("TIPCOBRO");
            this.Property(t => t.IMPORTECOBRO).HasColumnName("IMPORTECOBRO");
            this.Property(t => t.SALDOCOBRO).HasColumnName("SALDOCOBRO");
            this.Property(t => t.FECHACOBRO).HasColumnName("FECHACOBRO");
            this.Property(t => t.TOTALDESCUENTO).HasColumnName("TOTALDESCUENTO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.COTIZACION1MR).HasColumnName("COTIZACION1MR");
            this.Property(t => t.COTIZACION2MR).HasColumnName("COTIZACION2MR");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.VUELTOMR).HasColumnName("VUELTOMR");
            this.Property(t => t.FECHAPROCESO).HasColumnName("FECHAPROCESO");
            this.Property(t => t.IMPORTERECIBO).HasColumnName("IMPORTERECIBO");
            this.Property(t => t.SALDORECIBO).HasColumnName("SALDORECIBO");
            this.Property(t => t.CODCREDITO).HasColumnName("CODCREDITO");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");

            // Relationships
            this.HasMany(t => t.COBRORETENCIONs)
                .WithMany(t => t.COBRANZAS)
                .Map(m =>
                    {
                        m.ToTable("COBRORETEN");
                        m.MapLeftKey("CODCOBRANZA", "CODMONEDA", "CODFORCOBRO");
                        m.MapRightKey("CODCOMPRARETEN");
                    });

            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.COBRANZAS)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.COBRADOR)
                .WithMany(t => t.COBRANZAS)
                .HasForeignKey(d => d.CODCOBRADOR);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.COBRANZAS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.MONEDA1)
                .WithMany(t => t.COBRANZAS1)
                .HasForeignKey(d => d.MONEDARECIBO);
            this.HasRequired(t => t.MONEDA2)
                .WithMany(t => t.COBRANZAS2)
                .HasForeignKey(d => d.MON_CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.COBRANZAS)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.COBRANZAS)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasRequired(t => t.TIPOFORMACOBRO)
                .WithMany(t => t.COBRANZAS1)
                .HasForeignKey(d => d.CODFORCOBRO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.COBRANZAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.CREDITO)
                .WithMany(t => t.COBRANZAS)
                .HasForeignKey(d => d.CODCREDITO);

        }
    }
}
