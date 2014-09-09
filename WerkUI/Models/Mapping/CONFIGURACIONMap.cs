using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CONFIGURACIONMap : EntityTypeConfiguration<CONFIGURACION>
    {
        public CONFIGURACIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCONFIGURACION);

            // Properties
            this.Property(t => t.CODCONFIGURACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PRODUCTO1)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.PRODUCTO2)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.PRODUCTO3)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.COLOR1)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR2)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR3)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR4)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR5)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR6)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR7)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR8)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR9)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.COLOR10)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.FORMATOFECHA)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.PRODUCTO4)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.PRODUCTO5)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CONFIGURACION");
            this.Property(t => t.CODCONFIGURACION).HasColumnName("CODCONFIGURACION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CUEDIFCAMCOBRO).HasColumnName("CUEDIFCAMCOBRO");
            this.Property(t => t.CUEDIFCAMPAGO).HasColumnName("CUEDIFCAMPAGO");
            this.Property(t => t.CANDECIMALESIMPORTE).HasColumnName("CANDECIMALESIMPORTE");
            this.Property(t => t.CANDECIMALESCANTIDAD).HasColumnName("CANDECIMALESCANTIDAD");
            this.Property(t => t.MONEDA1).HasColumnName("MONEDA1");
            this.Property(t => t.MONEDA2).HasColumnName("MONEDA2");
            this.Property(t => t.PRODUCTO1).HasColumnName("PRODUCTO1");
            this.Property(t => t.PRODUCTO2).HasColumnName("PRODUCTO2");
            this.Property(t => t.PRODUCTO3).HasColumnName("PRODUCTO3");
            this.Property(t => t.CALCIVA).HasColumnName("CALCIVA");
            this.Property(t => t.CALCDESC).HasColumnName("CALCDESC");
            this.Property(t => t.PORCENDESC).HasColumnName("PORCENDESC");
            this.Property(t => t.COSTOPP).HasColumnName("COSTOPP");
            this.Property(t => t.COSTOUC).HasColumnName("COSTOUC");
            this.Property(t => t.COLOR1).HasColumnName("COLOR1");
            this.Property(t => t.COLOR2).HasColumnName("COLOR2");
            this.Property(t => t.COLOR3).HasColumnName("COLOR3");
            this.Property(t => t.COLOR4).HasColumnName("COLOR4");
            this.Property(t => t.COLOR5).HasColumnName("COLOR5");
            this.Property(t => t.COLOR6).HasColumnName("COLOR6");
            this.Property(t => t.COLOR7).HasColumnName("COLOR7");
            this.Property(t => t.COLOR8).HasColumnName("COLOR8");
            this.Property(t => t.COLOR9).HasColumnName("COLOR9");
            this.Property(t => t.COLOR10).HasColumnName("COLOR10");
            this.Property(t => t.TAMANO1).HasColumnName("TAMANO1");
            this.Property(t => t.TAMANO2).HasColumnName("TAMANO2");
            this.Property(t => t.TAMANO3).HasColumnName("TAMANO3");
            this.Property(t => t.TAMANO4).HasColumnName("TAMANO4");
            this.Property(t => t.TAMANO5).HasColumnName("TAMANO5");
            this.Property(t => t.TAMANO6).HasColumnName("TAMANO6");
            this.Property(t => t.FORMATOFECHA).HasColumnName("FORMATOFECHA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CONCOMPRAS).HasColumnName("CONCOMPRAS");
            this.Property(t => t.CONVENTAS).HasColumnName("CONVENTAS");
            this.Property(t => t.CONCAJA).HasColumnName("CONCAJA");
            this.Property(t => t.CONCOBROS).HasColumnName("CONCOBROS");
            this.Property(t => t.CONPAGOS).HasColumnName("CONPAGOS");
            this.Property(t => t.CONBANCOS).HasColumnName("CONBANCOS");
            this.Property(t => t.CONDEVO).HasColumnName("CONDEVO");
            this.Property(t => t.CONTRANSFER).HasColumnName("CONTRANSFER");
            this.Property(t => t.CONAJUSTE).HasColumnName("CONAJUSTE");
            this.Property(t => t.CONTARJE).HasColumnName("CONTARJE");
            this.Property(t => t.CONNDEBITO).HasColumnName("CONNDEBITO");
            this.Property(t => t.CONNCREDITO).HasColumnName("CONNCREDITO");
            this.Property(t => t.CONRETENPRO).HasColumnName("CONRETENPRO");
            this.Property(t => t.CONRETENCLI).HasColumnName("CONRETENCLI");
            this.Property(t => t.PRODUCTO4).HasColumnName("PRODUCTO4");
            this.Property(t => t.PRODUCTO5).HasColumnName("PRODUCTO5");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.CONFIGURACIONs)
                .HasForeignKey(d => d.CUEDIFCAMPAGO);
            this.HasOptional(t => t.PLANCUENTA1)
                .WithMany(t => t.CONFIGURACIONs1)
                .HasForeignKey(d => d.CUEDIFCAMCOBRO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CONFIGURACIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
