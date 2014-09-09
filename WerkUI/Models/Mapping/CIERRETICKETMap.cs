using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CIERRETICKETMap : EntityTypeConfiguration<CIERRETICKET>
    {
        public CIERRETICKETMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO);

            // Properties
            this.Property(t => t.CODIGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PRIMERNUMERO)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.ULTIMONUMERO)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.NROTICKET)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CIERRETICKET");
            this.Property(t => t.CODIGO).HasColumnName("CODIGO");
            this.Property(t => t.FECHAPROCESO).HasColumnName("FECHAPROCESO");
            this.Property(t => t.HORA).HasColumnName("HORA");
            this.Property(t => t.PRIMERNUMERO).HasColumnName("PRIMERNUMERO");
            this.Property(t => t.ULTIMONUMERO).HasColumnName("ULTIMONUMERO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.TOTALGRAVADA).HasColumnName("TOTALGRAVADA");
            this.Property(t => t.TOTALEXENTA).HasColumnName("TOTALEXENTA");
            this.Property(t => t.TOTALIVA).HasColumnName("TOTALIVA");
            this.Property(t => t.TOTALGENERAL).HasColumnName("TOTALGENERAL");
            this.Property(t => t.NROZETA).HasColumnName("NROZETA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.IMPRESO).HasColumnName("IMPRESO");
            this.Property(t => t.NROTICKET).HasColumnName("NROTICKET");
            this.Property(t => t.NUMCAJA).HasColumnName("NUMCAJA");

            // Relationships
            this.HasOptional(t => t.CAJA)
                .WithMany(t => t.CIERRETICKETs)
                .HasForeignKey(d => d.NUMCAJA);
            this.HasRequired(t => t.SUCURSAL)
                .WithMany(t => t.CIERRETICKETs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CIERRETICKETs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
