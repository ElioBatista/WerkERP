using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class F805Map : EntityTypeConfiguration<F805>
    {
        public F805Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ORDEN805, t.CODEMPRESA });

            // Properties
            this.Property(t => t.ORDEN805)
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

            // Table & Column Mappings
            this.ToTable("F805");
            this.Property(t => t.ORDEN805).HasColumnName("ORDEN805");
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
            this.Property(t => t.BD1).HasColumnName("BD1");
            this.Property(t => t.BE1).HasColumnName("BE1");
            this.Property(t => t.BF1).HasColumnName("BF1");
            this.Property(t => t.BG1).HasColumnName("BG1");
            this.Property(t => t.BH1).HasColumnName("BH1");
            this.Property(t => t.BI1).HasColumnName("BI1");
            this.Property(t => t.J1).HasColumnName("J1");
            this.Property(t => t.K1).HasColumnName("K1");
            this.Property(t => t.BK1).HasColumnName("BK1");
            this.Property(t => t.L1).HasColumnName("L1");
            this.Property(t => t.BL1).HasColumnName("BL1");
            this.Property(t => t.M1).HasColumnName("M1");
            this.Property(t => t.BN1).HasColumnName("BN1");
            this.Property(t => t.BA2).HasColumnName("BA2");
            this.Property(t => t.B2).HasColumnName("B2");
            this.Property(t => t.C2).HasColumnName("C2");
            this.Property(t => t.D2).HasColumnName("D2");
            this.Property(t => t.BD2).HasColumnName("BD2");
            this.Property(t => t.E2).HasColumnName("E2");
            this.Property(t => t.BE2).HasColumnName("BE2");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.BG2).HasColumnName("BG2");
            this.Property(t => t.BH2).HasColumnName("BH2");
            this.Property(t => t.I95).HasColumnName("I95");
            this.Property(t => t.PEFECT).HasColumnName("PEFECT");
            this.Property(t => t.PCJECO).HasColumnName("PCJECO");
            this.Property(t => t.PCHEOT).HasColumnName("PCHEOT");
            this.Property(t => t.CHEQUE).HasColumnName("CHEQUE");
            this.Property(t => t.BANCO).HasColumnName("BANCO");
            this.Property(t => t.SUCURSAL).HasColumnName("SUCURSAL");
            this.Property(t => t.BA3).HasColumnName("BA3");
            this.Property(t => t.BB3).HasColumnName("BB3");
            this.Property(t => t.BC3).HasColumnName("BC3");
            this.Property(t => t.BD3).HasColumnName("BD3");
            this.Property(t => t.E3).HasColumnName("E3");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.G3).HasColumnName("G3");
            this.Property(t => t.H3).HasColumnName("H3");
            this.Property(t => t.I3).HasColumnName("I3");
            this.Property(t => t.J3).HasColumnName("J3");
            this.Property(t => t.BK3).HasColumnName("BK3");
            this.Property(t => t.L3).HasColumnName("L3");
            this.Property(t => t.BL3).HasColumnName("BL3");
            this.Property(t => t.M3).HasColumnName("M3");
            this.Property(t => t.BN3).HasColumnName("BN3");
            this.Property(t => t.BO3).HasColumnName("BO3");
            this.Property(t => t.BP3).HasColumnName("BP3");
            this.Property(t => t.BQ3).HasColumnName("BQ3");
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
            this.Property(t => t.K4).HasColumnName("K4");
            this.Property(t => t.L4).HasColumnName("L4");
            this.Property(t => t.M4).HasColumnName("M4");
            this.Property(t => t.N4).HasColumnName("N4");
            this.Property(t => t.O4).HasColumnName("O4");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.LUGAR).HasColumnName("LUGAR");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.SUCURSAL1)
                .WithMany(t => t.F805)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.F805)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
