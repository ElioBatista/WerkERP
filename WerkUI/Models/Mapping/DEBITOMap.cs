using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEBITOMap : EntityTypeConfiguration<DEBITO>
    {
        public DEBITOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDEBITO, t.CODBANCO });

            // Properties
            this.Property(t => t.CODDEBITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCUENTA)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.NUMCEDULA)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.NOMBRE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.APELLIDO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.AUTORIZADO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.CIAUTORIZADO)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.NOMBREBENE)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.CODBANCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DEBITOS");
            this.Property(t => t.CODDEBITO).HasColumnName("CODDEBITO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCUENTA).HasColumnName("NUMCUENTA");
            this.Property(t => t.CODTIPODEBITO).HasColumnName("CODTIPODEBITO");
            this.Property(t => t.NUMBOLETA).HasColumnName("NUMBOLETA");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.NUMCEDULA).HasColumnName("NUMCEDULA");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.AUTORIZADO).HasColumnName("AUTORIZADO");
            this.Property(t => t.CIAUTORIZADO).HasColumnName("CIAUTORIZADO");
            this.Property(t => t.NOMBREBENE).HasColumnName("NOMBREBENE");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.FECHACONCILIACION).HasColumnName("FECHACONCILIACION");
            this.Property(t => t.CODTIPOCHEQUE).HasColumnName("CODTIPOCHEQUE");
            this.Property(t => t.FECHAVENCIMIENTO).HasColumnName("FECHAVENCIMIENTO");
            this.Property(t => t.DEBITADO).HasColumnName("DEBITADO");
            this.Property(t => t.CODBANCO).HasColumnName("CODBANCO");
            this.Property(t => t.CODEMPRESA_CHEQUERA).HasColumnName("CODEMPRESA_CHEQUERA");
            this.Property(t => t.ANULADO).HasColumnName("ANULADO");
        }
    }
}
