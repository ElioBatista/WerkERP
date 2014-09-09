using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRODUCTOMap : EntityTypeConfiguration<PRODUCTO>
    {
        public PRODUCTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPRODUCTO);

            // Properties
            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOLOR)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.NUMTALLE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESPRODUCTO)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.CODIGOBARRA)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.CODIGOORIGINAL)
                .IsFixedLength()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("PRODUCTOS");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODRUBRO).HasColumnName("CODRUBRO");
            this.Property(t => t.CODFAMILIA).HasColumnName("CODFAMILIA");
            this.Property(t => t.CODLINEA).HasColumnName("CODLINEA");
            this.Property(t => t.NUMCOLOR).HasColumnName("NUMCOLOR");
            this.Property(t => t.COL_CODEMPRESA).HasColumnName("COL_CODEMPRESA");
            this.Property(t => t.NUMTALLE).HasColumnName("NUMTALLE");
            this.Property(t => t.TAL_CODEMPRESA).HasColumnName("TAL_CODEMPRESA");
            this.Property(t => t.CODIVA).HasColumnName("CODIVA");
            this.Property(t => t.CODMEDIDA).HasColumnName("CODMEDIDA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODESTADOPRODUCTO).HasColumnName("CODESTADOPRODUCTO");
            this.Property(t => t.CUENTAMERCADERIA).HasColumnName("CUENTAMERCADERIA");
            this.Property(t => t.CUENTAVENTA).HasColumnName("CUENTAVENTA");
            this.Property(t => t.CUENTACOSTO).HasColumnName("CUENTACOSTO");
            this.Property(t => t.CODDESCUENTO).HasColumnName("CODDESCUENTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.DESPRODUCTO).HasColumnName("DESPRODUCTO");
            this.Property(t => t.CODIGOBARRA).HasColumnName("CODIGOBARRA");
            this.Property(t => t.COSTOANTERIOR).HasColumnName("COSTOANTERIOR");
            this.Property(t => t.STOCKMINIMO).HasColumnName("STOCKMINIMO");
            this.Property(t => t.STOCKMAXIMO).HasColumnName("STOCKMAXIMO");
            this.Property(t => t.FECHAINGRESO).HasColumnName("FECHAINGRESO");
            this.Property(t => t.CODIGOORIGINAL).HasColumnName("CODIGOORIGINAL");
            this.Property(t => t.PRODUCTOACTIVO).HasColumnName("PRODUCTOACTIVO");
            this.Property(t => t.ULTIMOCOSTO).HasColumnName("ULTIMOCOSTO");
            this.Property(t => t.PORCENCOMI).HasColumnName("PORCENCOMI");
            this.Property(t => t.IMAGEN).HasColumnName("IMAGEN");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.COSTOPP).HasColumnName("COSTOPP");
            this.Property(t => t.FECHAPP).HasColumnName("FECHAPP");
            this.Property(t => t.USUPP).HasColumnName("USUPP");
            this.Property(t => t.ORDPRE).HasColumnName("ORDPRE");
            this.Property(t => t.EMPREUSUPP).HasColumnName("EMPREUSUPP");

            // Relationships
            this.HasOptional(t => t.COLOR)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => new { d.NUMCOLOR, d.COL_CODEMPRESA });
            this.HasOptional(t => t.DESCUENTOPRODUCTO)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODDESCUENTO);
            this.HasOptional(t => t.ESTADOPRODUCTO)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODESTADOPRODUCTO);
            this.HasOptional(t => t.FAMILIA)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODFAMILIA);
            this.HasOptional(t => t.IVA)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODIVA);
            this.HasOptional(t => t.LINEA)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODLINEA);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CUENTACOSTO);
            this.HasOptional(t => t.PLANCUENTA1)
                .WithMany(t => t.PRODUCTOS1)
                .HasForeignKey(d => d.CUENTAVENTA);
            this.HasOptional(t => t.PLANCUENTA2)
                .WithMany(t => t.PRODUCTOS2)
                .HasForeignKey(d => d.CUENTAMERCADERIA);
            this.HasOptional(t => t.RUBRO)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODRUBRO);
            this.HasOptional(t => t.TALLE)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => new { d.NUMTALLE, d.TAL_CODEMPRESA });
            this.HasOptional(t => t.UNIDADMEDIDA)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODMEDIDA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.PRODUCTOS)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.USUARIO1)
                .WithMany(t => t.PRODUCTOS1)
                .HasForeignKey(d => new { d.USUPP, d.EMPREUSUPP });

        }
    }
}
