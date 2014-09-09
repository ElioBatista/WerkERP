using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class APLICACIONRECIBOPAGOMap : EntityTypeConfiguration<APLICACIONRECIBOPAGO>
    {
        public APLICACIONRECIBOPAGOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODAPLICACION, t.CODPAGOAFECTADA, t.CODPAGANZAS, t.CODMONEDA, t.CODTIPOPAGO, t.TIPOAFECTADO });

            // Properties
            this.Property(t => t.CODAPLICACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPAGOAFECTADA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPAGANZAS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTIPOPAGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("APLICACIONRECIBOPAGO");
            this.Property(t => t.CODAPLICACION).HasColumnName("CODAPLICACION");
            this.Property(t => t.CODPAGOAFECTADA).HasColumnName("CODPAGOAFECTADA");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.FECHAAPLICACION).HasColumnName("FECHAAPLICACION");
            this.Property(t => t.TIPOAFECTADO).HasColumnName("TIPOAFECTADO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.COTIZACION1REC).HasColumnName("COTIZACION1REC");
            this.Property(t => t.COTIZACION2REC).HasColumnName("COTIZACION2REC");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.NUMEROCUOTA).HasColumnName("NUMEROCUOTA");
            this.Property(t => t.IMPMONPAGO).HasColumnName("IMPMONPAGO");

            // Relationships
            this.HasRequired(t => t.PAGANZA)
                .WithMany(t => t.APLICACIONRECIBOPAGOes)
                .HasForeignKey(d => new { d.CODPAGANZAS, d.CODTIPOPAGO, d.CODMONEDA });
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.APLICACIONRECIBOPAGOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
