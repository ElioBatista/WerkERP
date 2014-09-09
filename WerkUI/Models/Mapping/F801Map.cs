using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class F801Map : EntityTypeConfiguration<F801>
    {
        public F801Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ORDEN801, t.CODEMPRESA });

            // Properties
            this.Property(t => t.ORDEN801)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOMBRE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.APELLIDO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.RAZONSOCIAL)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.ORIGINAL)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RECTIFICADA)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.RECTIFICACION)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.PEFECT)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PCJECO)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PCHEOT)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CHEQUE)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.LUGAR)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.LETRA)
                .IsFixedLength()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("F801");
            this.Property(t => t.ORDEN801).HasColumnName("ORDEN801");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.RAZONSOCIAL).HasColumnName("RAZONSOCIAL");
            this.Property(t => t.ORIGINAL).HasColumnName("ORIGINAL");
            this.Property(t => t.RECTIFICADA).HasColumnName("RECTIFICADA");
            this.Property(t => t.RECTIFICACION).HasColumnName("RECTIFICACION");
            this.Property(t => t.MES).HasColumnName("MES");
            this.Property(t => t.ANHO).HasColumnName("ANHO");
            this.Property(t => t.A1).HasColumnName("A1");
            this.Property(t => t.BA1).HasColumnName("BA1");
            this.Property(t => t.B1).HasColumnName("B1");
            this.Property(t => t.BB1).HasColumnName("BB1");
            this.Property(t => t.C1).HasColumnName("C1");
            this.Property(t => t.BC1).HasColumnName("BC1");
            this.Property(t => t.D1).HasColumnName("D1");
            this.Property(t => t.BD1).HasColumnName("BD1");
            this.Property(t => t.E1).HasColumnName("E1");
            this.Property(t => t.BE1).HasColumnName("BE1");
            this.Property(t => t.A2).HasColumnName("A2");
            this.Property(t => t.BA2).HasColumnName("BA2");
            this.Property(t => t.B2).HasColumnName("B2");
            this.Property(t => t.BB2).HasColumnName("BB2");
            this.Property(t => t.C2).HasColumnName("C2");
            this.Property(t => t.BC2).HasColumnName("BC2");
            this.Property(t => t.D2).HasColumnName("D2");
            this.Property(t => t.BD2).HasColumnName("BD2");
            this.Property(t => t.E2).HasColumnName("E2");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.G2).HasColumnName("G2");
            this.Property(t => t.BG2).HasColumnName("BG2");
            this.Property(t => t.A3).HasColumnName("A3");
            this.Property(t => t.B3).HasColumnName("B3");
            this.Property(t => t.C3).HasColumnName("C3");
            this.Property(t => t.I90).HasColumnName("I90");
            this.Property(t => t.I91).HasColumnName("I91");
            this.Property(t => t.I95).HasColumnName("I95");
            this.Property(t => t.PEFECT).HasColumnName("PEFECT");
            this.Property(t => t.PCJECO).HasColumnName("PCJECO");
            this.Property(t => t.PCHEOT).HasColumnName("PCHEOT");
            this.Property(t => t.CHEQUE).HasColumnName("CHEQUE");
            this.Property(t => t.BANCO).HasColumnName("BANCO");
            this.Property(t => t.SUCURSAL).HasColumnName("SUCURSAL");
            this.Property(t => t.ANTIC).HasColumnName("ANTIC");
            this.Property(t => t.BDIA).HasColumnName("BDIA");
            this.Property(t => t.BMES).HasColumnName("BMES");
            this.Property(t => t.BANHO).HasColumnName("BANHO");
            this.Property(t => t.CMES).HasColumnName("CMES");
            this.Property(t => t.A4).HasColumnName("A4");
            this.Property(t => t.B4).HasColumnName("B4");
            this.Property(t => t.C4).HasColumnName("C4");
            this.Property(t => t.D4).HasColumnName("D4");
            this.Property(t => t.E4).HasColumnName("E4");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.G4).HasColumnName("G4");
            this.Property(t => t.H4).HasColumnName("H4");
            this.Property(t => t.I4).HasColumnName("I4");
            this.Property(t => t.J4).HasColumnName("J4");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.LUGAR).HasColumnName("LUGAR");
            this.Property(t => t.BA5).HasColumnName("BA5");
            this.Property(t => t.B5).HasColumnName("B5");
            this.Property(t => t.C5).HasColumnName("C5");
            this.Property(t => t.D5).HasColumnName("D5");
            this.Property(t => t.E5).HasColumnName("E5");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.G5).HasColumnName("G5");
            this.Property(t => t.H5).HasColumnName("H5");
            this.Property(t => t.BH5).HasColumnName("BH5");
            this.Property(t => t.I5).HasColumnName("I5");
            this.Property(t => t.BJ5).HasColumnName("BJ5");
            this.Property(t => t.K5).HasColumnName("K5");
            this.Property(t => t.BL5).HasColumnName("BL5");
            this.Property(t => t.BM5).HasColumnName("BM5");
            this.Property(t => t.BN5).HasColumnName("BN5");
            this.Property(t => t.BO5).HasColumnName("BO5");
            this.Property(t => t.B6).HasColumnName("B6");
            this.Property(t => t.BA7).HasColumnName("BA7");
            this.Property(t => t.B7).HasColumnName("B7");
            this.Property(t => t.C7).HasColumnName("C7");
            this.Property(t => t.D7).HasColumnName("D7");
            this.Property(t => t.E7).HasColumnName("E7");
            this.Property(t => t.BF7).HasColumnName("BF7");
            this.Property(t => t.G7).HasColumnName("G7");
            this.Property(t => t.BG7).HasColumnName("BG7");
            this.Property(t => t.H7).HasColumnName("H7");
            this.Property(t => t.BI7).HasColumnName("BI7");
            this.Property(t => t.BJ7).HasColumnName("BJ7");
            this.Property(t => t.BK7).HasColumnName("BK7");
            this.Property(t => t.BL7).HasColumnName("BL7");
            this.Property(t => t.LETRA).HasColumnName("LETRA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.SUCURSAL1)
                .WithMany(t => t.F801)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.F801)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
