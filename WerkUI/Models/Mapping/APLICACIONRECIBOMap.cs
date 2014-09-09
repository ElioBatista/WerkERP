using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class APLICACIONRECIBOMap : EntityTypeConfiguration<APLICACIONRECIBO>
    {
        public APLICACIONRECIBOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODAPLICACION, t.CODAFECTADA, t.CODCOBRANZA, t.CODMONEDA, t.CODFORCOBRO, t.TIPOAFECTADO });

            // Properties
            this.Property(t => t.CODAPLICACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODAFECTADA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOBRANZA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODFORCOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("APLICACIONRECIBO");
            this.Property(t => t.CODAPLICACION).HasColumnName("CODAPLICACION");
            this.Property(t => t.CODAFECTADA).HasColumnName("CODAFECTADA");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.FECHAAPLICACION).HasColumnName("FECHAAPLICACION");
            this.Property(t => t.TIPOAFECTADO).HasColumnName("TIPOAFECTADO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.COTIZACION1REC).HasColumnName("COTIZACION1REC");
            this.Property(t => t.COTIZACION2REC).HasColumnName("COTIZACION2REC");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODNUMCUOTA).HasColumnName("CODNUMCUOTA");
            this.Property(t => t.IMPMONCOBRO).HasColumnName("IMPMONCOBRO");

            // Relationships
            this.HasRequired(t => t.COBRANZA)
                .WithMany(t => t.APLICACIONRECIBOes)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.CODMONEDA, d.CODFORCOBRO });
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.APLICACIONRECIBOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
