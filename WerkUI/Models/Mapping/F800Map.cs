using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class F800Map : EntityTypeConfiguration<F800>
    {
        public F800Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ORDEN800, t.CODEMPRESA });

            // Properties
            this.Property(t => t.ORDEN800)
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
            this.ToTable("F800");
            this.Property(t => t.ORDEN800).HasColumnName("ORDEN800");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.RAZONSOCIAL).HasColumnName("RAZONSOCIAL");
            this.Property(t => t.ORIGINAL).HasColumnName("ORIGINAL");
            this.Property(t => t.RECTIFICADA).HasColumnName("RECTIFICADA");
            this.Property(t => t.RECTIFICACION).HasColumnName("RECTIFICACION");
            this.Property(t => t.MES).HasColumnName("MES");
            this.Property(t => t.ANHO).HasColumnName("ANHO");
            this.Property(t => t.A1).HasColumnName("A1");
            this.Property(t => t.B1).HasColumnName("B1");
            this.Property(t => t.C1).HasColumnName("C1");
            this.Property(t => t.D1).HasColumnName("D1");
            this.Property(t => t.A2).HasColumnName("A2");
            this.Property(t => t.B2).HasColumnName("B2");
            this.Property(t => t.C2).HasColumnName("C2");
            this.Property(t => t.D2).HasColumnName("D2");
            this.Property(t => t.A3).HasColumnName("A3");
            this.Property(t => t.B3).HasColumnName("B3");
            this.Property(t => t.C3).HasColumnName("C3");
            this.Property(t => t.D3).HasColumnName("D3");
            this.Property(t => t.E3).HasColumnName("E3");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.G3).HasColumnName("G3");
            this.Property(t => t.BH3).HasColumnName("BH3");
            this.Property(t => t.H3).HasColumnName("H3");
            this.Property(t => t.I3).HasColumnName("I3");
            this.Property(t => t.J3).HasColumnName("J3");
            this.Property(t => t.K3).HasColumnName("K3");
            this.Property(t => t.L3).HasColumnName("L3");
            this.Property(t => t.M3).HasColumnName("M3");
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
            this.Property(t => t.BG4).HasColumnName("BG4");
            this.Property(t => t.H4).HasColumnName("H4");
            this.Property(t => t.I4).HasColumnName("I4");
            this.Property(t => t.J4).HasColumnName("J4");
            this.Property(t => t.K4).HasColumnName("K4");
            this.Property(t => t.L4).HasColumnName("L4");
            this.Property(t => t.LUGAR).HasColumnName("LUGAR");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.LETRA).HasColumnName("LETRA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.SUCURSAL1)
                .WithMany(t => t.F800)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.F800)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
